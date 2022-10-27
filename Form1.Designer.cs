namespace FastingApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.lblHours = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSecs = new System.Windows.Forms.Label();
            this.lblFeed = new System.Windows.Forms.Label();
            this.txtTotalCal = new System.Windows.Forms.TextBox();
            this.txtPer = new System.Windows.Forms.TextBox();
            this.txtGram = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnResetCal = new System.Windows.Forms.Button();
            this.btnGoal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(358, 907);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(180, 20);
            label3.TabIndex = 21;
            label3.Text = "Total Calories For Today";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(404, 973);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 20);
            label4.TabIndex = 22;
            label4.Text = "Calories Per 100g";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(431, 1009);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(104, 20);
            label5.TabIndex = 23;
            label5.Text = "Grams Eaten";
            // 
            // lblHours
            // 
            this.lblHours.AutoEllipsis = true;
            this.lblHours.Font = new System.Drawing.Font("Wigners Friend", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(13, 99);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(1266, 175);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "00";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(435, 556);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(258, 26);
            this.txtTime.TabIndex = 4;
            this.txtTime.Text = "1";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(435, 593);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 35);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(582, 593);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 35);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(734, 593);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(734, 553);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(112, 35);
            this.btnSet.TabIndex = 8;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoEllipsis = true;
            this.lblMin.Font = new System.Drawing.Font("Wigners Friend", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(13, 228);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(1266, 175);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "00";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecs
            // 
            this.lblSecs.AutoEllipsis = true;
            this.lblSecs.Font = new System.Drawing.Font("Wigners Friend", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecs.Location = new System.Drawing.Point(13, 358);
            this.lblSecs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecs.Name = "lblSecs";
            this.lblSecs.Size = new System.Drawing.Size(1266, 175);
            this.lblSecs.TabIndex = 10;
            this.lblSecs.Text = "00";
            this.lblSecs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFeed
            // 
            this.lblFeed.AutoEllipsis = true;
            this.lblFeed.Font = new System.Drawing.Font("Wigners Friend", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeed.Location = new System.Drawing.Point(13, 127);
            this.lblFeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeed.Name = "lblFeed";
            this.lblFeed.Size = new System.Drawing.Size(1266, 394);
            this.lblFeed.TabIndex = 11;
            this.lblFeed.Text = "Fast is OVER";
            this.lblFeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalCal
            // 
            this.txtTotalCal.Location = new System.Drawing.Point(545, 904);
            this.txtTotalCal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalCal.Name = "txtTotalCal";
            this.txtTotalCal.Size = new System.Drawing.Size(258, 26);
            this.txtTotalCal.TabIndex = 12;
            this.txtTotalCal.Text = "1600";
            this.txtTotalCal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPer
            // 
            this.txtPer.Location = new System.Drawing.Point(545, 967);
            this.txtPer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(258, 26);
            this.txtPer.TabIndex = 13;
            this.txtPer.Text = "100";
            this.txtPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGram
            // 
            this.txtGram.Location = new System.Drawing.Point(545, 1003);
            this.txtGram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGram.Name = "txtGram";
            this.txtGram.Size = new System.Drawing.Size(258, 26);
            this.txtGram.TabIndex = 14;
            this.txtGram.Text = "100";
            this.txtGram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(851, 995);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(162, 34);
            this.btnCal.TabIndex = 15;
            this.btnCal.Text = "Add Food";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnResetCal
            // 
            this.btnResetCal.Location = new System.Drawing.Point(851, 1048);
            this.btnResetCal.Name = "btnResetCal";
            this.btnResetCal.Size = new System.Drawing.Size(162, 34);
            this.btnResetCal.TabIndex = 16;
            this.btnResetCal.Text = "Reset Calories";
            this.btnResetCal.UseVisualStyleBackColor = true;
            // 
            // btnGoal
            // 
            this.btnGoal.Location = new System.Drawing.Point(851, 896);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Size = new System.Drawing.Size(162, 34);
            this.btnGoal.TabIndex = 18;
            this.btnGoal.Text = "Set Goal";
            this.btnGoal.UseVisualStyleBackColor = true;
            this.btnGoal.Click += new System.EventHandler(this.btnGoal_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Wigners Friend", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1266, 57);
            this.label1.TabIndex = 19;
            this.label1.Text = "FASTING TIMER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Wigners Friend", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 790);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1266, 57);
            this.label2.TabIndex = 20;
            this.label2.Text = "CALORIE CALCULATOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(344, 1135);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(51, 20);
            this.lbltest.TabIndex = 24;
            this.lbltest.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 1323);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoal);
            this.Controls.Add(this.btnResetCal);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtGram);
            this.Controls.Add(this.txtPer);
            this.Controls.Add(this.txtTotalCal);
            this.Controls.Add(this.lblFeed);
            this.Controls.Add(this.lblSecs);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblHours);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSecs;
        private System.Windows.Forms.Label lblFeed;
        private System.Windows.Forms.TextBox txtTotalCal;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.TextBox txtGram;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnResetCal;
        private System.Windows.Forms.Button btnGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltest;
    }
}

