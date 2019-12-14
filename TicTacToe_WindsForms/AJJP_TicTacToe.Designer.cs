﻿namespace TicTacToe_WindsForms
{
    partial class AJJP_TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AJJP_TicTacToe));
            this.Board = new System.Windows.Forms.TableLayoutPanel();
            this.C3_btn = new System.Windows.Forms.Button();
            this.C2_btn = new System.Windows.Forms.Button();
            this.C1_btn = new System.Windows.Forms.Button();
            this.B3_btn = new System.Windows.Forms.Button();
            this.B2_btn = new System.Windows.Forms.Button();
            this.B1_btn = new System.Windows.Forms.Button();
            this.A3_btn = new System.Windows.Forms.Button();
            this.A2_btn = new System.Windows.Forms.Button();
            this.A1_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIVsAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnText = new System.Windows.Forms.Label();
            this.Restart_btn = new System.Windows.Forms.Button();
            this.Continue_btn = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.Mode3 = new System.Windows.Forms.Button();
            this.Mode2 = new System.Windows.Forms.Button();
            this.Mode1 = new System.Windows.Forms.Button();
            this.Board.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Board
            // 
            resources.ApplyResources(this.Board, "Board");
            this.Board.Controls.Add(this.C3_btn, 2, 2);
            this.Board.Controls.Add(this.C2_btn, 1, 2);
            this.Board.Controls.Add(this.C1_btn, 0, 2);
            this.Board.Controls.Add(this.B3_btn, 2, 1);
            this.Board.Controls.Add(this.B2_btn, 1, 1);
            this.Board.Controls.Add(this.B1_btn, 0, 1);
            this.Board.Controls.Add(this.A3_btn, 2, 0);
            this.Board.Controls.Add(this.A2_btn, 1, 0);
            this.Board.Controls.Add(this.A1_btn, 0, 0);
            this.Board.Name = "Board";
            // 
            // C3_btn
            // 
            resources.ApplyResources(this.C3_btn, "C3_btn");
            this.C3_btn.Name = "C3_btn";
            this.C3_btn.UseVisualStyleBackColor = true;
            this.C3_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // C2_btn
            // 
            resources.ApplyResources(this.C2_btn, "C2_btn");
            this.C2_btn.Name = "C2_btn";
            this.C2_btn.UseVisualStyleBackColor = true;
            this.C2_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // C1_btn
            // 
            resources.ApplyResources(this.C1_btn, "C1_btn");
            this.C1_btn.Name = "C1_btn";
            this.C1_btn.UseVisualStyleBackColor = true;
            this.C1_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // B3_btn
            // 
            resources.ApplyResources(this.B3_btn, "B3_btn");
            this.B3_btn.Name = "B3_btn";
            this.B3_btn.UseVisualStyleBackColor = true;
            this.B3_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // B2_btn
            // 
            resources.ApplyResources(this.B2_btn, "B2_btn");
            this.B2_btn.Name = "B2_btn";
            this.B2_btn.UseVisualStyleBackColor = true;
            this.B2_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // B1_btn
            // 
            resources.ApplyResources(this.B1_btn, "B1_btn");
            this.B1_btn.Name = "B1_btn";
            this.B1_btn.UseVisualStyleBackColor = true;
            this.B1_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // A3_btn
            // 
            resources.ApplyResources(this.A3_btn, "A3_btn");
            this.A3_btn.Name = "A3_btn";
            this.A3_btn.UseVisualStyleBackColor = true;
            this.A3_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // A2_btn
            // 
            resources.ApplyResources(this.A2_btn, "A2_btn");
            this.A2_btn.Name = "A2_btn";
            this.A2_btn.UseVisualStyleBackColor = true;
            this.A2_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // A1_btn
            // 
            resources.ApplyResources(this.A1_btn, "A1_btn");
            this.A1_btn.Name = "A1_btn";
            this.A1_btn.UseVisualStyleBackColor = true;
            this.A1_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.Mode});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.playerVsAIToolStripMenuItem,
            this.aIVsAIToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            resources.ApplyResources(this.newGameToolStripMenuItem, "newGameToolStripMenuItem");
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            resources.ApplyResources(this.playerVsPlayerToolStripMenuItem, "playerVsPlayerToolStripMenuItem");
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.playerVsPlayerToolStripMenuItem_Click);
            // 
            // playerVsAIToolStripMenuItem
            // 
            this.playerVsAIToolStripMenuItem.Name = "playerVsAIToolStripMenuItem";
            resources.ApplyResources(this.playerVsAIToolStripMenuItem, "playerVsAIToolStripMenuItem");
            this.playerVsAIToolStripMenuItem.Click += new System.EventHandler(this.playerVsAIToolStripMenuItem_Click);
            // 
            // aIVsAIToolStripMenuItem
            // 
            this.aIVsAIToolStripMenuItem.Name = "aIVsAIToolStripMenuItem";
            resources.ApplyResources(this.aIVsAIToolStripMenuItem, "aIVsAIToolStripMenuItem");
            this.aIVsAIToolStripMenuItem.Click += new System.EventHandler(this.AIVsAIToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // TurnText
            // 
            resources.ApplyResources(this.TurnText, "TurnText");
            this.TurnText.Name = "TurnText";
            // 
            // Restart_btn
            // 
            resources.ApplyResources(this.Restart_btn, "Restart_btn");
            this.Restart_btn.Name = "Restart_btn";
            this.Restart_btn.UseVisualStyleBackColor = true;
            this.Restart_btn.Click += new System.EventHandler(this.Restart_btn_Click);
            // 
            // Continue_btn
            // 
            resources.ApplyResources(this.Continue_btn, "Continue_btn");
            this.Continue_btn.Name = "Continue_btn";
            this.Continue_btn.UseVisualStyleBackColor = true;
            this.Continue_btn.Click += new System.EventHandler(this.Continue_btn_Click);
            // 
            // Mode
            // 
            this.Mode.Name = "Mode";
            resources.ApplyResources(this.Mode, "Mode");
            // 
            // Mode3
            // 
            resources.ApplyResources(this.Mode3, "Mode3");
            this.Mode3.Name = "Mode3";
            this.Mode3.UseVisualStyleBackColor = true;
            this.Mode3.Click += new System.EventHandler(this.Mode3_Click);
            // 
            // Mode2
            // 
            resources.ApplyResources(this.Mode2, "Mode2");
            this.Mode2.Name = "Mode2";
            this.Mode2.UseVisualStyleBackColor = true;
            this.Mode2.Click += new System.EventHandler(this.Mode2_Click);
            // 
            // Mode1
            // 
            resources.ApplyResources(this.Mode1, "Mode1");
            this.Mode1.Name = "Mode1";
            this.Mode1.UseVisualStyleBackColor = true;
            this.Mode1.Click += new System.EventHandler(this.Mode1_Click);
            // 
            // AJJP_TicTacToe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Mode1);
            this.Controls.Add(this.Mode2);
            this.Controls.Add(this.Mode3);
            this.Controls.Add(this.Continue_btn);
            this.Controls.Add(this.Restart_btn);
            this.Controls.Add(this.TurnText);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AJJP_TicTacToe";
            this.Load += new System.EventHandler(this.AJJP_TicTacToe_Load);
            this.Board.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Board;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Button C3_btn;
        private System.Windows.Forms.Button C2_btn;
        private System.Windows.Forms.Button C1_btn;
        private System.Windows.Forms.Button B3_btn;
        private System.Windows.Forms.Button B2_btn;
        private System.Windows.Forms.Button B1_btn;
        private System.Windows.Forms.Button A3_btn;
        private System.Windows.Forms.Button A2_btn;
        private System.Windows.Forms.Button A1_btn;
        private System.Windows.Forms.Label TurnText;
        private System.Windows.Forms.Button Restart_btn;
        private System.Windows.Forms.Button Continue_btn;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIVsAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mode;
        private System.Windows.Forms.Button Mode3;
        private System.Windows.Forms.Button Mode2;
        private System.Windows.Forms.Button Mode1;
    }
}