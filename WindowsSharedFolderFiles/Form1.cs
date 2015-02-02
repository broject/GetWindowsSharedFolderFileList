using ExtremeMirror;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsSharedFolderFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

            // ene class ni windows shared folder handalt hiih erh uusgej ogdog
            PinvokeWindowsNetworking.connectToRemote(textBox1.Text, "username", "password");

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                listBox1.Items.Add(file.Name);
            }
        }
    }
}
