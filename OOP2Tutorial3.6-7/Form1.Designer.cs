namespace OOP2Tutorial3._5_7
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(75, 58);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(120, 84);
            this.ItemsListBox.TabIndex = 0;
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(75, 148);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(120, 22);
            this.ItemTextBox.TabIndex = 1;
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(75, 176);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(120, 23);
            this.AddItem.TabIndex = 2;
            this.AddItem.Text = "Add!";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // RemoveItem
            // 
            this.RemoveItem.Location = new System.Drawing.Point(75, 205);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(120, 23);
            this.RemoveItem.TabIndex = 3;
            this.RemoveItem.Text = "Remove!";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 284);
            this.Controls.Add(this.RemoveItem);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.ItemsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button RemoveItem;

        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.TextBox ItemTextBox;

        #endregion
    }
}