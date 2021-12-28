namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class PersonDelete
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
            this.txtDeleteAddedBy = new System.Windows.Forms.TextBox();
            this.lblDeleteAddedBy = new System.Windows.Forms.Label();
            this.lblDeletePerson = new System.Windows.Forms.Label();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDeleteSave = new System.Windows.Forms.Button();
            this.cmbDeleteCountry = new System.Windows.Forms.ComboBox();
            this.cmbDeleteCity = new System.Windows.Forms.ComboBox();
            this.txtDeleteEmail = new System.Windows.Forms.TextBox();
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.lblDeleteCountry = new System.Windows.Forms.Label();
            this.lblDeleteCity = new System.Windows.Forms.Label();
            this.lblDeleteEmail = new System.Windows.Forms.Label();
            this.lblDeleteName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDeleteAddedBy
            // 
            this.txtDeleteAddedBy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDeleteAddedBy.Location = new System.Drawing.Point(303, 317);
            this.txtDeleteAddedBy.Name = "txtDeleteAddedBy";
            this.txtDeleteAddedBy.Size = new System.Drawing.Size(263, 20);
            this.txtDeleteAddedBy.TabIndex = 38;
            this.txtDeleteAddedBy.TextChanged += new System.EventHandler(this.txtDeleteAddedBy_TextChanged);
            // 
            // lblDeleteAddedBy
            // 
            this.lblDeleteAddedBy.AutoSize = true;
            this.lblDeleteAddedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAddedBy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeleteAddedBy.Location = new System.Drawing.Point(119, 317);
            this.lblDeleteAddedBy.Name = "lblDeleteAddedBy";
            this.lblDeleteAddedBy.Size = new System.Drawing.Size(68, 16);
            this.lblDeleteAddedBy.TabIndex = 37;
            this.lblDeleteAddedBy.Text = "Added By";
            this.lblDeleteAddedBy.Click += new System.EventHandler(this.lblDeleteAddedBy_Click);
            // 
            // lblDeletePerson
            // 
            this.lblDeletePerson.AutoSize = true;
            this.lblDeletePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletePerson.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDeletePerson.Location = new System.Drawing.Point(245, 22);
            this.lblDeletePerson.Name = "lblDeletePerson";
            this.lblDeletePerson.Size = new System.Drawing.Size(373, 39);
            this.lblDeletePerson.TabIndex = 36;
            this.lblDeletePerson.Text = "Delete Person Details";
            this.lblDeletePerson.Click += new System.EventHandler(this.lblDeletePerson_Click);
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCancel.Location = new System.Drawing.Point(478, 393);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(88, 36);
            this.btnDeleteCancel.TabIndex = 35;
            this.btnDeleteCancel.Text = "Cancel";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDeleteSave
            // 
            this.btnDeleteSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSave.Location = new System.Drawing.Point(303, 393);
            this.btnDeleteSave.Name = "btnDeleteSave";
            this.btnDeleteSave.Size = new System.Drawing.Size(94, 36);
            this.btnDeleteSave.TabIndex = 34;
            this.btnDeleteSave.Text = "Save";
            this.btnDeleteSave.UseVisualStyleBackColor = true;
            this.btnDeleteSave.Click += new System.EventHandler(this.btnDeleteSave_Click);
            // 
            // cmbDeleteCountry
            // 
            this.cmbDeleteCountry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDeleteCountry.FormattingEnabled = true;
            this.cmbDeleteCountry.Location = new System.Drawing.Point(303, 237);
            this.cmbDeleteCountry.Name = "cmbDeleteCountry";
            this.cmbDeleteCountry.Size = new System.Drawing.Size(263, 21);
            this.cmbDeleteCountry.TabIndex = 33;
            this.cmbDeleteCountry.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteCountry_SelectedIndexChanged);
            // 
            // cmbDeleteCity
            // 
            this.cmbDeleteCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDeleteCity.FormattingEnabled = true;
            this.cmbDeleteCity.Location = new System.Drawing.Point(303, 184);
            this.cmbDeleteCity.Name = "cmbDeleteCity";
            this.cmbDeleteCity.Size = new System.Drawing.Size(263, 21);
            this.cmbDeleteCity.TabIndex = 32;
            this.cmbDeleteCity.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteCity_SelectedIndexChanged);
            // 
            // txtDeleteEmail
            // 
            this.txtDeleteEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDeleteEmail.Location = new System.Drawing.Point(303, 138);
            this.txtDeleteEmail.Name = "txtDeleteEmail";
            this.txtDeleteEmail.Size = new System.Drawing.Size(379, 20);
            this.txtDeleteEmail.TabIndex = 31;
            this.txtDeleteEmail.TextChanged += new System.EventHandler(this.txtDeleteEmail_TextChanged);
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDeleteName.Location = new System.Drawing.Point(303, 90);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(263, 20);
            this.txtDeleteName.TabIndex = 30;
            this.txtDeleteName.TextChanged += new System.EventHandler(this.txtDeleteName_TextChanged);
            // 
            // lblDeleteCountry
            // 
            this.lblDeleteCountry.AutoSize = true;
            this.lblDeleteCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCountry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeleteCountry.Location = new System.Drawing.Point(119, 242);
            this.lblDeleteCountry.Name = "lblDeleteCountry";
            this.lblDeleteCountry.Size = new System.Drawing.Size(53, 16);
            this.lblDeleteCountry.TabIndex = 29;
            this.lblDeleteCountry.Text = "Country";
            this.lblDeleteCountry.Click += new System.EventHandler(this.lblDeleteCountry_Click);
            // 
            // lblDeleteCity
            // 
            this.lblDeleteCity.AutoSize = true;
            this.lblDeleteCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeleteCity.Location = new System.Drawing.Point(119, 184);
            this.lblDeleteCity.Name = "lblDeleteCity";
            this.lblDeleteCity.Size = new System.Drawing.Size(30, 16);
            this.lblDeleteCity.TabIndex = 28;
            this.lblDeleteCity.Text = "City";
            this.lblDeleteCity.Click += new System.EventHandler(this.lblDeleteCity_Click);
            // 
            // lblDeleteEmail
            // 
            this.lblDeleteEmail.AutoSize = true;
            this.lblDeleteEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeleteEmail.Location = new System.Drawing.Point(119, 138);
            this.lblDeleteEmail.Name = "lblDeleteEmail";
            this.lblDeleteEmail.Size = new System.Drawing.Size(96, 16);
            this.lblDeleteEmail.TabIndex = 27;
            this.lblDeleteEmail.Text = "Email Address";
            this.lblDeleteEmail.Click += new System.EventHandler(this.lblDeleteEmail_Click);
            // 
            // lblDeleteName
            // 
            this.lblDeleteName.AutoSize = true;
            this.lblDeleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeleteName.Location = new System.Drawing.Point(119, 94);
            this.lblDeleteName.Name = "lblDeleteName";
            this.lblDeleteName.Size = new System.Drawing.Size(65, 16);
            this.lblDeleteName.TabIndex = 26;
            this.lblDeleteName.Text = "Person Id";
            this.lblDeleteName.Click += new System.EventHandler(this.lblDeleteName_Click);
            // 
            // PersonDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDeleteAddedBy);
            this.Controls.Add(this.lblDeleteAddedBy);
            this.Controls.Add(this.lblDeletePerson);
            this.Controls.Add(this.btnDeleteCancel);
            this.Controls.Add(this.btnDeleteSave);
            this.Controls.Add(this.cmbDeleteCountry);
            this.Controls.Add(this.cmbDeleteCity);
            this.Controls.Add(this.txtDeleteEmail);
            this.Controls.Add(this.txtDeleteName);
            this.Controls.Add(this.lblDeleteCountry);
            this.Controls.Add(this.lblDeleteCity);
            this.Controls.Add(this.lblDeleteEmail);
            this.Controls.Add(this.lblDeleteName);
            this.Name = "PersonDelete";
            this.Text = "PersonDelete";
            this.Load += new System.EventHandler(this.PersonDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeleteAddedBy;
        private System.Windows.Forms.Label lblDeleteAddedBy;
        private System.Windows.Forms.Label lblDeletePerson;
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDeleteSave;
        private System.Windows.Forms.ComboBox cmbDeleteCountry;
        private System.Windows.Forms.ComboBox cmbDeleteCity;
        private System.Windows.Forms.TextBox txtDeleteEmail;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.Label lblDeleteCountry;
        private System.Windows.Forms.Label lblDeleteCity;
        private System.Windows.Forms.Label lblDeleteEmail;
        private System.Windows.Forms.Label lblDeleteName;
    }
}