namespace Russian_roulette
{
    partial class formplay
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
            this.Btntry = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btntry
            // 
            this.Btntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btntry.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btntry.Location = new System.Drawing.Point(361, 186);
            this.Btntry.Name = "Btntry";
            this.Btntry.Size = new System.Drawing.Size(170, 66);
            this.Btntry.TabIndex = 2;
            this.Btntry.Text = "TRY YOUR LUCK :)";
            this.Btntry.UseVisualStyleBackColor = false;
            this.Btntry.Click += new System.EventHandler(this.Btntry_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.Red;
            this.lblstatus.Location = new System.Drawing.Point(216, 53);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(469, 34);
            this.lblstatus.TabIndex = 3;
            this.lblstatus.Text = "Result";
            this.lblstatus.Click += new System.EventHandler(this.lblstatus_Click);
            // 
            // formplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.Btntry);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.formplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btntry;
        private System.Windows.Forms.Label lblstatus;
    }
}