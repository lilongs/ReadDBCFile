using Aptiv.DBCFiles;
using Aptiv.DBCFiles.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFormDBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = file.FileName;
            }
            DBCFile dbcFile = new DBCFile(file.FileName, true);

            Dictionary<string, Dictionary<string, List<string>>> Attributes = dbcFile.Attributes;
            string FileName=dbcFile.Filename;
            Dictionary<string, DBCMessage> messages =dbcFile.messages;
            Dictionary<int, string> MsgSendTypes=dbcFile.MsgSendTypes;
            Dictionary<string, int> NS_Lib = dbcFile.NS_Lib;
            Dictionary<string, List<IDBCSignal>> SignalGroups = dbcFile.SignalGroups;
        }
    }
}
