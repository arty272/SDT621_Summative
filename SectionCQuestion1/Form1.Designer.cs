namespace SectionCQuestion1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private Label lblOutput;
        private Label lblMobileCode;
        private Label lblMake;
        private Label lblQuantity;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;

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
            lblOutput = new Label();
            lblMobileCode = new Label();
            txtCode = new TextBox();
            lblMake = new Label();
            txtMake = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Location = new Point(40, 20);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(700, 40);
            lblOutput.TabIndex = 0;
            // 
            // lblMobileCode
            // 
            lblMobileCode.AutoSize = true;
            lblMobileCode.Location = new Point(40, 90);
            lblMobileCode.Name = "lblMobileCode";
            lblMobileCode.Size = new Size(75, 15);
            lblMobileCode.TabIndex = 1;
            lblMobileCode.Text = "Mobile Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(200, 85);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(200, 23);
            txtCode.TabIndex = 2;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(40, 130);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(36, 15);
            lblMake.TabIndex = 3;
            lblMake.Text = "Make";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(200, 125);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(200, 23);
            txtMake.TabIndex = 4;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(40, 170);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(200, 165);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(80, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new EventHandler(btnAdd_Click);
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(240, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new EventHandler(btnDelete_Click);
            // 
            // btnFind
            // 
            btnFind.Location = new Point(400, 300);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(100, 40);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += new EventHandler(btnFind_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 386);
            Controls.Add(lblOutput);
            Controls.Add(lblMobileCode);
            Controls.Add(txtCode);
            Controls.Add(lblMake);
            Controls.Add(txtMake);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnFind);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
