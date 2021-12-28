namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class PersonAdd
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
            this.lblNewPerson = new System.Windows.Forms.Label();
            this.btnNewCancel = new System.Windows.Forms.Button();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.cmbNewCountryy = new System.Windows.Forms.ComboBox();
            this.cmbNewCity = new System.Windows.Forms.ComboBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblCountryCountry = new System.Windows.Forms.Label();
            this.lblNewCity = new System.Windows.Forms.Label();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDeleteAddedBy
            // 
            this.txtDeleteAddedBy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDeleteAddedBy.Location = new System.Drawing.Point(303, 317);
            this.txtDeleteAddedBy.Name = "txtDeleteAddedBy";
            this.txtDeleteAddedBy.Size = new System.Drawing.Size(263, 20);
            this.txtDeleteAddedBy.TabIndex = 51;
            this.txtDeleteAddedBy.UseWaitCursor = true;
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
            this.lblDeleteAddedBy.TabIndex = 50;
            this.lblDeleteAddedBy.Text = "Added By";
            this.lblDeleteAddedBy.UseWaitCursor = true;
            this.lblDeleteAddedBy.Click += new System.EventHandler(this.lblDeleteAddedBy_Click);
            // 
            // lblNewPerson
            // 
            this.lblNewPerson.AutoSize = true;
            this.lblNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPerson.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNewPerson.Location = new System.Drawing.Point(245, 22);
            this.lblNewPerson.Name = "lblNewPerson";
            this.lblNewPerson.Size = new System.Drawing.Size(339, 39);
            this.lblNewPerson.TabIndex = 49;
            this.lblNewPerson.Text = "New Person Details";
            this.lblNewPerson.UseWaitCursor = true;
            this.lblNewPerson.Click += new System.EventHandler(this.lblNewPerson_Click);
            // 
            // btnNewCancel
            // 
            this.btnNewCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCancel.Location = new System.Drawing.Point(478, 393);
            this.btnNewCancel.Name = "btnNewCancel";
            this.btnNewCancel.Size = new System.Drawing.Size(88, 36);
            this.btnNewCancel.TabIndex = 48;
            this.btnNewCancel.Text = "Cancel";
            this.btnNewCancel.UseVisualStyleBackColor = true;
            this.btnNewCancel.UseWaitCursor = true;
            this.btnNewCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnNewSave
            // 
            this.btnNewSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSave.Location = new System.Drawing.Point(303, 393);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(94, 36);
            this.btnNewSave.TabIndex = 47;
            this.btnNewSave.Text = "Save";
            this.btnNewSave.UseVisualStyleBackColor = true;
            this.btnNewSave.UseWaitCursor = true;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // cmbNewCountryy
            // 
            this.cmbNewCountryy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbNewCountryy.FormattingEnabled = true;
            this.cmbNewCountryy.Items.AddRange(new object[] {
            "Select Country"});
            this.cmbNewCountryy.Location = new System.Drawing.Point(303, 206);
            this.cmbNewCountryy.Name = "cmbNewCountryy";
            this.cmbNewCountryy.Size = new System.Drawing.Size(263, 21);
            this.cmbNewCountryy.TabIndex = 46;
            this.cmbNewCountryy.Text = "Select Country";
            this.cmbNewCountryy.SelectedIndexChanged += new System.EventHandler(this.cmbNewCountryy_SelectedIndexChanged);
            // 
            // cmbNewCity
            // 
            this.cmbNewCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbNewCity.FormattingEnabled = true;
            this.cmbNewCity.Items.AddRange(new object[] {
            "Select City"});
            this.cmbNewCity.Location = new System.Drawing.Point(303, 260);
            this.cmbNewCity.Name = "cmbNewCity";
            this.cmbNewCity.Size = new System.Drawing.Size(263, 21);
            this.cmbNewCity.TabIndex = 45;
            this.cmbNewCity.Text = "Select City";
            this.cmbNewCity.UseWaitCursor = true;
            this.cmbNewCity.SelectedIndexChanged += new System.EventHandler(this.cmbNewCity_SelectedIndexChanged);
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNewEmail.Location = new System.Drawing.Point(303, 138);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(379, 20);
            this.txtNewEmail.TabIndex = 44;
            this.txtNewEmail.UseWaitCursor = true;
            this.txtNewEmail.TextChanged += new System.EventHandler(this.txtNewEmail_TextChanged);
            // 
            // txtNewName
            // 
            this.txtNewName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNewName.Location = new System.Drawing.Point(303, 90);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(263, 20);
            this.txtNewName.TabIndex = 43;
            this.txtNewName.UseWaitCursor = true;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // lblCountryCountry
            // 
            this.lblCountryCountry.AutoSize = true;
            this.lblCountryCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryCountry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCountryCountry.Location = new System.Drawing.Point(119, 211);
            this.lblCountryCountry.Name = "lblCountryCountry";
            this.lblCountryCountry.Size = new System.Drawing.Size(53, 16);
            this.lblCountryCountry.TabIndex = 42;
            this.lblCountryCountry.Text = "Country";
            this.lblCountryCountry.UseWaitCursor = true;
            this.lblCountryCountry.Click += new System.EventHandler(this.lblCountryCountry_Click);
            // 
            // lblNewCity
            // 
            this.lblNewCity.AutoSize = true;
            this.lblNewCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewCity.Location = new System.Drawing.Point(119, 265);
            this.lblNewCity.Name = "lblNewCity";
            this.lblNewCity.Size = new System.Drawing.Size(30, 16);
            this.lblNewCity.TabIndex = 41;
            this.lblNewCity.Text = "City";
            this.lblNewCity.UseWaitCursor = true;
            this.lblNewCity.Click += new System.EventHandler(this.lblNewCity_Click);
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.AutoSize = true;
            this.lblNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewEmail.Location = new System.Drawing.Point(119, 138);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(96, 16);
            this.lblNewEmail.TabIndex = 40;
            this.lblNewEmail.Text = "Email Address";
            this.lblNewEmail.UseWaitCursor = true;
            this.lblNewEmail.Click += new System.EventHandler(this.lblNewEmail_Click);
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewName.Location = new System.Drawing.Point(119, 94);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(91, 16);
            this.lblNewName.TabIndex = 39;
            this.lblNewName.Text = "Person Name";
            this.lblNewName.UseWaitCursor = true;
            this.lblNewName.Click += new System.EventHandler(this.lblNewName_Click);
            // 
            // PersonAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDeleteAddedBy);
            this.Controls.Add(this.lblDeleteAddedBy);
            this.Controls.Add(this.lblNewPerson);
            this.Controls.Add(this.btnNewCancel);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.cmbNewCountryy);
            this.Controls.Add(this.cmbNewCity);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblCountryCountry);
            this.Controls.Add(this.lblNewCity);
            this.Controls.Add(this.lblNewEmail);
            this.Controls.Add(this.lblNewName);
            this.Name = "PersonAdd";
            this.Text = "PersonAdd";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.PersonAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeleteAddedBy;
        private System.Windows.Forms.Label lblDeleteAddedBy;
        private System.Windows.Forms.Label lblNewPerson;
        private System.Windows.Forms.Button btnNewCancel;
        private System.Windows.Forms.Button btnNewSave;
        private System.Windows.Forms.ComboBox cmbNewCountryy;
        private System.Windows.Forms.ComboBox cmbNewCity;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblCountryCountry;
        private System.Windows.Forms.Label lblNewCity;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.Label lblNewName;
    }
}