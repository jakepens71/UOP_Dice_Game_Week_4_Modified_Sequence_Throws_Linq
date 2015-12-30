namespace DiceGameUOPWeek1
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.lstRollResult = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRollDice.Location = new System.Drawing.Point(230, 362);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 23);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // picDice1
            // 
            this.picDice1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDice1.Location = new System.Drawing.Point(65, 80);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(146, 132);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 1;
            this.picDice1.TabStop = false;
            this.picDice1.WaitOnLoad = true;
            // 
            // picDice2
            // 
            this.picDice2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDice2.Location = new System.Drawing.Point(317, 80);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(149, 132);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 2;
            this.picDice2.TabStop = false;
            // 
            // lstRollResult
            // 
            this.lstRollResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstRollResult.FormattingEnabled = true;
            this.lstRollResult.Location = new System.Drawing.Point(147, 246);
            this.lstRollResult.Name = "lstRollResult";
            this.lstRollResult.Size = new System.Drawing.Size(263, 95);
            this.lstRollResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 461);
            this.Controls.Add(this.lstRollResult);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Form1";
            this.Text = "Dice Game";
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.ListBox lstRollResult;
    }
}

