﻿namespace TicTacToeWithGUI
{
    partial class AIVAI
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._21 = new System.Windows.Forms.Button();
            this._20 = new System.Windows.Forms.Button();
            this._10 = new System.Windows.Forms.Button();
            this._11 = new System.Windows.Forms.Button();
            this._12 = new System.Windows.Forms.Button();
            this._02 = new System.Windows.Forms.Button();
            this._01 = new System.Windows.Forms.Button();
            this._00 = new System.Windows.Forms.Button();
            this._22 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.win = new System.Windows.Forms.Label();
            this.mainmenu = new System.Windows.Forms.Button();
            this.pt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(856, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next Turn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Player Turn:";
            // 
            // _21
            // 
            this._21.Location = new System.Drawing.Point(584, 311);
            this._21.Name = "_21";
            this._21.Size = new System.Drawing.Size(44, 42);
            this._21.TabIndex = 28;
            this._21.UseVisualStyleBackColor = true;
            // 
            // _20
            // 
            this._20.Location = new System.Drawing.Point(534, 311);
            this._20.Name = "_20";
            this._20.Size = new System.Drawing.Size(44, 42);
            this._20.TabIndex = 27;
            this._20.UseVisualStyleBackColor = true;
            // 
            // _10
            // 
            this._10.Location = new System.Drawing.Point(534, 263);
            this._10.Name = "_10";
            this._10.Size = new System.Drawing.Size(44, 42);
            this._10.TabIndex = 26;
            this._10.UseVisualStyleBackColor = true;
            // 
            // _11
            // 
            this._11.Location = new System.Drawing.Point(584, 263);
            this._11.Name = "_11";
            this._11.Size = new System.Drawing.Size(44, 42);
            this._11.TabIndex = 25;
            this._11.UseVisualStyleBackColor = true;
            // 
            // _12
            // 
            this._12.Location = new System.Drawing.Point(634, 263);
            this._12.Name = "_12";
            this._12.Size = new System.Drawing.Size(44, 42);
            this._12.TabIndex = 24;
            this._12.UseVisualStyleBackColor = true;
            // 
            // _02
            // 
            this._02.Location = new System.Drawing.Point(634, 215);
            this._02.Name = "_02";
            this._02.Size = new System.Drawing.Size(44, 42);
            this._02.TabIndex = 23;
            this._02.UseVisualStyleBackColor = true;
            // 
            // _01
            // 
            this._01.Location = new System.Drawing.Point(584, 215);
            this._01.Name = "_01";
            this._01.Size = new System.Drawing.Size(44, 42);
            this._01.TabIndex = 22;
            this._01.UseVisualStyleBackColor = true;
            // 
            // _00
            // 
            this._00.Location = new System.Drawing.Point(534, 215);
            this._00.Name = "_00";
            this._00.Size = new System.Drawing.Size(44, 42);
            this._00.TabIndex = 21;
            this._00.UseVisualStyleBackColor = true;
            this._00.Click += new System.EventHandler(this._00_Click);
            // 
            // _22
            // 
            this._22.Location = new System.Drawing.Point(634, 312);
            this._22.Name = "_22";
            this._22.Size = new System.Drawing.Size(44, 42);
            this._22.TabIndex = 20;
            this._22.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(505, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 179);
            this.panel1.TabIndex = 29;
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Location = new System.Drawing.Point(584, 132);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(12, 17);
            this.win.TabIndex = 32;
            this.win.Text = " ";
            this.win.Click += new System.EventHandler(this.Label2_Click);
            // 
            // mainmenu
            // 
            this.mainmenu.Location = new System.Drawing.Point(856, 473);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(120, 44);
            this.mainmenu.TabIndex = 33;
            this.mainmenu.Text = "Main Menu";
            this.mainmenu.UseVisualStyleBackColor = true;
            this.mainmenu.Visible = false;
            this.mainmenu.Click += new System.EventHandler(this.Mainmenu_Click);
            // 
            // pt
            // 
            this.pt.AutoSize = true;
            this.pt.Location = new System.Drawing.Point(502, 132);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(12, 17);
            this.pt.TabIndex = 34;
            this.pt.Text = " ";
            // 
            // AIVAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 596);
            this.Controls.Add(this.pt);
            this.Controls.Add(this.mainmenu);
            this.Controls.Add(this.win);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._21);
            this.Controls.Add(this._20);
            this.Controls.Add(this._10);
            this.Controls.Add(this._11);
            this.Controls.Add(this._12);
            this.Controls.Add(this._02);
            this.Controls.Add(this._01);
            this.Controls.Add(this._00);
            this.Controls.Add(this._22);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "AIVAI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AIVAI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _21;
        private System.Windows.Forms.Button _20;
        private System.Windows.Forms.Button _10;
        private System.Windows.Forms.Button _11;
        private System.Windows.Forms.Button _12;
        private System.Windows.Forms.Button _02;
        private System.Windows.Forms.Button _01;
        private System.Windows.Forms.Button _00;
        private System.Windows.Forms.Button _22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Button mainmenu;
        private System.Windows.Forms.Label pt;
    }
}