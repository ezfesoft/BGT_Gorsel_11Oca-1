﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_Gorsel_11Oca_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int index1;
        int index2;







        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0 ;i<11;i++)
            {
                listBox1.Items.Add("Ogrenci"+i);
            }
        }








        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index1 = listBox1.SelectedIndex;
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            index2 = listBox2.SelectedIndex;
        }











        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Items[index1]);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(index2);
        }
    }
}
