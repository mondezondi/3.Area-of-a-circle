﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Area_of_a_circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Area, radius;
            if (double.TryParse(textBox1.Text, out radius))
            {
                Area = Math.PI * Math.Pow(radius, 2);

                textBox2.Text = Area.ToString("f2");
            }
            else
            {
                MessageBox.Show("Please enter a valid number for radius.", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
