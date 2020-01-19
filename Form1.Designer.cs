namespace SamsSimpleSupportRequest
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
            this.instructionLbl = new System.Windows.Forms.Label();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameChrCountLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailChrCountLbl = new System.Windows.Forms.Label();
            this.problemLbl = new System.Windows.Forms.Label();
            this.problemTextBox = new System.Windows.Forms.TextBox();
            this.problemChrCountLbl = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLbl.Location = new System.Drawing.Point(12, 9);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(104, 24);
            this.instructionLbl.TabIndex = 0;
            this.instructionLbl.Text = "Instructions";
            this.instructionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionTextBox.Location = new System.Drawing.Point(16, 36);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.ReadOnly = true;
            this.instructionTextBox.Size = new System.Drawing.Size(512, 42);
            this.instructionTextBox.TabIndex = 0;
            this.instructionTextBox.TabStop = false;
            this.instructionTextBox.Text = "Welcome to Sam\'s Simple Support Requester. Please fill out the boxes below as ins" +
    "tructed to receive quick and easy tech support!";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 91);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(106, 24);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Your Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(124, 94);
            this.nameTextBox.MaxLength = 70;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(167, 22);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameChrCountLbl
            // 
            this.nameChrCountLbl.AutoSize = true;
            this.nameChrCountLbl.Location = new System.Drawing.Point(297, 99);
            this.nameChrCountLbl.Name = "nameChrCountLbl";
            this.nameChrCountLbl.Size = new System.Drawing.Size(83, 13);
            this.nameChrCountLbl.TabIndex = 3;
            this.nameChrCountLbl.Text = "0/70 characters";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(12, 132);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(102, 24);
            this.emailLbl.TabIndex = 4;
            this.emailLbl.Text = "Your Email";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(124, 135);
            this.emailTextBox.MaxLength = 32;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(167, 22);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // emailChrCountLbl
            // 
            this.emailChrCountLbl.AutoSize = true;
            this.emailChrCountLbl.Location = new System.Drawing.Point(297, 140);
            this.emailChrCountLbl.Name = "emailChrCountLbl";
            this.emailChrCountLbl.Size = new System.Drawing.Size(83, 13);
            this.emailChrCountLbl.TabIndex = 6;
            this.emailChrCountLbl.Text = "0/32 characters";
            // 
            // problemLbl
            // 
            this.problemLbl.AutoSize = true;
            this.problemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemLbl.Location = new System.Drawing.Point(12, 173);
            this.problemLbl.Name = "problemLbl";
            this.problemLbl.Size = new System.Drawing.Size(126, 24);
            this.problemLbl.TabIndex = 7;
            this.problemLbl.Text = "Your Problem";
            this.problemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problemTextBox
            // 
            this.problemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemTextBox.Location = new System.Drawing.Point(144, 176);
            this.problemTextBox.MaxLength = 512;
            this.problemTextBox.Multiline = true;
            this.problemTextBox.Name = "problemTextBox";
            this.problemTextBox.Size = new System.Drawing.Size(384, 222);
            this.problemTextBox.TabIndex = 8;
            this.problemTextBox.TextChanged += new System.EventHandler(this.problemTextBox_TextChanged);
            // 
            // problemChrCountLbl
            // 
            this.problemChrCountLbl.AutoSize = true;
            this.problemChrCountLbl.Location = new System.Drawing.Point(439, 401);
            this.problemChrCountLbl.Name = "problemChrCountLbl";
            this.problemChrCountLbl.Size = new System.Drawing.Size(89, 13);
            this.problemChrCountLbl.TabIndex = 9;
            this.problemChrCountLbl.Text = "0/512 characters";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(144, 415);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 10;
            this.sendButton.TabStop = false;
            this.sendButton.Text = "&Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(225, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "E&xit";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.problemChrCountLbl);
            this.Controls.Add(this.problemTextBox);
            this.Controls.Add(this.problemLbl);
            this.Controls.Add(this.emailChrCountLbl);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.nameChrCountLbl);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.instructionLbl);
            this.Name = "Form1";
            this.Text = "Simple Support Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.TextBox instructionTextBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameChrCountLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailChrCountLbl;
        private System.Windows.Forms.Label problemLbl;
        private System.Windows.Forms.TextBox problemTextBox;
        private System.Windows.Forms.Label problemChrCountLbl;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearButton;
    }
}

