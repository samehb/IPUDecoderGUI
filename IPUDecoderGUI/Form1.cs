using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace IPUDecoderGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            FileStream IPSFile;
            BinaryReader IPSFileReader;
            FileStream IPUFile;
            BinaryWriter IPUFileWriter;
            FileStream MSVFile;
            BinaryWriter MSVFileWriter;

            string Mode = ModeCB.Checked ? "1" : "0";

            StatusLabel.Text = "";

            try
            {
                for (int j = 0; j < IPUStreamsListBox.Items.Count; j++)
                {
                    string IPSFileName = IPUStreamsListBox.Items[j].ToString().Split('.')[0];
                    string IPSFileExt = IPUStreamsListBox.Items[j].ToString().Split('.')[1];

                    IPSFile = new FileStream(IPSFileName + "." + IPSFileExt, FileMode.Open, FileAccess.Read);
                    IPSFileReader = new BinaryReader(IPSFile);

                    if (IPSFileExt.ToLower()=="ips")
                    {

                        IPUFile = new FileStream(IPSFileName + ".ipu", FileMode.Create, FileAccess.Write);
                        IPUFileWriter = new BinaryWriter(IPUFile);

                        MSVFile = new FileStream(IPSFileName + ".msv", FileMode.Create, FileAccess.Write);
                        MSVFileWriter = new BinaryWriter(MSVFile);


                        IPSFileReader.ReadUInt32();
                        uint IPUStreamSize = IPSFileReader.ReadUInt32() + 8;

                        uint IPUStreamBlockCount = (IPUStreamSize / 32768) + 1;

                        IPSFile.Seek(0, SeekOrigin.Begin);

                        for (int i = 0; i < IPUStreamBlockCount; i++)
                        {
                            IPUFileWriter.Write(IPSFileReader.ReadBytes(32768));
                        }

                        long MSVStreamSize = IPSFile.Length - IPSFile.Position;

                        for (int i = 0; i < MSVStreamSize; i++)
                        {
                            MSVFileWriter.Write(IPSFileReader.ReadByte());
                        }

                        IPSFileReader.Close();
                        IPUFileWriter.Close();
                        MSVFileWriter.Close();

                    }

                    Process ps = new Process();
                    ps.StartInfo.FileName = @"IPUDecoder.exe";
                    ps.StartInfo.CreateNoWindow = true;
                    ps.StartInfo.UseShellExecute = false;
                    ps.StartInfo.RedirectStandardOutput = false;
                    ps.StartInfo.Arguments = IPSFileName + ".ipu" + " " + IPSFileName + ".m2v" + " " + Mode;
                    ps.Start();
                    ps.WaitForExit();

                }
                StatusLabel.Text = "Files converted successfully.";
            }
            catch
            {
                StatusLabel.Text = "Could not convert the files. Please refer to the README file for solutions.";
            }
        }

        private void IPUStreamsListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!IPUStreamsListBox.Items.Contains(file.Substring(file.LastIndexOf("\\") + 1)) && (file.ToLower().EndsWith(".ips") || file.ToLower().EndsWith(".ipu")))
                {
                    IPUStreamsListBox.Items.Add(file.Substring(file.LastIndexOf("\\") + 1));
                }
            }
        }

        private void IPUStreamsListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
        }
    }
}
