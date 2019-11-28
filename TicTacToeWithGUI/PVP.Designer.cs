namespace TicTacToeWithGUI
{
    partial class PVP
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
            this._22 = new System.Windows.Forms.Button();
            this._00 = new System.Windows.Forms.Button();
            this._01 = new System.Windows.Forms.Button();
            this._02 = new System.Windows.Forms.Button();
            this._12 = new System.Windows.Forms.Button();
            this._11 = new System.Windows.Forms.Button();
            this._10 = new System.Windows.Forms.Button();
            this._20 = new System.Windows.Forms.Button();
            this._21 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.playerturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _22
            // 
            this._22.Location = new System.Drawing.Point(621, 314);
            this._22.Name = "_22";
            this._22.Size = new System.Drawing.Size(44, 42);
            this._22.TabIndex = 1;
            this._22.UseVisualStyleBackColor = true;
            // 
            // _00
            // 
            this._00.Location = new System.Drawing.Point(521, 217);
            this._00.Name = "_00";
            this._00.Size = new System.Drawing.Size(44, 42);
            this._00.TabIndex = 9;
            this._00.UseVisualStyleBackColor = true;
            this._00.Click += new System.EventHandler(this.Button9_Click);
            // 
            // _01
            // 
            this._01.Location = new System.Drawing.Point(571, 217);
            this._01.Name = "_01";
            this._01.Size = new System.Drawing.Size(44, 42);
            this._01.TabIndex = 10;
            this._01.UseVisualStyleBackColor = true;
            // 
            // _02
            // 
            this._02.Location = new System.Drawing.Point(621, 217);
            this._02.Name = "_02";
            this._02.Size = new System.Drawing.Size(44, 42);
            this._02.TabIndex = 11;
            this._02.UseVisualStyleBackColor = true;
            // 
            // _12
            // 
            this._12.Location = new System.Drawing.Point(621, 265);
            this._12.Name = "_12";
            this._12.Size = new System.Drawing.Size(44, 42);
            this._12.TabIndex = 12;
            this._12.UseVisualStyleBackColor = true;
            // 
            // _11
            // 
            this._11.Location = new System.Drawing.Point(571, 265);
            this._11.Name = "_11";
            this._11.Size = new System.Drawing.Size(44, 42);
            this._11.TabIndex = 13;
            this._11.UseVisualStyleBackColor = true;
            // 
            // _10
            // 
            this._10.Location = new System.Drawing.Point(521, 265);
            this._10.Name = "_10";
            this._10.Size = new System.Drawing.Size(44, 42);
            this._10.TabIndex = 14;
            this._10.UseVisualStyleBackColor = true;
            // 
            // _20
            // 
            this._20.Location = new System.Drawing.Point(521, 313);
            this._20.Name = "_20";
            this._20.Size = new System.Drawing.Size(44, 42);
            this._20.TabIndex = 15;
            this._20.UseVisualStyleBackColor = true;
            // 
            // _21
            // 
            this._21.Location = new System.Drawing.Point(571, 313);
            this._21.Name = "_21";
            this._21.Size = new System.Drawing.Size(44, 42);
            this._21.TabIndex = 16;
            this._21.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(492, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 179);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Player Turn:";
            // 
            // playerturn
            // 
            this.playerturn.AutoSize = true;
            this.playerturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.playerturn.Location = new System.Drawing.Point(492, 134);
            this.playerturn.Name = "playerturn";
            this.playerturn.Size = new System.Drawing.Size(40, 17);
            this.playerturn.TabIndex = 19;
            this.playerturn.Text = "____";
            // 
            // PVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 591);
            this.Controls.Add(this.playerturn);
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
            this.Name = "PVP";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _22;
        private System.Windows.Forms.Button _00;
        private System.Windows.Forms.Button _01;
        private System.Windows.Forms.Button _02;
        private System.Windows.Forms.Button _12;
        private System.Windows.Forms.Button _11;
        private System.Windows.Forms.Button _10;
        private System.Windows.Forms.Button _20;
        private System.Windows.Forms.Button _21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerturn;
    }
}