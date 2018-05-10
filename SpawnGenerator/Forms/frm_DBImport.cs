using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnGenerator.Forms
{
    public partial class frm_DBImport : Form
    {
        PacketFiltering filter = new PacketFiltering();
        DBConnect connect;
        int affectedRows = 0;
        public frm_DBImport()
        {
            InitializeComponent();

            string host = Properties.Settings.Default.Host;
            string database = Properties.Settings.Default.Database;
            string user = Properties.Settings.Default.User;
            string password = Properties.Settings.Default.Password;
            string port = Properties.Settings.Default.Port;
            connect = new DBConnect(host, database, user, password, port);
        }

        private void btn_loadSniff_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Parsed Sniff File (*.txt)|*.txt";
            openFileDialog.FileName = "*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowReadOnly = false;
            openFileDialog.Multiselect = true;
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int numOfFiles = openFileDialog.FileNames.Length;
                int currentFile = 0;
                progress.Step = 100 / numOfFiles;

                foreach (String file in openFileDialog.FileNames)
                {
                    currentFile++;
                    lbl_currentFileCount.Text = "File " + currentFile + "/" + numOfFiles;
                    progress.PerformStep();
                    lbl_currentFileName.Text = file;
                    string importString = filter.ImportGameobjectString(file, box_createObject2.Checked);
                    ImportDataToDB(importString);
                }

                lbl_currentFileCount.Text = "Done!";
                progress.Value = 0;
            }
            else
            {
                // This code runs if the dialog was cancelled
                return;
            }
        }

        private void ImportDataToDB(string importString)
        {
            int newLineLen = Environment.NewLine.Length;
            int numLines = importString.Length - importString.Replace(Environment.NewLine, string.Empty).Length;
            if (newLineLen != 0)
            {
                numLines /= newLineLen;
                numLines++;
            }
            rtxt_SQLResult.Text = importString + "\n";
            int rowCount = connect.RunQuery(importString);
            affectedRows += rowCount;
            lbl_affectedRows.Text = "Affected Rows: " + affectedRows;
        }
    }
}
