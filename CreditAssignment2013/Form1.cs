﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;

namespace CreditAssignment2013
{
    public partial class Form1 : Form
    {
        int onepcount = 0;
        int twopcount = 0;
        int fivepcount = 0;
        int tenpcount = 0;
        int twentypcount = 0;
        int fiftypcount = 0;
        int poundcount = 0;
        int twopoundcount = 0;
        public Form1()
        {
            InitializeComponent();
                    }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            OnePLabel.Text = onepcount.ToString();
            TwoPLabel.Text = twopcount.ToString();
            FivePlbl.Text = fivepcount.ToString();
            TenPlbl.Text = tenpcount.ToString();
            TwentyPbtn.Text = twentypcount.ToString();
            FiftyPbtn.Text = fiftypcount.ToString();
            Poundbtn.Text = poundcount.ToString();
            TwoPbtn.Text = twopcount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            onepcount++;
            OnePLabel.Text = onepcount.ToString();
  
            }

        private void label1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            onepcount = 0;
            twopcount = 0;
            fivepcount = 0;
            tenpcount = 0;
            twentypcount = 0;
            fiftypcount = 0;
            poundcount = 0;
            twopoundcount = 0;
            OnePLabel.Text = onepcount.ToString();
            TwoPLabel.Text = twopcount.ToString();
            FivePlbl.Text = fivepcount.ToString();
            TenPlbl.Text = tenpcount.ToString();
        }

        private void CoinsEnteredbox_Enter(object sender, EventArgs e)
        {

        }

        private void TwoPbtn_Click(object sender, EventArgs e)
        {
            if (Credittxt.Text == string.Empty)
            {
                MessageBox.Show("You need to enter the cost of a credit");
            }
            else
            twopcount++;
            TwoPLabel.Text = twopcount.ToString();
        }

        private void FivePbtn_Click(object sender, EventArgs e)
        {
            fivepcount++;
            FivePlbl.Text = fivepcount.ToString();
        }

        private void Credditcosttxt(object sender, EventArgs e)
        {
            
        }

        private void label21_Click(object sender, EventArgs e)
        {
            
            label21.Text = OnePLabel.Text;

           
            
        }

        private void TenPbtn_Click(object sender, EventArgs e)
        {
            tenpcount++;
            TenPlbl.Text = tenpcount.ToString();
        }

        private void Credittxt_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
