// MainForm.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IrvineCubeSat.GpsParser.Windows;

internal sealed partial class MainForm : Form
{
    private readonly AsciiGpsParser _parser = new AsciiGpsParser();
    private readonly string _text;

    public MainForm()
    {
        InitializeComponent();

        vendorToolStripStatusLabel.Alignment = ToolStripItemAlignment.Right;
        vendorToolStripStatusLabel.Text = Resources.VendorMessage;

        _text = Resources.Title;
    }

    protected override void OnDragEnter(DragEventArgs drgevent)
    {
        if (drgevent.Data is not null && drgevent.Data.GetData(DataFormats.FileDrop) is string[])
        {
            drgevent.Effect = DragDropEffects.Copy;
        }

        base.OnDragEnter(drgevent);
    }

    private void OnListViewSelectedIndexChanged(object sender, EventArgs e)
    {
        if (myListView.SelectedIndices.Count is 1)
        {
            myPropertyGrid.SelectedObject = myListView.SelectedItems[0].Tag;
            myTextBox.Text = myListView.SelectedItems[0].ToolTipText;
        }
    }

    private async void OnOpenClick(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Filter = Resources.GetFilter(),
            FilterIndex = 2
        };

        if (openFileDialog.ShowDialog() is not DialogResult.OK)
        {
            return;
        }

        string path = openFileDialog.FileName;
        string relativePath = Path.GetRelativePath(Environment.CurrentDirectory, path);

        if (relativePath.Length < path.Length)
        {
            path = relativePath;
        }

        Text = $"{_text} - {path}";
        myListView.Items.Clear();
        myPropertyGrid.SelectedObject = null;
        myTextBox.Clear();

        Dictionary<Type, int> commands = new Dictionary<Type, int>();

        await foreach (AsciiMessage message in _parser.ParseAsync(await File.ReadAllTextAsync(openFileDialog.FileName)))
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

        myListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        myToolStripStatusLabel.Text = Resources.GetStatusMessage(myListView.Items.Count / 2);
    }

    private async void OnAboutClick(object sender, EventArgs e)
    {
        using Process? process = Process.Start(new ProcessStartInfo()
        {
            FileName = "http://github.com/ishanpranav/novatel-gnss-log-parser",
            UseShellExecute = true
        });

        if (process is null)
        {
            return;
        }

        await process.WaitForExitAsync();
    }
}
