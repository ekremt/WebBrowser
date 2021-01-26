using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ekrem_form1_WepBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("comboBox2.Text");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Navigate("www.yandex.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Navigate("www.facebook.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Navigate("www.yahoo.com");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Navigate("www.twiter.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(2, 1, 50, 38);
            pictureBox1.Region = new Region(g);
           

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("textBox1.Text");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("textBox1.Text");
            comboBox2.Items.Add(" textBox1.Text");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 500;
            
            
}

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tınToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geçmişToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
