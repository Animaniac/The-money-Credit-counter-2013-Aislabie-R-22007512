using System;
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
        public Form1()
        {
            InitializeComponent();
                    }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            OnePLabel.Text = onepcount.ToString();
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
            OnePLabel.Text = onepcount.ToString();
            TwoPLabel.Text = twopcount.ToString();
        }

        private void CoinsEnteredbox_Enter(object sender, EventArgs e)
        {

        }

        private void TwoPbtn_Click(object sender, EventArgs e)
        {
            twopcount++;
            TwoPLabel.Text = twopcount.ToString();
        }
        
    }
}
