namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class PersonEdit
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
            this.txtEditAddedBy = new System.Windows.Forms.TextBox();
            this.lblEditAddedBy = new System.Windows.Forms.Label();
            this.lblEditPerson = new System.Windows.Forms.Label();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.cmbEditCountry = new System.Windows.Forms.ComboBox();
            this.cmbEditCity = new System.Windows.Forms.ComboBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditCountry = new System.Windows.Forms.Label();
            this.lblEditCity = new System.Windows.Forms.Label();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEditAddedBy
            // 
            this.txtEditAddedBy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEditAddedBy.Location = new System.Drawing.Point(303, 317);
            this.txtEditAddedBy.Name = "txtEditAddedBy";
            this.txtEditAddedBy.Size = new System.Drawing.Size(263, 20);
            this.txtEditAddedBy.TabIndex = 25;
            // 
            // lblEditAddedBy
            // 
            this.lblEditAddedBy.AutoSize = true;
            this.lblEditAddedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditAddedBy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditAddedBy.Location = new System.Drawing.Point(119, 317);
            this.lblEditAddedBy.Name = "lblEditAddedBy";
            this.lblEditAddedBy.Size = new System.Drawing.Size(69, 16);
            this.lblEditAddedBy.TabIndex = 24;
            this.lblEditAddedBy.Text = "Full Name";
            // 
            // lblEditPerson
            // 
            this.lblEditPerson.AutoSize = true;
            this.lblEditPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPerson.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEditPerson.Location = new System.Drawing.Point(245, 22);
            this.lblEditPerson.Name = "lblEditPerson";
            this.lblEditPerson.Size = new System.Drawing.Size(331, 39);
            this.lblEditPerson.TabIndex = 23;
            this.lblEditPerson.Text = "Edit Person Details";
            this.lblEditPerson.Click += new System.EventHandler(this.lblEditPerson_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Location = new System.Drawing.Point(478, 393);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(88, 36);
            this.btnEditCancel.TabIndex = 22;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.Location = new System.Drawing.Point(303, 393);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(94, 36);
            this.btnEditSave.TabIndex = 21;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // cmbEditCountry
            // 
            this.cmbEditCountry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbEditCountry.FormattingEnabled = true;
            this.cmbEditCountry.Location = new System.Drawing.Point(303, 237);
            this.cmbEditCountry.Name = "cmbEditCountry";
            this.cmbEditCountry.Size = new System.Drawing.Size(263, 21);
            this.cmbEditCountry.TabIndex = 20;
            // 
            // cmbEditCity
            // 
            this.cmbEditCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbEditCity.FormattingEnabled = true;
            this.cmbEditCity.Location = new System.Drawing.Point(303, 184);
            this.cmbEditCity.Name = "cmbEditCity";
            this.cmbEditCity.Size = new System.Drawing.Size(263, 21);
            this.cmbEditCity.TabIndex = 19;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEditEmail.Location = new System.Drawing.Point(303, 138);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(379, 20);
            this.txtEditEmail.TabIndex = 18;
            // 
            // txtEditName
            // 
            this.txtEditName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEditName.Location = new System.Drawing.Point(303, 90);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(263, 20);
            this.txtEditName.TabIndex = 17;
            // 
            // lblEditCountry
            // 
            this.lblEditCountry.AutoSize = true;
            this.lblEditCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCountry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditCountry.Location = new System.Drawing.Point(119, 242);
            this.lblEditCountry.Name = "lblEditCountry";
            this.lblEditCountry.Size = new System.Drawing.Size(53, 16);
            this.lblEditCountry.TabIndex = 16;
            this.lblEditCountry.Text = "Country";
            // 
            // lblEditCity
            // 
            this.lblEditCity.AutoSize = true;
            this.lblEditCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditCity.Location = new System.Drawing.Point(119, 184);
            this.lblEditCity.Name = "lblEditCity";
            this.lblEditCity.Size = new System.Drawing.Size(30, 16);
            this.lblEditCity.TabIndex = 15;
            this.lblEditCity.Text = "City";
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditEmail.Location = new System.Drawing.Point(119, 138);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(96, 16);
            this.lblEditEmail.TabIndex = 14;
            this.lblEditEmail.Text = "Email Address";
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditName.Location = new System.Drawing.Point(119, 94);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(65, 16);
            this.lblEditName.TabIndex = 13;
            this.lblEditName.Text = "Person Id";
            this.lblEditName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditAddedBy);
            this.Controls.Add(this.lblEditAddedBy);
            this.Controls.Add(this.lblEditPerson);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.cmbEditCountry);
            this.Controls.Add(this.cmbEditCity);
            this.Controls.Add(this.txtEditEmail);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.lblEditCountry);
            this.Controls.Add(this.lblEditCity);
            this.Controls.Add(this.lblEditEmail);
            this.Controls.Add(this.lblEditName);
            this.Name = "PersonEdit";
            this.Text = "PersonEdit";
            this.Load += new System.EventHandler(this.PersonEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditAddedBy;
        private System.Windows.Forms.Label lblEditAddedBy;
        private System.Windows.Forms.Label lblEditPerson;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.ComboBox cmbEditCountry;
        private System.Windows.Forms.ComboBox cmbEditCity;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditCountry;
        private System.Windows.Forms.Label lblEditCity;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.Label lblEditName;
    }
}