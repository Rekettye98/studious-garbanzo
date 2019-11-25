namespace UserMaintenance
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(14, 10);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(183, 238);
            this.listUsers.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(204, 25);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(30, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Név:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(245, 22);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(143, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(207, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Hozzáad";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(207, 101);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(181, 31);
            this.Save.TabIndex = 6;
            this.Save.Text = "Fájlba írás";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(207, 138);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(181, 31);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Törlés";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 261);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
    }
}

