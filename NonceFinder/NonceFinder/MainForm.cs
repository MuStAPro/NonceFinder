using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NonceFinder
{
    public partial class NonceFinder : Form
    {
        public NonceFinder()
        {
            InitializeComponent();
            copyNonce.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "NonceFinder is an application designed to quickly find the nonce generator value from a '.shsh2' file.\r\n\r\n------------------------------------------------------------------------------\r\n\r\nHow to Use:\r\n\r\n1. Click 'Browse' and locate your SHSH2 file\r\n------------------------------------------------------------------------------\r\n\r\n\r\nCreated by MuStAPro and updated by FutureFlash on 2/12/2020",
            "NonceFinder (v2.0)",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            try
            {
                openFileDialog1.FileName = "blob.shsh2";
                openFileDialog1.Filter = "SHSH2 Blob File|*.shsh2";
                openFileDialog1.FilterIndex = 1;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    txtFilePath.Text = filePath;
                    txtNonce.Text = getNonce(filePath);
                    if (string.IsNullOrEmpty(txtNonce.Text))
                    {
                        copyNonce.Enabled = false;
                    }
                    else
                    {
                        copyNonce.Enabled = true;
                    }
                }
            }
            catch { }
        }

        private string getNonce(string filePath)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(filePath);

                if (!(xml == null))
                {
                    string nodeStr = "";
                    XmlNodeList nodeList = xml.GetElementsByTagName("string");

                    foreach (XmlNode node in nodeList)
                    {
                        if (node.InnerXml.StartsWith("0x"))
                        {
                            nodeStr = node.InnerXml;
                        }
                    }
                    return nodeStr;
                }
                else
                {
                    return "";
                }
            }
            catch {
                return "";
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.reddit.com/user/mustapro");
        }

        private void copyNonce_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtNonce.Text);
            copyNonce.Text = "Coped!";
        }

        private void copyNonce_MouseHover(object sender, EventArgs e)
        {
            copyNonce.Text = "Copy";
        }
    }
}
