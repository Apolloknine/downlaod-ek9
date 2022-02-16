using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace kanine9
{
    public partial class Form3 : Form
    {
        ExploitAPI API = new ExploitAPI();
        public Form3()
        {
            InitializeComponent();
        }

        private void siticoneImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneImageButton2_Click(object sender, EventArgs e)
        {
            

        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void siticoneImageButton5_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void siticoneImageButton6_Click(object sender, EventArgs e)
        {
             API.SendLuaScript("");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneImageButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            API.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            API.LaunchExploit();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            functions.PopulateListBox(listBox1, "./Scripts", "*.lua");

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("https://pastebin.com/raw/mtrRP1H1");
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
