// MainForm.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using IrvineCubeSat.GpsParser.Windows.Properties;

namespace IrvineCubeSat.GpsParser.Windows
{
    internal sealed partial class MainForm : Form
    {
        private readonly AsciiGpsParser _parser = new AsciiGpsParser();
        private readonly string _text;

        public MainForm()
        {
            InitializeComponent();

            vendorToolStripStatusLabel.Alignment = ToolStripItemAlignment.Right;
            vendorToolStripStatusLabel.Text = Resources.VendorMessage;

            _text = Text;
        }

        private void OnListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            if (myListView.SelectedIndices.Count == 1)
            {
                myPropertyGrid.SelectedObject = myListView.SelectedItems[0].Tag;
                myTextBox.Text = myListView.SelectedItems[0].ToolTipText;
            }
        }

        private async void OnOpenClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = string.Format("{0} (*.*)|*.*|{1} (*.gps;*.log;*.txt)|*.gps;*.log;*.txt|{2} (*.gps)|*.gps|{3} (*.log)|*.log|{4} (*.txt)|*.txt", Resources.AllFilesMessage, Resources.SupportedFilesMessage, Resources.GpsFilesMessage, Resources.LogFilesMessage, Resources.TextDocumentsMessage),
                FilterIndex = 2
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
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

                    Dictionary<string, int> commands = new Dictionary<string, int>();

                    await foreach (AsciiMessage message in _parser.ParseAsync(await File.ReadAllTextAsync(openFileDialog.FileName)))
                    {
                        ListViewGroup group;

                        if (commands.TryAdd(message.Header.Command, value: 1))
                        {
                            group = new ListViewGroup(message.Header.Command, message.Header.Command);

                            myListView.Groups.Add(group);
                        }
                        else
                        {
                            group = myListView.Groups[message.Header.Command];

                            commands[message.Header.Command]++;
                        }

                        myListView.Items.Add(new ListViewItem(new string[]
                        {
                            string.Format(Resources.HeaderFormat, commands[message.Header.Command]),
                            message.Checksum.ToString(format: "x8"),
                            message.ExpectedChecksum.ToString(format: "x8")
                        }, group)
                        {
                            Tag = message.Header,
                            ToolTipText = message.ToString()
                        });

                        myListView.Items.Add(new ListViewItem(new string[]
                        {
                            string.Format(Resources.CommandFormat, commands[message.Header.Command]),
                            message.Checksum.ToString(format: "x8"),
                            message.ExpectedChecksum.ToString(format: "x8")
                        }, group)
                        {
                            Tag = message.Command,
                            ToolTipText = message.ToString()
                        });
                    }

                    myListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                    myToolStripStatusLabel.Text = string.Format(Resources.StatusFormat, myListView.Items.Count / 2);
                }
            }
        }

        private async void OnAboutClick(object sender, EventArgs e)
        {
            using (Process? process = Process.Start(new ProcessStartInfo
            {
                FileName = "http://github.com/ishanpranav/novatel-gnss-log-parser",
                UseShellExecute = true
            }))
            {
                if (process != null)
                {
                    await process.WaitForExitAsync();
                }
            }
        }
    }
}
