using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPLR2
{
    public partial class FMask : Form
    {
        private RichTextBox WordEnter;
        private int startCaretPostion;
        private int caretPostion;
        Regex regex;
  

        public FMask()
        {
            InitializeComponent();
        }

        public FMask(RichTextBox WordEnter, int caretPosition)
        {
            InitializeComponent();
            this.WordEnter = WordEnter;
            startCaretPostion = caretPosition;
            caretPostion = startCaretPostion;

        }
        private void Next_Click(object sender, EventArgs e)
        {
            FFind fFind = new FFind();
            fFind.Activate();

            Find();
          
           
        }


        private Regex getMask()
        {
            
            string text = @"[\s\n\b]"+MaskEnter.Text+@"[\s\n\b]" ;
            text = text.Replace("\\+", @"[^a-zA-Z1-9!@#\$\^\&\(\)_=\[\]\{\}\;\'\:\""\,\.\<\>\?\~ ]*");

            return new Regex(text);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Start_CheckedChanged(object sender, EventArgs e)
        {
            caretPostion = 0;
        }

        private void Cursor_CheckedChanged(object sender, EventArgs e)
        {
            caretPostion = startCaretPostion;
        }

        private void Find()
        {

            Regex regex = getMask();
            Match match = regex.Match(WordEnter.Text,  WordEnter.SelectionLength + WordEnter.SelectionStart);
            if (!match.Success)
            { MessageBox.Show("No matches");
                return;
            }
               
            WordEnter.SelectionStart = match.Index;
            WordEnter.SelectionLength = match.Length;
            WordEnter.Select();
           
           

           

        }

        private void MaskEnter_TextChanged(object sender, EventArgs e)
        {
            if(MaskEnter.TextLength==0)
            {    
                Next.Enabled = false;
            }
            else
            {
                Next.Enabled = true;
            }
        }

        private void FMask_Load(object sender, EventArgs e)
        {

        }
    }
}
