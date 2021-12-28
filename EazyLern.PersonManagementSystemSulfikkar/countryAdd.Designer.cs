namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class CountryAdd
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
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCaption.Location = new System.Drawing.Point(259, 25);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(270, 39);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Country Details";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCName.Location = new System.Drawing.Point(180, 108);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(51, 20);
            this.lblCName.TabIndex = 1;
            this.lblCName.Text = "Name";
            // 
            // lblCDescription
            // 
            this.lblCDescription.AutoSize = true;
            this.lblCDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCDescription.Location = new System.Drawing.Point(179, 178);
            this.lblCDescription.Name = "lblCDescription";
            this.lblCDescription.Size = new System.Drawing.Size(89, 20);
            this.lblCDescription.TabIndex = 2;
            this.lblCDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtName.Location = new System.Drawing.Point(312, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 20);
            this.txtName.TabIndex = 3;
            // 
            // rtDescription
            // 
            this.rtDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtDescription.Location = new System.Drawing.Point(312, 178);
            this.rtDescription.Name = "rtDescription";
            this.rtDescription.Size = new System.Drawing.Size(294, 127);
            this.rtDescription.TabIndex = 4;
            this.rtDescription.Text = "";
            this.rtDescription.TextChanged += new System.EventHandler(this.rtDescription_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(312, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(487, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CountryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCDescription);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblCaption);
            this.Name = "CountryAdd";
            this.Text = "countryAdd";
            this.Load += new System.EventHandler(this.countryAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}