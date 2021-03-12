
namespace ForceTopMost
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
            this.cmbWindowsOpened = new System.Windows.Forms.ComboBox();
            this.btnRefreshWindows = new System.Windows.Forms.Button();
            this.btnForceTopMost = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbWindowsOpened
            // 
            this.cmbWindowsOpened.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbWindowsOpened.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbWindowsOpened.FormattingEnabled = true;
            this.cmbWindowsOpened.Location = new System.Drawing.Point(12, 54);
            this.cmbWindowsOpened.Name = "cmbWindowsOpened";
            this.cmbWindowsOpened.Size = new System.Drawing.Size(417, 21);
            this.cmbWindowsOpened.TabIndex = 0;
            // 
            // btnRefreshWindows
            // 
            this.btnRefreshWindows.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreshWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshWindows.Location = new System.Drawing.Point(12, 12);
            this.btnRefreshWindows.Name = "btnRefreshWindows";
            this.btnRefreshWindows.Size = new System.Drawing.Size(110, 36);
            this.btnRefreshWindows.TabIndex = 1;
            this.btnRefreshWindows.Text = "Refresh";
            this.btnRefreshWindows.UseVisualStyleBackColor = false;
            this.btnRefreshWindows.Click += new System.EventHandler(this.btnRefreshWindows_Click);
            // 
            // btnForceTopMost
            // 
            this.btnForceTopMost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnForceTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForceTopMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForceTopMost.Location = new System.Drawing.Point(128, 12);
            this.btnForceTopMost.Name = "btnForceTopMost";
            this.btnForceTopMost.Size = new System.Drawing.Size(110, 36);
            this.btnForceTopMost.TabIndex = 2;
            this.btnForceTopMost.Text = "Top Most";
            this.btnForceTopMost.UseVisualStyleBackColor = false;
            this.btnForceTopMost.Click += new System.EventHandler(this.btnForceTopMost_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(244, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove Top Most";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(455, 87);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnForceTopMost);
            this.Controls.Add(this.btnRefreshWindows);
            this.Controls.Add(this.cmbWindowsOpened);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbWindowsOpened;
        private System.Windows.Forms.Button btnRefreshWindows;
        private System.Windows.Forms.Button btnForceTopMost;
        private System.Windows.Forms.Button button1;
    }
}

