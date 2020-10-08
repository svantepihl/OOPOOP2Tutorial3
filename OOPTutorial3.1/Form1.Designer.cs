namespace OOPTutorial3._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.IntegerOne = new System.Windows.Forms.TextBox();
            this.IntegerTwo = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntegerOne
            // 
            this.IntegerOne.Location = new System.Drawing.Point(60, 24);
            this.IntegerOne.Name = "IntegerOne";
            this.IntegerOne.Size = new System.Drawing.Size(100, 22);
            this.IntegerOne.TabIndex = 0;
            // 
            // IntegerTwo
            // 
            this.IntegerTwo.Location = new System.Drawing.Point(60, 52);
            this.IntegerTwo.Name = "IntegerTwo";
            this.IntegerTwo.Size = new System.Drawing.Size(100, 22);
            this.IntegerTwo.TabIndex = 1;
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(60, 80);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(100, 23);
            this.Addition.TabIndex = 2;
            this.Addition.Text = "Add!";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(60, 106);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(100, 23);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Result:";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultValue
            // 
            this.ResultValue.Location = new System.Drawing.Point(60, 129);
            this.ResultValue.Name = "ResultValue";
            this.ResultValue.Size = new System.Drawing.Size(100, 23);
            this.ResultValue.TabIndex = 4;
            this.ResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 174);
            this.Controls.Add(this.ResultValue);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.IntegerTwo);
            this.Controls.Add(this.IntegerOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label ResultValue;

        private System.Windows.Forms.Label ResultLabel;

        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.TextBox IntegerTwo;

        private System.Windows.Forms.TextBox IntegerOne;

        #endregion
    }
}