﻿namespace wordBingo
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.characterSelection = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = " Welcome to the guess the friend bonus game!\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(867, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spongebob wants to go jellyfishing today and would like a friend to join,\r\nCorrec" +
    "tly guess which friend will join him to recieve +10x multiplier win";
            // 
            // characterSelection
            // 
            this.characterSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterSelection.FormattingEnabled = true;
            this.characterSelection.Items.AddRange(new object[] {
            "Patrick",
            "Squidward",
            "Mr Krabs",
            "Sandy",
            "Gary",
            "Plankton"});
            this.characterSelection.Location = new System.Drawing.Point(571, 183);
            this.characterSelection.Name = "characterSelection";
            this.characterSelection.Size = new System.Drawing.Size(168, 39);
            this.characterSelection.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit Guess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.Color.DeepPink;
            this.Photo.Location = new System.Drawing.Point(619, 254);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(221, 211);
            this.Photo.TabIndex = 4;
            this.Photo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.characterSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form2";
            this.Text = "Guess the friend bonus game!";
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox characterSelection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Photo;
    }
}