using System;
using System.Windows.Forms;

namespace FarmApp.View
{
    partial class MainFrm
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
            this.btnAddCow = new System.Windows.Forms.Button();
            this.btnAddSheep = new System.Windows.Forms.Button();
            this.btnAddGoat = new System.Windows.Forms.Button();
            this.btnSimulateDay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCowCount = new System.Windows.Forms.Label();
            this.lblSheepCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGoatCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowSounds = new System.Windows.Forms.Button();
            this.lblTotalMilk = new System.Windows.Forms.Label();
            this.btnShowTotalMilk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCow
            // 
            this.btnAddCow.Location = new System.Drawing.Point(37, 49);
            this.btnAddCow.Name = "btnAddCow";
            this.btnAddCow.Size = new System.Drawing.Size(98, 33);
            this.btnAddCow.TabIndex = 0;
            this.btnAddCow.Text = "Add Cow";
            this.btnAddCow.UseVisualStyleBackColor = true;
            this.btnAddCow.Click += new System.EventHandler(this.btnAddCow_Click);
            // 
            // btnAddSheep
            // 
            this.btnAddSheep.Location = new System.Drawing.Point(37, 100);
            this.btnAddSheep.Name = "btnAddSheep";
            this.btnAddSheep.Size = new System.Drawing.Size(98, 33);
            this.btnAddSheep.TabIndex = 1;
            this.btnAddSheep.Text = "Add Sheep";
            this.btnAddSheep.UseVisualStyleBackColor = true;
            this.btnAddSheep.Click += new System.EventHandler(this.btnAddSheep_Click);
            // 
            // btnAddGoat
            // 
            this.btnAddGoat.Location = new System.Drawing.Point(37, 151);
            this.btnAddGoat.Name = "btnAddGoat";
            this.btnAddGoat.Size = new System.Drawing.Size(98, 33);
            this.btnAddGoat.TabIndex = 2;
            this.btnAddGoat.Text = "Add Goat";
            this.btnAddGoat.UseVisualStyleBackColor = true;
            this.btnAddGoat.Click += new System.EventHandler(this.btnAddGoat_Click);
            // 
            // btnSimulateDay
            // 
            this.btnSimulateDay.Location = new System.Drawing.Point(37, 209);
            this.btnSimulateDay.Name = "btnSimulateDay";
            this.btnSimulateDay.Size = new System.Drawing.Size(98, 33);
            this.btnSimulateDay.TabIndex = 3;
            this.btnSimulateDay.Text = "Simulate Day";
            this.btnSimulateDay.UseVisualStyleBackColor = true;
            this.btnSimulateDay.Click += new System.EventHandler(this.btnSimulateDay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cows: ";
            // 
            // lblCowCount
            // 
            this.lblCowCount.AutoSize = true;
            this.lblCowCount.Location = new System.Drawing.Point(262, 59);
            this.lblCowCount.Name = "lblCowCount";
            this.lblCowCount.Size = new System.Drawing.Size(13, 13);
            this.lblCowCount.TabIndex = 5;
            this.lblCowCount.Text = "0";
            // 
            // lblSheepCount
            // 
            this.lblSheepCount.AutoSize = true;
            this.lblSheepCount.Location = new System.Drawing.Point(262, 109);
            this.lblSheepCount.Name = "lblSheepCount";
            this.lblSheepCount.Size = new System.Drawing.Size(13, 13);
            this.lblSheepCount.TabIndex = 7;
            this.lblSheepCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sheep:";
            // 
            // lblGoatCount
            // 
            this.lblGoatCount.AutoSize = true;
            this.lblGoatCount.Location = new System.Drawing.Point(262, 160);
            this.lblGoatCount.Name = "lblGoatCount";
            this.lblGoatCount.Size = new System.Drawing.Size(13, 13);
            this.lblGoatCount.TabIndex = 9;
            this.lblGoatCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Goats:";
            // 
            // btnShowSounds
            // 
            this.btnShowSounds.Location = new System.Drawing.Point(37, 267);
            this.btnShowSounds.Name = "btnShowSounds";
            this.btnShowSounds.Size = new System.Drawing.Size(98, 32);
            this.btnShowSounds.TabIndex = 10;
            this.btnShowSounds.Text = "Hear Sounds";
            this.btnShowSounds.UseVisualStyleBackColor = true;
            this.btnShowSounds.Click += new System.EventHandler(this.btnShowSounds_Click);
            //
            // lblTotalMilk
            // 
            this.lblTotalMilk.AutoSize = true;
            this.lblTotalMilk.Location = new System.Drawing.Point(218, 212);
            this.lblTotalMilk.Name = "lblTotalMilk";
            this.lblTotalMilk.Size = new System.Drawing.Size(89, 13);
            this.lblTotalMilk.TabIndex = 11;
            this.lblTotalMilk.Text = "Total Milk: 0 liters";
            // 
            // btnShowTotalMilk
            // 
            this.btnShowTotalMilk.Location = new System.Drawing.Point(37, 304);
            this.btnShowTotalMilk.Name = "btnShowTotalMilk";
            this.btnShowTotalMilk.Size = new System.Drawing.Size(98, 33);
            this.btnShowTotalMilk.TabIndex = 12;
            this.btnShowTotalMilk.Text = "Show Total Milk";
            this.btnShowTotalMilk.UseVisualStyleBackColor = true;
            this.btnShowTotalMilk.Click += new System.EventHandler(this.btnShowTotalMilk_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 370);
            this.Controls.Add(this.btnShowSounds);
            this.Controls.Add(this.lblGoatCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSheepCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCowCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimulateDay);
            this.Controls.Add(this.btnAddGoat);
            this.Controls.Add(this.btnAddSheep);
            this.Controls.Add(this.btnAddCow);
            this.Controls.Add(this.btnShowTotalMilk);
            this.Controls.Add(this.lblTotalMilk);
            this.Name = "MainFrm";
            this.Text = "Farm App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCow;
        private System.Windows.Forms.Button btnAddSheep;
        private System.Windows.Forms.Button btnAddGoat;
        private System.Windows.Forms.Button btnSimulateDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCowCount;
        private System.Windows.Forms.Label lblSheepCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGoatCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowSounds;
        private System.Windows.Forms.Label lblTotalMilk;
        private System.Windows.Forms.Button btnShowTotalMilk;
    }
}