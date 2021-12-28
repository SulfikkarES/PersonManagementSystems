namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class CityAdd
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblNme = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtNmae = new System.Windows.Forms.TextBox();
            this.rtDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCountrySelect = new System.Windows.Forms.Label();
            this.cmbCountryName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCaption.Location = new System.Drawing.Point(260, 25);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(288, 39);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "New City Details";
            this.lblCaption.Click += new System.EventHandler(this.lblCaption_Click);
            // 
            // lblNme
            // 
            this.lblNme.AutoSize = true;
            this.lblNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNme.Location = new System.Drawing.Point(162, 153);
            this.lblNme.Name = "lblNme";
            this.lblNme.Size = new System.Drawing.Size(81, 20);
            this.lblNme.TabIndex = 1;
            this.lblNme.Text = "City Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(162, 219);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtNmae
            // 
            this.txtNmae.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNmae.Location = new System.Drawing.Point(328, 153);
            this.txtNmae.Name = "txtNmae";
            this.txtNmae.Size = new System.Drawing.Size(288, 20);
            this.txtNmae.TabIndex = 3;
            // 
            // rtDescription
            // 
            this.rtDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtDescription.Location = new System.Drawing.Point(328, 219);
            this.rtDescription.Name = "rtDescription";
            this.rtDescription.Size = new System.Drawing.Size(288, 128);
            this.rtDescription.TabIndex = 4;
            this.rtDescription.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(329, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(508, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCountrySelect
            // 
            this.lblCountrySelect.AutoSize = true;
            this.lblCountrySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountrySelect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCountrySelect.Location = new System.Drawing.Point(162, 95);
            this.lblCountrySelect.Name = "lblCountrySelect";
            this.lblCountrySelect.Size = new System.Drawing.Size(110, 20);
            this.lblCountrySelect.TabIndex = 7;
            this.lblCountrySelect.Text = "Country Name";
            // 
            // cmbCountryName
            // 
            this.cmbCountryName.FormattingEnabled = true;
            this.cmbCountryName.Location = new System.Drawing.Point(329, 95);
            this.cmbCountryName.Name = "cmbCountryName";
            this.cmbCountryName.Size = new System.Drawing.Size(286, 21);
            this.cmbCountryName.TabIndex = 8;
            // 
            // CityAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCountryName);
            this.Controls.Add(this.lblCountrySelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtDescription);
            this.Controls.Add(this.txtNmae);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNme);
            this.Controls.Add(this.lblCaption);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "CityAdd";
            this.Text = "cityAdd";
            this.Load += new System.EventHandler(this.skillAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblNme;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtNmae;
        private System.Windows.Forms.RichTextBox rtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCountrySelect;
        private System.Windows.Forms.ComboBox cmbCountryName;
    }
}