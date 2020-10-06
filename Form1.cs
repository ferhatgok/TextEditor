using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.richTextBox1.MouseWheel += Mause_MouseWheel;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
            void Mause_MouseWheel(object sender, MouseEventArgs e)
        {
            float FontSize = richTextBox1.Font.Size;
                
                if (e.Delta > 0)
                {
                    FontSize += 1f;
                    richTextBox1.Font = new Font(richTextBox1.Font.Name, FontSize, richTextBox1.Font.Style, richTextBox1.Font.Unit);
                }
                    
                else{
                    if (FontSize > (float)1)
                    {
                        FontSize -= 1f;
                        richTextBox1.Font = new Font(richTextBox1.Font.Name, FontSize, richTextBox1.Font.Style, richTextBox1.Font.Unit);
                    }
                    
                } 
                
           
        }
          
    
           
       
        
        private void dataTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += System.DateTime.Now.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "save";
            sf.Filter = "text document(*.txt)|.txt|all files (*.*)|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sf.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sf.FileName;
            }
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "open";
            op.Filter = "text document(*.txt)|.txt|all files (*.*)|*.*";
            if(op.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "save";
            sf.Filter = "text document(*.txt)|.txt|all files (*.*)|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sf.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sf.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) 
            {
                richTextBox1.SelectionColor = cd.Color;
            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void geceModuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        
           
        }

        private void geceModuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.Black;
        }

        private void gündüzModuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
        }

        private void cutKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ilk = textBox1.Text;
            string yeni = textBox2.Text;
            String metin = richTextBox1.Text.Replace(ilk, yeni);
            richTextBox1.Text=metin;
            
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("github.com/ferhatgok");
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 12, 10);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
