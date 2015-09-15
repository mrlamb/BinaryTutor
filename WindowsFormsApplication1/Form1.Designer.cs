namespace BinaryTutorial
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.practiceModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getNewRandomNumber = new System.Windows.Forms.Button();
            this.submitAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.binaryTutorialButton128 = new BinaryTutorial.BinaryTutorialButton();
            this.binaryTutorialButton1 = new BinaryTutorial.BinaryTutorialButton();
            this.binaryTutorialButton2 = new BinaryTutorial.BinaryTutorialButton();
            this.binaryTutorialButton4 = new BinaryTutorial.BinaryTutorialButton();
            this.binaryTutorialButton8 = new BinaryTutorial.BinaryTutorialButton();
            this.binaryTutorialButton16 = new BinaryTutorial.BinaryTutorialButton();
            this.binaryTutorialButton32 = new BinaryTutorial.BinaryTutorialButton();
            this.binaryTutorialButton64 = new BinaryTutorial.BinaryTutorialButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 43);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(40, 20);
            this.resultBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practiceModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // practiceModeToolStripMenuItem
            // 
            this.practiceModeToolStripMenuItem.Name = "practiceModeToolStripMenuItem";
            this.practiceModeToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.practiceModeToolStripMenuItem.Text = "Practice Mode";
            this.practiceModeToolStripMenuItem.Click += new System.EventHandler(this.practiceModeToolStripMenuItem_Click);
            // 
            // getNewRandomNumber
            // 
            this.getNewRandomNumber.Location = new System.Drawing.Point(298, 28);
            this.getNewRandomNumber.Name = "getNewRandomNumber";
            this.getNewRandomNumber.Size = new System.Drawing.Size(75, 23);
            this.getNewRandomNumber.TabIndex = 11;
            this.getNewRandomNumber.Text = "New";
            this.getNewRandomNumber.UseVisualStyleBackColor = true;
            this.getNewRandomNumber.Visible = false;
            this.getNewRandomNumber.Click += new System.EventHandler(this.getNewRandomNumber_Click);
            // 
            // submitAnswer
            // 
            this.submitAnswer.Location = new System.Drawing.Point(298, 58);
            this.submitAnswer.Name = "submitAnswer";
            this.submitAnswer.Size = new System.Drawing.Size(75, 23);
            this.submitAnswer.TabIndex = 12;
            this.submitAnswer.Text = "Submit";
            this.submitAnswer.UseVisualStyleBackColor = true;
            this.submitAnswer.Visible = false;
            this.submitAnswer.Click += new System.EventHandler(this.submitAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 34);
            this.label1.MinimumSize = new System.Drawing.Size(81, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 42);
            this.label1.TabIndex = 13;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.MaximumSize = new System.Drawing.Size(360, 110);
            this.label2.MinimumSize = new System.Drawing.Size(360, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 110);
            this.label2.TabIndex = 14;
            // 
            // binaryTutorialButton128
            // 
            this.binaryTutorialButton128.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTutorialButton128.Location = new System.Drawing.Point(12, 100);
            this.binaryTutorialButton128.Name = "binaryTutorialButton128";
            this.binaryTutorialButton128.Size = new System.Drawing.Size(40, 40);
            this.binaryTutorialButton128.TabIndex = 9;
            this.binaryTutorialButton128.Text = "0";
            this.binaryTutorialButton128.UseVisualStyleBackColor = true;
            this.binaryTutorialButton128.ValueAccess = 128;
            this.binaryTutorialButton128.Click += new System.EventHandler(this.binaryTutorialButton128_Click);
            // 
            // binaryTutorialButton1
            // 
            this.binaryTutorialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTutorialButton1.Location = new System.Drawing.Point(334, 100);
            this.binaryTutorialButton1.Name = "binaryTutorialButton1";
            this.binaryTutorialButton1.Size = new System.Drawing.Size(40, 40);
            this.binaryTutorialButton1.TabIndex = 8;
            this.binaryTutorialButton1.Text = "0";
            this.binaryTutorialButton1.UseVisualStyleBackColor = true;
            this.binaryTutorialButton1.ValueAccess = 1;
            this.binaryTutorialButton1.Click += new System.EventHandler(this.binaryTutorialButton1_Click);
            // 
            // binaryTutorialButton2
            // 
            this.binaryTutorialButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTutorialButton2.Location = new System.Drawing.Point(288, 100);
            this.binaryTutorialButton2.Name = "binaryTutorialButton2";
            this.binaryTutorialButton2.Size = new System.Drawing.Size(40, 40);
            this.binaryTutorialButton2.TabIndex = 7;
            this.binaryTutorialButton2.Text = "0";
            this.binaryTutorialButton2.UseVisualStyleBackColor = true;
            this.binaryTutorialButton2.ValueAccess = 2;
            this.binaryTutorialButton2.Click += new System.EventHandler(this.binaryTutorialButton2_Click);
            // 
            // binaryTutorialButton4
            // 
            this.binaryTutorialButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTutorialButton4.Location = new System.Drawing.Point(242, 100);
            this.binaryTutorialButton4.Name = "binaryTutorialButton4";
            this.binaryTutorialButton4.Size = new System.Drawing.Size(40, 40);
            this.binaryTutorialButton4.TabIndex = 6;
            this.binaryTutorialButton4.Text = "0";
            this.binaryTutorialButton4.UseVisualStyleBackColor = true;
            this.binaryTutorialButton4.ValueAccess = 4;
            this.binaryTutorialButton4.Click += new System.EventHandler(this.binaryTutorialButton4_Click);
            // 
            // binaryTutorialButton8
            // 
            this.binaryTutorialButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTutorialButton8.Location = new System.Drawing.Point(196, 100);
            this.binaryTutorialButton8.Name = "binaryTutorialButton8";
            this.binaryTutorialButton8.Size = new System.Drawing.Size(40, 40);
            this.binaryTutorialButton8.TabIndex = 5;
            this.binaryTutorialButton8.Text = "0";
            this.binaryTutorialButton8.UseVisualStyleBackColor = true;
            this.binaryTutorialButton8.ValueAccess = 8;
            this.binaryTutorialButton8.Click += new System.EventHandler(this.binaryTutorialButton8_Click);
            // 
            // binaryTutorialButton16
            // 
            this.binaryTutorialButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTutorialButton16.Location = new System.Drawing.Point(150, 100);
            this.binaryTutorialButton16.Name = "binaryTutorialButton16";
            this.binaryTutorialButton16.Size = new System.Drawing.Size(40, 40);
            this.binaryTutorialButton16.TabIndex = 4;
            this.binaryTutorialButton16.Text = "0";
            this.binaryTutorialButton16.UseVisualStyleBackColor = true;
            this.binaryTutorialButton16.ValueAccess = 16;
            this.binaryTutorialButton16.Click += new System.EventHandler(this.binaryTutorialButton16_Click);
            // 
            // binaryTutorialButton32
            // 
            this.binaryTutorialButton32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTutorialButton32.Location = new System.Drawing.Point(104, 100);
            this.binaryTutorialButton32.Name = "binaryTutorialButton32";
            this.binaryTutorialButton32.Size = new System.Drawing.Size(40, 40);
            this.binaryTutorialButton32.TabIndex = 3;
            this.binaryTutorialButton32.Text = "0";
            this.binaryTutorialButton32.UseVisualStyleBackColor = true;
            this.binaryTutorialButton32.ValueAccess = 32;
            this.binaryTutorialButton32.Click += new System.EventHandler(this.binaryTutorialButton32_Click);
            // 
            // binaryTutorialButton64
            // 
            this.binaryTutorialButton64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTutorialButton64.Location = new System.Drawing.Point(58, 100);
            this.binaryTutorialButton64.Name = "binaryTutorialButton64";
            this.binaryTutorialButton64.Size = new System.Drawing.Size(40, 40);
            this.binaryTutorialButton64.TabIndex = 2;
            this.binaryTutorialButton64.Text = "0";
            this.binaryTutorialButton64.UseVisualStyleBackColor = true;
            this.binaryTutorialButton64.ValueAccess = 64;
            this.binaryTutorialButton64.Click += new System.EventHandler(this.binaryTutorialButton64_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitAnswer);
            this.Controls.Add(this.getNewRandomNumber);
            this.Controls.Add(this.binaryTutorialButton128);
            this.Controls.Add(this.binaryTutorialButton1);
            this.Controls.Add(this.binaryTutorialButton2);
            this.Controls.Add(this.binaryTutorialButton4);
            this.Controls.Add(this.binaryTutorialButton8);
            this.Controls.Add(this.binaryTutorialButton16);
            this.Controls.Add(this.binaryTutorialButton32);
            this.Controls.Add(this.binaryTutorialButton64);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Binary Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resultBox;
        private BinaryTutorialButton binaryTutorialButton64;
        private BinaryTutorialButton binaryTutorialButton32;
        private BinaryTutorialButton binaryTutorialButton16;
        private BinaryTutorialButton binaryTutorialButton8;
        private BinaryTutorialButton binaryTutorialButton4;
        private BinaryTutorialButton binaryTutorialButton2;
        private BinaryTutorialButton binaryTutorialButton1;
        private BinaryTutorialButton binaryTutorialButton128;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem practiceModeToolStripMenuItem;
        private System.Windows.Forms.Button getNewRandomNumber;
        private System.Windows.Forms.Button submitAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

