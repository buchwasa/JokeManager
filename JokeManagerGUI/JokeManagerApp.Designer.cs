namespace JokeManagerGUI
{
    partial class JokeManagerApp
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblUCID = new System.Windows.Forms.Label();
            this.txtUCID = new System.Windows.Forms.TextBox();
            this.lblJoke = new System.Windows.Forms.Label();
            this.txtJoke = new System.Windows.Forms.TextBox();
            this.tvJokes = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(478, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblUCID
            // 
            this.lblUCID.AutoSize = true;
            this.lblUCID.Location = new System.Drawing.Point(278, 9);
            this.lblUCID.Name = "lblUCID";
            this.lblUCID.Size = new System.Drawing.Size(105, 16);
            this.lblUCID.TabIndex = 1;
            this.lblUCID.Text = "Enter your UCID:";
            // 
            // txtUCID
            // 
            this.txtUCID.Location = new System.Drawing.Point(281, 28);
            this.txtUCID.MaxLength = 8;
            this.txtUCID.Name = "txtUCID";
            this.txtUCID.Size = new System.Drawing.Size(102, 22);
            this.txtUCID.TabIndex = 2;
            // 
            // lblJoke
            // 
            this.lblJoke.AutoSize = true;
            this.lblJoke.Location = new System.Drawing.Point(278, 99);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(81, 16);
            this.lblJoke.TabIndex = 3;
            this.lblJoke.Text = "Enter a joke:";
            // 
            // txtJoke
            // 
            this.txtJoke.Location = new System.Drawing.Point(281, 118);
            this.txtJoke.MaxLength = 4000;
            this.txtJoke.Multiline = true;
            this.txtJoke.Name = "txtJoke";
            this.txtJoke.Size = new System.Drawing.Size(311, 152);
            this.txtJoke.TabIndex = 4;
            // 
            // tvJokes
            // 
            this.tvJokes.Location = new System.Drawing.Point(12, 12);
            this.tvJokes.Name = "tvJokes";
            this.tvJokes.Size = new System.Drawing.Size(260, 308);
            this.tvJokes.TabIndex = 5;
            // 
            // JokeManagerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 341);
            this.Controls.Add(this.tvJokes);
            this.Controls.Add(this.txtJoke);
            this.Controls.Add(this.lblJoke);
            this.Controls.Add(this.txtUCID);
            this.Controls.Add(this.lblUCID);
            this.Controls.Add(this.btnSubmit);
            this.Name = "JokeManagerApp";
            this.ShowIcon = false;
            this.Text = "Joke Manager";
            this.Load += new System.EventHandler(this.JokeManagerApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblUCID;
        private System.Windows.Forms.TextBox txtUCID;
        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.TextBox txtJoke;
        private System.Windows.Forms.TreeView tvJokes;
    }
}

