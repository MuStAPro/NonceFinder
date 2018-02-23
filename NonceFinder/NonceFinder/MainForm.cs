using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NonceFiner is an application designed to quickly find the nonce value from an shsh2 file.\r\nBy /u/mustapro and designed for /r/jailbreak.");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filePath = open.FileName;
                    txtFilePath.Text = filePath;
                    txtNonce.Text = getNonce(filePath);
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
    }
}
