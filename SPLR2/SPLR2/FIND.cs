using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SPLR2
{
    public partial class FFind : Form
    {
       
      int selectionStart;

        public FFind()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//Find
        {
            FMask mask = new FMask(this.WordEnter, selectionStart);
            mask.Show();
            this.WordEnter.SelectionStart = selectionStart;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

   
        private void button2_Click(object sender, EventArgs e)//Cancel
        {
            Close();
        }

        private void Open_Click(object sender, EventArgs e)
        {

           OpenFileDialog o = new OpenFileDialog();
            o.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (o.ShowDialog() == DialogResult.OK)
            {
                WordEnter.Text = File.ReadAllText(o.FileName, Encoding.Default);
           
            }


        }
        private void WordEnter_TextChanged(object sender, EventArgs e)
        {
            if (WordEnter.TextLength == 0)
            {
                Clean.Enabled = false;
                Find.Enabled = false;
            }
            else
            {
                Clean.Enabled = true;
                Find.Enabled = true;
                Find.BackColor = Color.Red;
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            WordEnter.Clear();
        }

        private void FFind_Load(object sender, EventArgs e)
        {

        }
    }
}

     