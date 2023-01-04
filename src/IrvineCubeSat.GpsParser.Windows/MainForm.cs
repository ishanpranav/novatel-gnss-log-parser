// MainForm.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrvineCubeSat.GpsParser.Windows;

internal sealed partial class MainForm : Form
{
    private readonly AsciiGpsParser _parser = new AsciiGpsParser();
    private readonly string _text;

    public MainForm()
    {
        InitializeComponent();

        _text = Resources.Title;
        vendorToolStripStatusLabel.Alignment = ToolStripItemAlignment.Right;
        vendorToolStripStatusLabel.Text = Resources.VendorMessage;
    }

    protected override void OnLoad(EventArgs e)
    {
        Text = _text;

        base.OnLoad(e);
    }

    protected override void OnDragOver(DragEventArgs drgevent)
    {
        if (drgevent.Data is not null && drgevent.Data.GetDataPresent(DataFormats.FileDrop))
        {
            drgevent.Effect = DragDropEffects.Copy;
        }
        else
        {
            drgevent.Effect = DragDropEffects.None;
        }

        base.OnDragOver(drgevent);
    }

    protected override async void OnDragDrop(DragEventArgs drgevent)
    {
        if (drgevent.Data is not null && drgevent.Data.GetData(DataFormats.FileDrop) is string[] fileNames && fileNames.Length > 0)
        {
            await OpenAsync(fileNames[0]);
        }

        base.OnDragDrop(drgevent);
    }

    private void OnListViewSelectedIndexChanged(object sender, EventArgs e)
    {
        if (myListView.SelectedIndices.Count is 1)
        {
            ListViewItem item = myListView.SelectedItems[0];
            object tag = item.Tag;

            if (tag is IEnumerable)
            {
                myDataGridView.Show();
                myPropertyGrid.Hide();

                myDataGridView.DataSource = tag;
            }
            else
            {
                myPropertyGrid.Show();
                myDataGridView.Hide();

                myPropertyGrid.SelectedObject = tag;
            }

            myTextBox.Text = item.ToolTipText;
        }
    }

    private async void OnOpenClick(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Filter = Resources.GetFilter(),
            FilterIndex = 2
        };

        if (openFileDialog.ShowDialog() is DialogResult.OK)
        {
            await OpenAsync(openFileDialog.FileName);
        }
    }

    private async Task OpenAsync(string fileName)
    {
        string relativePath = Path.GetRelativePath(Environment.CurrentDirectory, fileName);

        if (relativePath.Length < fileName.Length)
        {
            fileName = relativePath;
        }

        Text = $"{_text} - {fileName}";
        myDataGridView.DataSource = null;
        myPropertyGrid.SelectedObject = null;

        myListView.Items.Clear();
        myTextBox.Clear();

        Dictionary<Type, int> commands = new Dictionary<Type, int>();

        await foreach (AsciiMessage message in _parser.ParseAsync(await File.ReadAllTextAsync(fileName)))
        {
            ListViewGroup group;
            Type type = message.Command.GetType();

            if (commands.TryGetValue(type, out int ordinal))
            {
                group = myListView.Groups[message.Header.Command];
            }
            else
            {
                group = new ListViewGroup(message.Header.Command, Resources.GetString(message.Header.Command));

                myListView.Groups.Add(group);
            }

            ordinal++;
            commands[type] = ordinal;

            myListView.Items.Add(new ListViewItem(new string[]
            {
                Resources.GetHeaderMessage(commands[type]),
                message.Checksum.ToString(format: "x8"),
                message.ExpectedChecksum.ToString(format: "x8")
            }, group)
            {
                Tag = message.Header,
                ToolTipText = message.ToString()
            });

            myListView.Items.Add(new ListViewItem(new string[]
            {
                Resources.GetCommandMessage(commands[type]),
                message.Checksum.ToString(format: "x8"),
                message.ExpectedChecksum.ToString(format: "x8")
            }, group)
            {
                Tag = message.Command,
                ToolTipText = message.ToString()
            });
        }

        myDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        myListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        myToolStripStatusLabel.Text = Resources.GetStatusMessage(myListView.Items.Count / 2);
    }

    private async void OnAboutClick(object sender, EventArgs e)
    {
        using Process? process = Process.Start(new ProcessStartInfo()
        {
            FileName = "https://github.com/ishanpranav/novatel-gnss-log-parser",
            UseShellExecute = true
        });

        if (process is not null)
        {
            await process.WaitForExitAsync();
        }
    }
}
