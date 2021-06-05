namespace Sakarya1
{
    partial class AddDepartment_Postgres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment_Postgres));
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "DepartmentID";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(106, 14);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.ReadOnly = true;
            this.txtDepartmentID.Size = new System.Drawing.Size(146, 20);
            this.txtDepartmentID.TabIndex = 16;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(151, 118);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(101, 23);
            this.btnAddDepartment.TabIndex = 15;
            this.btnAddDepartment.Text = "Departman Ekle";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ModifiedDate";
            // 
            // txtModDate
            // 
            this.txtModDate.Location = new System.Drawing.Point(106, 92);
            this.txtModDate.Name = "txtModDate";
            this.txtModDate.ReadOnly = true;
            this.txtModDate.Size = new System.Drawing.Size(146, 20);
            this.txtModDate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "GroupName";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(106, 66);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(146, 20);
            this.txtGroupName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 9;
            // 
            // AddDepartment_Postgres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 151);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddDepartment_Postgres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartment - PG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}