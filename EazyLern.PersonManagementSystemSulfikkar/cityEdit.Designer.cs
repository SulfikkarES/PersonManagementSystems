namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class CityEdit
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
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.rtEditDescription = new System.Windows.Forms.RichTextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditDescription = new System.Windows.Forms.Label();
            this.lblEditCityName = new System.Windows.Forms.Label();
            this.lbEditCitylCaption = new System.Windows.Forms.Label();
            this.lblEditCountryName = new System.Windows.Forms.Label();
            this.cmbCountryDetails = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Location = new System.Drawing.Point(441, 373);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditCancel.Size = new System.Drawing.Size(108, 34);
            this.btnEditCancel.TabIndex = 15;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.Location = new System.Drawing.Point(263, 373);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(108, 33);
            this.btnEditSave.TabIndex = 14;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // rtEditDescription
            // 
            this.rtEditDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtEditDescription.Location = new System.Drawing.Point(263, 192);
            this.rtEditDescription.Name = "rtEditDescription";
            this.rtEditDescription.Size = new System.Drawing.Size(288, 128);
            this.rtEditDescription.TabIndex = 13;
            this.rtEditDescription.Text = "";
            // 
            // txtEditName
            // 
            this.txtEditName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEditName.Location = new System.Drawing.Point(263, 118);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(288, 20);
            this.txtEditName.TabIndex = 12;
            // 
            // lblEditDescription
            // 
            this.lblEditDescription.AutoSize = true;
            this.lblEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditDescription.Location = new System.Drawing.Point(96, 193);
            this.lblEditDescription.Name = "lblEditDescription";
            this.lblEditDescription.Size = new System.Drawing.Size(89, 20);
            this.lblEditDescription.TabIndex = 11;
            this.lblEditDescription.Text = "Description";
            // 
            // lblEditCityName
            // 
            this.lblEditCityName.AutoSize = true;
            this.lblEditCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCityName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditCityName.Location = new System.Drawing.Point(96, 118);
            this.lblEditCityName.Name = "lblEditCityName";
            this.lblEditCityName.Size = new System.Drawing.Size(81, 20);
            this.lblEditCityName.TabIndex = 10;
            this.lblEditCityName.Text = "City Name";
            // 
            // lbEditCitylCaption
            // 
            this.lbEditCitylCaption.AutoSize = true;
            this.lbEditCitylCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditCitylCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbEditCitylCaption.Location = new System.Drawing.Point(256, 9);
            this.lbEditCitylCaption.Name = "lbEditCitylCaption";
            this.lbEditCitylCaption.Size = new System.Drawing.Size(280, 39);
            this.lbEditCitylCaption.TabIndex = 9;
            this.lbEditCitylCaption.Text = "Edit City Details";
            // 
            // lblEditCountryName
            // 
            this.lblEditCountryName.AutoSize = true;
            this.lblEditCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCountryName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditCountryName.Location = new System.Drawing.Point(96, 68);
            this.lblEditCountryName.Name = "lblEditCountryName";
            this.lblEditCountryName.Size = new System.Drawing.Size(114, 20);
            this.lblEditCountryName.TabIndex = 16;
            this.lblEditCountryName.Text = "Country  Name";
            this.lblEditCountryName.Click += new System.EventHandler(this.lblEditCountryName_Click);
            // 
            // cmbCountryDetails
            // 
            this.cmbCountryDetails.FormattingEnabled = true;
            this.cmbCountryDetails.Location = new System.Drawing.Point(263, 70);
            this.cmbCountryDetails.Name = "cmbCountryDetails";
            this.cmbCountryDetails.Size = new System.Drawing.Size(286, 21);
            this.cmbCountryDetails.TabIndex = 17;
            // 
            // CityEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCountryDetails);
            this.Controls.Add(this.lblEditCountryName);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.rtEditDescription);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.lblEditDescription);
            this.Controls.Add(this.lblEditCityName);
            this.Controls.Add(this.lbEditCitylCaption);
            this.Name = "CityEdit";
            this.Text = "cityEdit";
            this.Load += new System.EventHandler(this.cityEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.RichTextBox rtEditDescription;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditDescription;
        private System.Windows.Forms.Label lblEditCityName;
        private System.Windows.Forms.Label lbEditCitylCaption;
        private System.Windows.Forms.Label lblEditCountryName;
        private System.Windows.Forms.ComboBox cmbCountryDetails;
    }
}