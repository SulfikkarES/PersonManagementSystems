namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class CountryEdit
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
            this.lblCEditDescription = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblCountryEditName = new System.Windows.Forms.Label();
            this.txtEditCountryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Location = new System.Drawing.Point(458, 371);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(118, 31);
            this.btnEditCancel.TabIndex = 15;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.Location = new System.Drawing.Point(239, 371);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(118, 32);
            this.btnEditSave.TabIndex = 14;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // rtEditDescription
            // 
            this.rtEditDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtEditDescription.Location = new System.Drawing.Point(239, 197);
            this.rtEditDescription.Name = "rtEditDescription";
            this.rtEditDescription.Size = new System.Drawing.Size(337, 127);
            this.rtEditDescription.TabIndex = 13;
            this.rtEditDescription.Text = "";
            // 
            // txtEditName
            // 
            this.txtEditName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEditName.Location = new System.Drawing.Point(237, 96);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(78, 20);
            this.txtEditName.TabIndex = 12;
            this.txtEditName.TextChanged += new System.EventHandler(this.txtEditName_TextChanged);
            // 
            // lblCEditDescription
            // 
            this.lblCEditDescription.AutoSize = true;
            this.lblCEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEditDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCEditDescription.Location = new System.Drawing.Point(106, 197);
            this.lblCEditDescription.Name = "lblCEditDescription";
            this.lblCEditDescription.Size = new System.Drawing.Size(89, 20);
            this.lblCEditDescription.TabIndex = 11;
            this.lblCEditDescription.Text = "Description";
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditName.Location = new System.Drawing.Point(106, 96);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(82, 20);
            this.lblEditName.TabIndex = 10;
            this.lblEditName.Text = "Country Id";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCaption.Location = new System.Drawing.Point(232, 20);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(344, 39);
            this.lblCaption.TabIndex = 9;
            this.lblCaption.Text = "Edit Country Details";
            // 
            // lblCountryEditName
            // 
            this.lblCountryEditName.AutoSize = true;
            this.lblCountryEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryEditName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCountryEditName.Location = new System.Drawing.Point(107, 145);
            this.lblCountryEditName.Name = "lblCountryEditName";
            this.lblCountryEditName.Size = new System.Drawing.Size(110, 20);
            this.lblCountryEditName.TabIndex = 16;
            this.lblCountryEditName.Text = "Country Name";
            // 
            // txtEditCountryName
            // 
            this.txtEditCountryName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEditCountryName.Location = new System.Drawing.Point(239, 144);
            this.txtEditCountryName.Name = "txtEditCountryName";
            this.txtEditCountryName.Size = new System.Drawing.Size(337, 20);
            this.txtEditCountryName.TabIndex = 17;
            // 
            // CountryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditCountryName);
            this.Controls.Add(this.lblCountryEditName);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.rtEditDescription);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.lblCEditDescription);
            this.Controls.Add(this.lblEditName);
            this.Controls.Add(this.lblCaption);
            this.Name = "CountryEdit";
            this.Text = "countryEdit";
            this.Load += new System.EventHandler(this.CountryEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.RichTextBox rtEditDescription;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblCEditDescription;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblCountryEditName;
        private System.Windows.Forms.TextBox txtEditCountryName;
    }
}