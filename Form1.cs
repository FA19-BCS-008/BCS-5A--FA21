using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files(*.txt)|*.txt|document file(*.docx)|*.docx|web file(*.html)|*.html|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK) ;
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                txtContent.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
       
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save text files";
            saveFileDialog1.Filter = "txt file(*.txt)|*.txt";
           if( saveFileDialog1.ShowDialog()== DialogResult.OK);
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
                sw.Write(txtContent.Text);
                sw.Close();

            }
           

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d;
            MessageBox.Show("****[Welcome to My Text Editor]*****" + "\n\n~Irsa Shahzadi" + "\n~FA19-BCS-008(5A)" + "\n~Visual Programming");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FontDialog1.ShowDialog();
            txtContent.Font = fontDialog1.Font;
          
        } 

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Paste();

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
        }


        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            txtContent.Clear();
           

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        { 
           

        
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "text files(*.txt)|*.txt|document file(*.docx)|*.docx|web file(*.html)|*.html|All Files(*.*)|*.*";
            saveFileDialog1.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Have a Good Day";

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
        }
    }
}
