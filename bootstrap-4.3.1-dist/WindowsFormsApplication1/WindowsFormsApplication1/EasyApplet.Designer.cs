namespace WindowsFormsApplication1
{
    partial class EasyApplet
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
            this.AuthorFoundListBox = new System.Windows.Forms.ListBox();
            this.BookFoundListBox = new System.Windows.Forms.ListBox();
            this.AuthorNameTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextbox = new System.Windows.Forms.TextBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.AuthorNameLabel = new System.Windows.Forms.Label();
            this.AuthorSearchButton = new System.Windows.Forms.Button();
            this.BookSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthorFoundListBox
            // 
            this.AuthorFoundListBox.FormattingEnabled = true;
            this.AuthorFoundListBox.Location = new System.Drawing.Point(23, 116);
            this.AuthorFoundListBox.Name = "AuthorFoundListBox";
            this.AuthorFoundListBox.Size = new System.Drawing.Size(349, 355);
            this.AuthorFoundListBox.TabIndex = 0;
            // 
            // BookFoundListBox
            // 
            this.BookFoundListBox.FormattingEnabled = true;
            this.BookFoundListBox.Location = new System.Drawing.Point(647, 116);
            this.BookFoundListBox.Name = "BookFoundListBox";
            this.BookFoundListBox.Size = new System.Drawing.Size(399, 355);
            this.BookFoundListBox.TabIndex = 1;
            // 
            // AuthorNameTextBox
            // 
            this.AuthorNameTextBox.Location = new System.Drawing.Point(151, 53);
            this.AuthorNameTextBox.Name = "AuthorNameTextBox";
            this.AuthorNameTextBox.Size = new System.Drawing.Size(221, 20);
            this.AuthorNameTextBox.TabIndex = 2;
            // 
            // BookNameTextbox
            // 
            this.BookNameTextbox.Location = new System.Drawing.Point(828, 50);
            this.BookNameTextbox.Name = "BookNameTextbox";
            this.BookNameTextbox.Size = new System.Drawing.Size(218, 20);
            this.BookNameTextbox.TabIndex = 3;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(644, 53);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(63, 13);
            this.BookNameLabel.TabIndex = 4;
            this.BookNameLabel.Text = "Book Name";
            // 
            // AuthorNameLabel
            // 
            this.AuthorNameLabel.AutoSize = true;
            this.AuthorNameLabel.Location = new System.Drawing.Point(20, 56);
            this.AuthorNameLabel.Name = "AuthorNameLabel";
            this.AuthorNameLabel.Size = new System.Drawing.Size(69, 13);
            this.AuthorNameLabel.TabIndex = 5;
            this.AuthorNameLabel.Text = "Author Name";
            // 
            // AuthorSearchButton
            // 
            this.AuthorSearchButton.Location = new System.Drawing.Point(297, 87);
            this.AuthorSearchButton.Name = "AuthorSearchButton";
            this.AuthorSearchButton.Size = new System.Drawing.Size(75, 23);
            this.AuthorSearchButton.TabIndex = 6;
            this.AuthorSearchButton.Text = "Search...";
            this.AuthorSearchButton.UseVisualStyleBackColor = true;
            this.AuthorSearchButton.Click += new System.EventHandler(this.AuthorSearchButton_Click);
            // 
            // BookSearchButton
            // 
            this.BookSearchButton.Location = new System.Drawing.Point(957, 87);
            this.BookSearchButton.Name = "BookSearchButton";
            this.BookSearchButton.Size = new System.Drawing.Size(89, 23);
            this.BookSearchButton.TabIndex = 7;
            this.BookSearchButton.Text = "Search";
            this.BookSearchButton.UseVisualStyleBackColor = true;
            // 
            // EasyApplet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 483);
            this.Controls.Add(this.BookSearchButton);
            this.Controls.Add(this.AuthorSearchButton);
            this.Controls.Add(this.AuthorNameLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.BookNameTextbox);
            this.Controls.Add(this.AuthorNameTextBox);
            this.Controls.Add(this.BookFoundListBox);
            this.Controls.Add(this.AuthorFoundListBox);
            this.Name = "EasyApplet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AuthorFoundListBox;
        private System.Windows.Forms.ListBox BookFoundListBox;
        private System.Windows.Forms.TextBox AuthorNameTextBox;
        private System.Windows.Forms.TextBox BookNameTextbox;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label AuthorNameLabel;
        private System.Windows.Forms.Button AuthorSearchButton;
        private System.Windows.Forms.Button BookSearchButton;
    }
}

