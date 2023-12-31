﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_login_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void undToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            DialogResult result= fontDialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }


        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDialog = new ColorDialog();
            DialogResult result = ColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionColor = ColorDialog.Color;
            }

        }
    }
}
