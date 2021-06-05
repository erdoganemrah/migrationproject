namespace Sakarya1
{
    partial class winFrmPostgreSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winFrmPostgreSQL));
            this.btnUpdDepartment = new System.Windows.Forms.Button();
            this.btnDelDepartment = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnGetData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdDepartment
            // 
            this.btnUpdDepartment.Location = new System.Drawing.Point(404, 13);
            this.btnUpdDepartment.Name = "btnUpdDepartment";
            this.btnUpdDepartment.Size = new System.Drawing.Size(168, 23);
            this.btnUpdDepartment.TabIndex = 9;
            this.btnUpdDepartment.Text = "Seçilen Departmanı Güncelle";
            this.btnUpdDepartment.UseVisualStyleBackColor = true;
            this.btnUpdDepartment.Click += new System.EventHandler(this.btnUpdDepartment_Click);
            // 
            // btnDelDepartment
            // 
            this.btnDelDepartment.Location = new System.Drawing.Point(259, 13);
            this.btnDelDepartment.Name = "btnDelDepartment";
            this.btnDelDepartment.Size = new System.Drawing.Size(139, 23);
            this.btnDelDepartment.TabIndex = 8;
            this.btnDelDepartment.Text = "Seçilen Departmanı Sil";
            this.btnDelDepartment.UseVisualStyleBackColor = true;
            this.btnDelDepartment.Click += new System.EventHandler(this.btnDelDepartment_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(152, 12);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(101, 23);
            this.btnAddDepartment.TabIndex = 7;
            this.btnAddDepartment.Text = "Departman Ekle";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(13, 42);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(712, 359);
            this.gridView.TabIndex = 6;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(12, 12);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(134, 23);
            this.btnGetData.TabIndex = 5;
            this.btnGetData.Text = "Departmanları Listele";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // winFrmPostgreSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 414);
            this.Controls.Add(this.btnUpdDepartment);
            this.Controls.Add(this.btnDelDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnGetData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "winFrmPostgreSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdventureWorks - PostgreSQL";
            this.Load += new System.EventHandler(this.winFrmPostgreSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdDepartment;
        private System.Windows.Forms.Button btnDelDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnGetData;
    }
}