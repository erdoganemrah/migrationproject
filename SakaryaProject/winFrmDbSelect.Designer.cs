namespace Sakarya1
{
    partial class winFrmDbSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winFrmDbSelect));
            this.btnPostgreSQL = new System.Windows.Forms.Button();
            this.btnMSSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPostgreSQL
            // 
            this.btnPostgreSQL.BackgroundImage = global::Sakarya1.Properties.Resources.postgresql_2;
            this.btnPostgreSQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPostgreSQL.Location = new System.Drawing.Point(163, 12);
            this.btnPostgreSQL.Name = "btnPostgreSQL";
            this.btnPostgreSQL.Size = new System.Drawing.Size(145, 148);
            this.btnPostgreSQL.TabIndex = 1;
            this.btnPostgreSQL.UseVisualStyleBackColor = true;
            this.btnPostgreSQL.Click += new System.EventHandler(this.btnPostgreSQL_Click);
            // 
            // btnMSSQL
            // 
            this.btnMSSQL.BackgroundImage = global::Sakarya1.Properties.Resources.sqlserver;
            this.btnMSSQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMSSQL.Location = new System.Drawing.Point(12, 12);
            this.btnMSSQL.Name = "btnMSSQL";
            this.btnMSSQL.Size = new System.Drawing.Size(145, 148);
            this.btnMSSQL.TabIndex = 0;
            this.btnMSSQL.UseVisualStyleBackColor = true;
            this.btnMSSQL.Click += new System.EventHandler(this.btnMSSQL_Click);
            // 
            // winFrmDbSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 172);
            this.Controls.Add(this.btnPostgreSQL);
            this.Controls.Add(this.btnMSSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "winFrmDbSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDBMS Seçimi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMSSQL;
        private System.Windows.Forms.Button btnPostgreSQL;
    }
}