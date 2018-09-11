namespace GeoFlashCard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnChoiceOne = new System.Windows.Forms.Button();
            this._btnChoiceTwo = new System.Windows.Forms.Button();
            this._btnChoiceThree = new System.Windows.Forms.Button();
            this._btnChoiceFour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 334);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnChoiceFour);
            this.groupBox1.Controls.Add(this._btnChoiceThree);
            this.groupBox1.Controls.Add(this._btnChoiceTwo);
            this.groupBox1.Controls.Add(this._btnChoiceOne);
            this.groupBox1.Location = new System.Drawing.Point(217, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the correct name";
            // 
            // _btnChoiceOne
            // 
            this._btnChoiceOne.Location = new System.Drawing.Point(6, 38);
            this._btnChoiceOne.Name = "_btnChoiceOne";
            this._btnChoiceOne.Size = new System.Drawing.Size(135, 23);
            this._btnChoiceOne.TabIndex = 0;
            this._btnChoiceOne.Text = "button1";
            this._btnChoiceOne.UseVisualStyleBackColor = true;
            // 
            // _btnChoiceTwo
            // 
            this._btnChoiceTwo.Location = new System.Drawing.Point(196, 38);
            this._btnChoiceTwo.Name = "_btnChoiceTwo";
            this._btnChoiceTwo.Size = new System.Drawing.Size(135, 23);
            this._btnChoiceTwo.TabIndex = 1;
            this._btnChoiceTwo.Text = "button2";
            this._btnChoiceTwo.UseVisualStyleBackColor = true;
            // 
            // _btnChoiceThree
            // 
            this._btnChoiceThree.Location = new System.Drawing.Point(6, 86);
            this._btnChoiceThree.Name = "_btnChoiceThree";
            this._btnChoiceThree.Size = new System.Drawing.Size(135, 23);
            this._btnChoiceThree.TabIndex = 2;
            this._btnChoiceThree.Text = "button3";
            this._btnChoiceThree.UseVisualStyleBackColor = true;
            // 
            // _btnChoiceFour
            // 
            this._btnChoiceFour.Location = new System.Drawing.Point(196, 86);
            this._btnChoiceFour.Name = "_btnChoiceFour";
            this._btnChoiceFour.Size = new System.Drawing.Size(135, 23);
            this._btnChoiceFour.TabIndex = 3;
            this._btnChoiceFour.Text = "button4";
            this._btnChoiceFour.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnChoiceFour;
        private System.Windows.Forms.Button _btnChoiceThree;
        private System.Windows.Forms.Button _btnChoiceTwo;
        private System.Windows.Forms.Button _btnChoiceOne;
    }
}

