namespace TicTacToe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1_btn = new System.Windows.Forms.Button();
            this.A2_btn = new System.Windows.Forms.Button();
            this.A3_btn = new System.Windows.Forms.Button();
            this.B1_btn = new System.Windows.Forms.Button();
            this.B2_btn = new System.Windows.Forms.Button();
            this.B3_btn = new System.Windows.Forms.Button();
            this.C1_btn = new System.Windows.Forms.Button();
            this.C2_btn = new System.Windows.Forms.Button();
            this.C3_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.C3_btn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.C2_btn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.C1_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B3_btn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.B2_btn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.B1_btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.A3_btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.A2_btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.A1_btn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aBoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aBoutToolStripMenuItem
            // 
            this.aBoutToolStripMenuItem.Name = "aBoutToolStripMenuItem";
            this.aBoutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aBoutToolStripMenuItem.Text = "About";
            this.aBoutToolStripMenuItem.Click += new System.EventHandler(this.aBoutToolStripMenuItem_Click);
            // 
            // A1_btn
            // 
            this.A1_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A1_btn.Location = new System.Drawing.Point(3, 3);
            this.A1_btn.Name = "A1_btn";
            this.A1_btn.Size = new System.Drawing.Size(191, 155);
            this.A1_btn.TabIndex = 0;
            this.A1_btn.UseVisualStyleBackColor = true;
            this.A1_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // A2_btn
            // 
            this.A2_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A2_btn.Location = new System.Drawing.Point(200, 3);
            this.A2_btn.Name = "A2_btn";
            this.A2_btn.Size = new System.Drawing.Size(191, 155);
            this.A2_btn.TabIndex = 1;
            this.A2_btn.UseVisualStyleBackColor = true;
            // 
            // A3_btn
            // 
            this.A3_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A3_btn.Location = new System.Drawing.Point(397, 3);
            this.A3_btn.Name = "A3_btn";
            this.A3_btn.Size = new System.Drawing.Size(193, 155);
            this.A3_btn.TabIndex = 2;
            this.A3_btn.UseVisualStyleBackColor = true;
            // 
            // B1_btn
            // 
            this.B1_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B1_btn.Location = new System.Drawing.Point(3, 164);
            this.B1_btn.Name = "B1_btn";
            this.B1_btn.Size = new System.Drawing.Size(191, 155);
            this.B1_btn.TabIndex = 3;
            this.B1_btn.UseVisualStyleBackColor = true;
            // 
            // B2_btn
            // 
            this.B2_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B2_btn.Location = new System.Drawing.Point(200, 164);
            this.B2_btn.Name = "B2_btn";
            this.B2_btn.Size = new System.Drawing.Size(191, 155);
            this.B2_btn.TabIndex = 4;
            this.B2_btn.UseVisualStyleBackColor = true;
            // 
            // B3_btn
            // 
            this.B3_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B3_btn.Location = new System.Drawing.Point(397, 164);
            this.B3_btn.Name = "B3_btn";
            this.B3_btn.Size = new System.Drawing.Size(193, 155);
            this.B3_btn.TabIndex = 5;
            this.B3_btn.UseVisualStyleBackColor = true;
            // 
            // C1_btn
            // 
            this.C1_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C1_btn.Location = new System.Drawing.Point(3, 325);
            this.C1_btn.Name = "C1_btn";
            this.C1_btn.Size = new System.Drawing.Size(191, 156);
            this.C1_btn.TabIndex = 6;
            this.C1_btn.UseVisualStyleBackColor = true;
            // 
            // C2_btn
            // 
            this.C2_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C2_btn.Location = new System.Drawing.Point(200, 325);
            this.C2_btn.Name = "C2_btn";
            this.C2_btn.Size = new System.Drawing.Size(191, 156);
            this.C2_btn.TabIndex = 7;
            this.C2_btn.UseVisualStyleBackColor = true;
            // 
            // C3_btn
            // 
            this.C3_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C3_btn.Location = new System.Drawing.Point(397, 325);
            this.C3_btn.Name = "C3_btn";
            this.C3_btn.Size = new System.Drawing.Size(193, 156);
            this.C3_btn.TabIndex = 8;
            this.C3_btn.UseVisualStyleBackColor = true;
            // 
            // AJJP_TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 523);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AJJP_TicTacToe";
            this.Text = "AJJP_TicTacToe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBoutToolStripMenuItem;
        private System.Windows.Forms.Button C3_btn;
        private System.Windows.Forms.Button C2_btn;
        private System.Windows.Forms.Button C1_btn;
        private System.Windows.Forms.Button B3_btn;
        private System.Windows.Forms.Button B2_btn;
        private System.Windows.Forms.Button B1_btn;
        private System.Windows.Forms.Button A3_btn;
        private System.Windows.Forms.Button A2_btn;
        private System.Windows.Forms.Button A1_btn;
    }
}