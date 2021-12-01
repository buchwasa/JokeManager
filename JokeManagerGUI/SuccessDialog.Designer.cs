namespace JokeManagerGUI
{
    partial class SuccessDialog
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
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnCloseSuccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(42, 27);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(177, 16);
            this.lblSuccess.TabIndex = 0;
            this.lblSuccess.Text = "Joke submitted successfully!";
            this.lblSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseSuccess
            // 
            this.btnCloseSuccess.Location = new System.Drawing.Point(226, 55);
            this.btnCloseSuccess.Name = "btnCloseSuccess";
            this.btnCloseSuccess.Size = new System.Drawing.Size(60, 27);
            this.btnCloseSuccess.TabIndex = 1;
            this.btnCloseSuccess.Text = "Close";
            this.btnCloseSuccess.UseVisualStyleBackColor = true;
            this.btnCloseSuccess.Click += new System.EventHandler(this.btnCloseSuccess_Click);
            // 
            // SuccessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 124);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseSuccess);
            this.Controls.Add(this.lblSuccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SuccessDialog";
            this.ShowIcon = false;
            this.Text = "Joke Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnCloseSuccess;
    }
}