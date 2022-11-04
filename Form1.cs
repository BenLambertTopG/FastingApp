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
        string CustomTimeString; //User Timer Input
        decimal Gram;
        decimal GramDiv;
        decimal Goal;
        decimal Per;
        decimal CalTotal;


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
            lblExceeded.Hide();
        }

        //Calorie Calcultor
        private void btnGoal_Click(object sender, EventArgs e)
        {

            decimal Goal = decimal.Parse(txtTotalCal.Text); //Takes TextBox TotalCal and Converts it to Int Goal
            txtRemain.Text=Goal.ToString(); //Takes the Int Goal and Displays it in Text Box Remain

        }

        private void btnCal_Click(object sender, EventArgs e)
        {

          //Math for the Calorie Calculator

            //This works by taking the Total Daily Calories stated in the 'Remain' textbox when the set button it used.
            //Then converts the other textboxes 'per' and 'gram'
            //Dividing 'Gram' by 100 into 'GramDiv' so that 100g is not 1000g
            //'Goal' is again set from the 'Remain' textbox data
            //The Math then works out 'CalTotal' from: Goal - (Calories per gram * grams eaten)
            //The new total is then converted back into a string and displayed in the 'remain' textbox
            //Updating the remain textbox allows for further amount to be removed from the overall total.

        
            decimal Per = decimal.Parse(txtPer.Text); //Text Box Data Converted to Int Per
            decimal Gram = decimal.Parse(txtGram.Text); //Text Box Data Converted to Int Gram

            GramDiv = Gram / 100; //Divides Gram by 100 to make the Math work

            Goal = decimal.Parse(txtRemain.Text); //Converts Goal from String to Int

            decimal CalTotal = Goal - (Per * GramDiv); //The Math that removes total eaten calories from Goal calories
            txtRemain.Text=CalTotal.ToString(); //Displays New total in TextBox

            if (CalTotal<=1)
            {
                lblExceeded.Show();
            }
          
            
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


        
    

