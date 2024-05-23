using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountingNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBoxMain_Enter(object sender, EventArgs e)
        {

        }



        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void ColorRed_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
            if (!(ColorRed.Checked))
            {
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void ColorBlue_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
            if (!(ColorBlue.Checked))
            {
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void ColorGreen_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
            if (!(ColorGreen.Checked))
            {
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void Italic_CheckedChanged(object sender, EventArgs e)
        {
            if (Italic.Checked)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
            }
        }

        private void Bold_CheckedChanged(object sender, EventArgs e)
        {
            float size = 9;
            if (Bold.Checked)
            {
                size = richTextBox1.Font.Size;
                if (Bold.Checked)
                    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 14, FontStyle.Bold);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Regular);
            }
        }

        private void CountB_Click(object sender, EventArgs e)
        {
            bool c1 = true;
            bool c2 = false;
            bool c3 = false;
            int start = 0;
            int end = 0;
            int divide = 0;


            try
            {


                c1 = int.TryParse(StartTB.Text, out start);

                c2 = int.TryParse(EndTB.Text, out end);

                c3 = int.TryParse(DivisibleCB.SelectedItem.ToString(), out divide);
                if (divide == 0 || start >= end)
                {
                    throw new Exception();
                }


                //MessageBox.Show($"{start} , {end} , {divide}");

            }
            catch (Exception err)
            {
                MessageBox.Show("please fill all nessecery fill and do it " +
                    "resunably");
            }
            if (c1 && c2 && c3)
            {
                richTextBox1.Text = "";
                start = start + (divide - (start % divide)) * (start % divide == 0 ? 0 : 1);
                for (int i = start; i <= end; i = i + divide)
                {
                    //Thread.Sleep(100);
                    richTextBox1.AppendText(i.ToString() + " ");

                }
            }
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
