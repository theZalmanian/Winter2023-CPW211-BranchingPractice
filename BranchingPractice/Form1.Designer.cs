namespace BranchingPractice
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
            this.btnDisplayGreeting = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplayGreeting
            // 
            this.btnDisplayGreeting.Location = new System.Drawing.Point(81, 54);
            this.btnDisplayGreeting.Name = "btnDisplayGreeting";
            this.btnDisplayGreeting.Size = new System.Drawing.Size(113, 23);
            this.btnDisplayGreeting.TabIndex = 0;
            this.btnDisplayGreeting.Text = "Display Greeting";
            this.btnDisplayGreeting.UseVisualStyleBackColor = true;
            this.btnDisplayGreeting.Click += new System.EventHandler(this.BtnDisplayGreeting_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(81, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(113, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(33, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(42, 15);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Name:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDisplayGreeting;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(253, 150);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnDisplayGreeting);
            this.Name = "Form1";
            this.Text = "Branching Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDisplayGreeting;
        private TextBox txtUserName;
        private Label lblUserName;
    }
}