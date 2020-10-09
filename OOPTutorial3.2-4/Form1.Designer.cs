﻿namespace OOPTutorial3._2
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
            this.ValueOne = new System.Windows.Forms.TextBox();
            this.ValueTwo = new System.Windows.Forms.TextBox();
            this.RadioAddition = new System.Windows.Forms.RadioButton();
            this.RadioSubtraction = new System.Windows.Forms.RadioButton();
            this.RadioMultiplication = new System.Windows.Forms.RadioButton();
            this.RadioDivision = new System.Windows.Forms.RadioButton();
            this.Calculate = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultValue = new System.Windows.Forms.Label();
            this.ShowGoodbyeMsg = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ValueOne
            // 
            this.ValueOne.Location = new System.Drawing.Point(79, 27);
            this.ValueOne.Name = "ValueOne";
            this.ValueOne.Size = new System.Drawing.Size(100, 22);
            this.ValueOne.TabIndex = 0;
            // 
            // ValueTwo
            // 
            this.ValueTwo.Location = new System.Drawing.Point(79, 72);
            this.ValueTwo.Name = "ValueTwo";
            this.ValueTwo.Size = new System.Drawing.Size(100, 22);
            this.ValueTwo.TabIndex = 1;
            // 
            // RadioAddition
            // 
            this.RadioAddition.Location = new System.Drawing.Point(79, 100);
            this.RadioAddition.Name = "RadioAddition";
            this.RadioAddition.Size = new System.Drawing.Size(119, 24);
            this.RadioAddition.TabIndex = 2;
            this.RadioAddition.TabStop = true;
            this.RadioAddition.Text = "Addition";
            this.RadioAddition.UseVisualStyleBackColor = true;
            this.RadioAddition.CheckedChanged += new System.EventHandler(this.RadioAddition_CheckedChanged);
            // 
            // RadioSubtraction
            // 
            this.RadioSubtraction.Location = new System.Drawing.Point(79, 130);
            this.RadioSubtraction.Name = "RadioSubtraction";
            this.RadioSubtraction.Size = new System.Drawing.Size(119, 24);
            this.RadioSubtraction.TabIndex = 3;
            this.RadioSubtraction.TabStop = true;
            this.RadioSubtraction.Text = "Subtraction";
            this.RadioSubtraction.UseVisualStyleBackColor = true;
            this.RadioSubtraction.CheckedChanged += new System.EventHandler(this.RadioSubtraction_CheckedChanged);
            // 
            // RadioMultiplication
            // 
            this.RadioMultiplication.Location = new System.Drawing.Point(79, 160);
            this.RadioMultiplication.Name = "RadioMultiplication";
            this.RadioMultiplication.Size = new System.Drawing.Size(119, 24);
            this.RadioMultiplication.TabIndex = 4;
            this.RadioMultiplication.TabStop = true;
            this.RadioMultiplication.Text = "Multiplication";
            this.RadioMultiplication.UseVisualStyleBackColor = true;
            this.RadioMultiplication.CheckedChanged += new System.EventHandler(this.RadioMultiplication_CheckedChanged);
            // 
            // RadioDivision
            // 
            this.RadioDivision.Location = new System.Drawing.Point(79, 190);
            this.RadioDivision.Name = "RadioDivision";
            this.RadioDivision.Size = new System.Drawing.Size(119, 24);
            this.RadioDivision.TabIndex = 5;
            this.RadioDivision.TabStop = true;
            this.RadioDivision.Text = "Division";
            this.RadioDivision.UseVisualStyleBackColor = true;
            this.RadioDivision.CheckedChanged += new System.EventHandler(this.RadioDivision_CheckedChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(79, 220);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Do math!";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(79, 246);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(100, 23);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Result:";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultValue
            // 
            this.ResultValue.Location = new System.Drawing.Point(79, 269);
            this.ResultValue.Name = "ResultValue";
            this.ResultValue.Size = new System.Drawing.Size(100, 23);
            this.ResultValue.TabIndex = 8;
            this.ResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowGoodbyeMsg
            // 
            this.ShowGoodbyeMsg.Location = new System.Drawing.Point(79, 310);
            this.ShowGoodbyeMsg.Checked = true;
            this.ShowGoodbyeMsg.Name = "ShowGoodbyeMsg";
            this.ShowGoodbyeMsg.Size = new System.Drawing.Size(146, 24);
            this.ShowGoodbyeMsg.TabIndex = 9;
            this.ShowGoodbyeMsg.Text = "Goodbye message";
            this.ShowGoodbyeMsg.UseVisualStyleBackColor = true;
            this.ShowGoodbyeMsg.CheckedChanged += new System.EventHandler(this.ShowGoodbyeMsg_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 355);
            this.Controls.Add(this.ShowGoodbyeMsg);
            this.Controls.Add(this.ResultValue);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.RadioDivision);
            this.Controls.Add(this.RadioMultiplication);
            this.Controls.Add(this.RadioSubtraction);
            this.Controls.Add(this.RadioAddition);
            this.Controls.Add(this.ValueTwo);
            this.Controls.Add(this.ValueOne);
            this.Name = "Form1";
            this.Text = "Tutorial 3 part 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox ShowGoodbyeMsg;

        private System.Windows.Forms.TextBox ValueOne;
        private System.Windows.Forms.TextBox ValueTwo;

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.RadioButton RadioAddition;
        private System.Windows.Forms.RadioButton RadioDivision;
        private System.Windows.Forms.RadioButton RadioMultiplication;
        private System.Windows.Forms.RadioButton RadioSubtraction;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ResultValue;

        #endregion
    }
}