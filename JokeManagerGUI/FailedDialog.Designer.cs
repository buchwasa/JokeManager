namespace JokeManagerGUI
{
    partial class FailedDialog
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
            this.lblFailed = new System.Windows.Forms.Label();
            this.btnCloseFailed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Location = new System.Drawing.Point(70, 12);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(153, 16);
            this.lblFailed.TabIndex = 0;
            this.lblFailed.Text = "Task failed successfully.";
            // 
            // btnCloseFailed
            // 
            this.btnCloseFailed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseFailed.Location = new System.Drawing.Point(115, 43);
            this.btnCloseFailed.Name = "btnCloseFailed";
            this.btnCloseFailed.Size = new System.Drawing.Size(60, 27);
            this.btnCloseFailed.TabIndex = 2;
            this.btnCloseFailed.Text = "OK";
            this.btnCloseFailed.UseVisualStyleBackColor = true;
            this.btnCloseFailed.Click += new System.EventHandler(this.btnCloseFailed_Click);
            // 
            // FailedDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 110);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseFailed);
            this.Controls.Add(this.lblFailed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FailedDialog";
            this.ShowIcon = false;
            this.Text = "Joke Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Button btnCloseFailed;
    }
}