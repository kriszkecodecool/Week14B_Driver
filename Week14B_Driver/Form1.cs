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

namespace Week14B_Driver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] directories = Directory.GetDirectories(@"C:\");
            string[] files = Directory.GetFiles(@"C:\");
            listBox1.Items.AddRange(directories);
            listBox1.Items.AddRange(files);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                comboBox1.Text = @"C:\";
            }
            else
            {
                comboBox1.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] directories = Directory.GetDirectories(comboBox1.Text);
            string[] files = Directory.GetFiles(comboBox1.Text);
            listBox1.Items.AddRange(directories);
            listBox1.Items.AddRange(files);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            comboBox1.Text = @"C:\";
        }
    }
}
