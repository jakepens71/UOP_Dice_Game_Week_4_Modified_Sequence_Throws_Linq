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
            this.lstSequence1 = new System.Windows.Forms.ListBox();
            this.lstSequence2 = new System.Windows.Forms.ListBox();
            this.lstNotInSequence2 = new System.Windows.Forms.ListBox();
            this.lstNotInSequence1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRollDice.Location = new System.Drawing.Point(225, 372);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 23);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lstSequence1
            // 
            this.lstSequence1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSequence1.FormattingEnabled = true;
            this.lstSequence1.Location = new System.Drawing.Point(12, 55);
            this.lstSequence1.Name = "lstSequence1";
            this.lstSequence1.Size = new System.Drawing.Size(252, 95);
            this.lstSequence1.TabIndex = 3;
            // 
            // lstSequence2
            // 
            this.lstSequence2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSequence2.FormattingEnabled = true;
            this.lstSequence2.Location = new System.Drawing.Point(294, 55);
            this.lstSequence2.Name = "lstSequence2";
            this.lstSequence2.Size = new System.Drawing.Size(252, 95);
            this.lstSequence2.TabIndex = 4;
            // 
            // lstNotInSequence2
            // 
            this.lstNotInSequence2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstNotInSequence2.FormattingEnabled = true;
            this.lstNotInSequence2.Location = new System.Drawing.Point(12, 201);
            this.lstNotInSequence2.Name = "lstNotInSequence2";
            this.lstNotInSequence2.Size = new System.Drawing.Size(252, 95);
            this.lstNotInSequence2.TabIndex = 5;
            // 
            // lstNotInSequence1
            // 
            this.lstNotInSequence1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstNotInSequence1.FormattingEnabled = true;
            this.lstNotInSequence1.Location = new System.Drawing.Point(294, 201);
            this.lstNotInSequence1.Name = "lstNotInSequence1";
            this.lstNotInSequence1.Size = new System.Drawing.Size(252, 95);
            this.lstNotInSequence1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sequence 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sequence 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Only In Sequence 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Only In Sequence 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNotInSequence1);
            this.Controls.Add(this.lstNotInSequence2);
            this.Controls.Add(this.lstSequence2);
            this.Controls.Add(this.lstSequence1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.ListBox lstSequence1;
        private System.Windows.Forms.ListBox lstSequence2;
        private System.Windows.Forms.ListBox lstNotInSequence2;
        private System.Windows.Forms.ListBox lstNotInSequence1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

