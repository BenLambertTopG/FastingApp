using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int CustomTime; // Stored User Input
        int Count;
        int Hour, Min, Sec;
        int Goal, Per, Gram, GramDiv, CalTotal;
        string CustomTimeString; //User Timer Input

        private void timer(object sender, EventArgs e)
        {


         Hour = CustomTime / 3600;
         Min = CustomTime / 60;
         Sec = CustomTime;

         lblHours.Text = Hour + " Hours";
         lblMin.Text = Min + " Total Minutes";
         lblSecs.Text = Sec + " Total Seconds";



            CustomTime = CustomTime - 1;

            if (CustomTime < 1)
                {
                lblFeed.Show();
            }

        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            int Goal = int.Parse(txtTotalCal.Text);
            lbltest.Text=Goal.ToString();

        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            // Takes the user Timer input and converts to int
            CustomTimeString = txtTime.Text;
            int Count = int.Parse(CustomTimeString);

            // Converts user input to hours

            CustomTime = (Count * 3600);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblFeed.Hide();
            timer1.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblFeed.Hide();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
        
          int Per = int.Parse(txtPer.Text);
          int Gram = int.Parse(txtGram.Text);

            GramDiv = Gram / 100;

            CalTotal = Goal - (Per * GramDiv);
            lbltest.Text = CalTotal+" Remaining"; //why is this ending up at -100 everytime?
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            // Same as Set button but uses user input to change data
            CustomTimeString = txtTime.Text;
            int Count = int.Parse(CustomTimeString);
            CustomTime = Count * 3600;
            timer1.Start();
        }

}

        }


        
    

