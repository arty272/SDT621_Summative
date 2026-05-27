namespace SectionBQuestion1._2
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            nameLabel = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            greetButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(40, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(100, 23);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Enter your name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(150, 37);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(200, 23);
            nameTextBox.TabIndex = 1;
            // 
            // greetButton
            // 
            greetButton.Location = new System.Drawing.Point(150, 80);
            greetButton.Name = "greetButton";
            greetButton.Size = new System.Drawing.Size(100, 30);
            greetButton.TabIndex = 2;
            greetButton.Text = "Greeting";
            greetButton.UseVisualStyleBackColor = true;
            greetButton.Click += new System.EventHandler(this.greetButton_Click);
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(420, 180);
            Controls.Add(greetButton);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "Greeting App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button greetButton;
    }
}
