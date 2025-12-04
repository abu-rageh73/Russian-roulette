namespace Russian_roulette
{
    partial class formmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formmenu));
            this.Btnplay = new System.Windows.Forms.Button();
            this.Btnrules = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btnplay
            // 
            this.Btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnplay.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnplay.ForeColor = System.Drawing.Color.Red;
            this.Btnplay.Location = new System.Drawing.Point(302, 137);
            this.Btnplay.Name = "Btnplay";
            this.Btnplay.Size = new System.Drawing.Size(149, 66);
            this.Btnplay.TabIndex = 1;
            this.Btnplay.Text = "PLAY";
            this.Btnplay.UseVisualStyleBackColor = false;
            this.Btnplay.UseWaitCursor = true;
            this.Btnplay.Click += new System.EventHandler(this.Btnplay_Click);
            // 
            // Btnrules
            // 
            this.Btnrules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnrules.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnrules.ForeColor = System.Drawing.Color.Red;
            this.Btnrules.Location = new System.Drawing.Point(302, 238);
            this.Btnrules.Name = "Btnrules";
            this.Btnrules.Size = new System.Drawing.Size(149, 66);
            this.Btnrules.TabIndex = 2;
            this.Btnrules.Text = "RULES";
            this.Btnrules.UseVisualStyleBackColor = false;
            this.Btnrules.UseWaitCursor = true;
            this.Btnrules.Click += new System.EventHandler(this.Btnrules_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(255, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Russian roulette";
            this.label1.UseWaitCursor = true;
            // 
            // formmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnrules);
            this.Controls.Add(this.Btnplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formmenu";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btnplay;
        private System.Windows.Forms.Button Btnrules;
        private System.Windows.Forms.Label label1;
    }
}

