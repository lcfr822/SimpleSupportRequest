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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instructionLbl);
            this.Name = "Form1";
            this.Text = "Sam\'s Simple Support Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLbl;
    }
}

