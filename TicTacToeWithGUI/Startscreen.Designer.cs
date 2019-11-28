namespace TicTacToeWithGUI
{
    partial class Startscreen
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
            this.PVP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PVP
            // 
            this.PVP.Location = new System.Drawing.Point(503, 105);
            this.PVP.Name = "PVP";
            this.PVP.Size = new System.Drawing.Size(219, 63);
            this.PVP.TabIndex = 0;
            this.PVP.Text = "PLAYER VS PLAYER";
            this.PVP.UseVisualStyleBackColor = true;
            this.PVP.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "PLAYER VS AI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "AI VS AI";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 555);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PVP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PVP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

