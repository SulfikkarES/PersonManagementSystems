namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class CityDelete
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
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDeleteSave = new System.Windows.Forms.Button();
            this.rtDeleteDescription = new System.Windows.Forms.RichTextBox();
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.lblDeleteDescription = new System.Windows.Forms.Label();
            this.lblDeleteName = new System.Windows.Forms.Label();
            this.lblDeleteCityCaption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDeleteCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCancel.Location = new System.Drawing.Point(441, 383);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteCancel.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteCancel.TabIndex = 15;
            this.btnDeleteCancel.Text = "Cancel";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDeleteSave
            // 
            this.btnDeleteSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSave.Location = new System.Drawing.Point(263, 383);
            this.btnDeleteSave.Name = "btnDeleteSave";
            this.btnDeleteSave.Size = new System.Drawing.Size(108, 33);
            this.btnDeleteSave.TabIndex = 14;
            this.btnDeleteSave.Text = "Save";
            this.btnDeleteSave.UseVisualStyleBackColor = true;
            this.btnDeleteSave.Click += new System.EventHandler(this.btnDeleteSave_Click);
            // 
            // rtDeleteDescription
            // 
            this.rtDeleteDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtDeleteDescription.Location = new System.Drawing.Point(263, 192);
            this.rtDeleteDescription.Name = "rtDeleteDescription";
            this.rtDeleteDescription.Size = new System.Drawing.Size(288, 128);
            this.rtDeleteDescription.TabIndex = 13;
            this.rtDeleteDescription.Text = "";
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDeleteName.Location = new System.Drawing.Point(263, 136);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(288, 20);
            this.txtDeleteName.TabIndex = 12;
            // 
            // lblDeleteDescription
            // 
            this.lblDeleteDescription.AutoSize = true;
            this.lblDeleteDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeleteDescription.Location = new System.Drawing.Point(96, 193);
            this.lblDeleteDescription.Name = "lblDeleteDescription";
            this.lblDeleteDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDeleteDescription.TabIndex = 11;
            this.lblDeleteDescription.Text = "Description";
            // 
            // lblDeleteName
            // 
            this.lblDeleteName.AutoSize = true;
            this.lblDeleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeleteName.Location = new System.Drawing.Point(96, 136);
            this.lblDeleteName.Name = "lblDeleteName";
            this.lblDeleteName.Size = new System.Drawing.Size(81, 20);
            this.lblDeleteName.TabIndex = 10;
            this.lblDeleteName.Text = "City Name";
            // 
            // lblDeleteCityCaption
            // 
            this.lblDeleteCityCaption.AutoSize = true;
            this.lblDeleteCityCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCityCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDeleteCityCaption.Location = new System.Drawing.Point(256, 25);
            this.lblDeleteCityCaption.Name = "lblDeleteCityCaption";
            this.lblDeleteCityCaption.Size = new System.Drawing.Size(322, 39);
            this.lblDeleteCityCaption.TabIndex = 9;
            this.lblDeleteCityCaption.Text = "Delete City Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(96, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Country Name";
            // 
            // cmbDeleteCity
            // 
            this.cmbDeleteCity.FormattingEnabled = true;
            this.cmbDeleteCity.Location = new System.Drawing.Point(263, 84);
            this.cmbDeleteCity.Name = "cmbDeleteCity";
            this.cmbDeleteCity.Size = new System.Drawing.Size(287, 21);
            this.cmbDeleteCity.TabIndex = 17;
            this.cmbDeleteCity.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteCity_SelectedIndexChanged);
            // 
            // CityDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDeleteCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteCancel);
            this.Controls.Add(this.btnDeleteSave);
            this.Controls.Add(this.rtDeleteDescription);
            this.Controls.Add(this.txtDeleteName);
            this.Controls.Add(this.lblDeleteDescription);
            this.Controls.Add(this.lblDeleteName);
            this.Controls.Add(this.lblDeleteCityCaption);
            this.Name = "CityDelete";
            this.Text = "CityDelete";
            this.Load += new System.EventHandler(this.CityDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDeleteSave;
        private System.Windows.Forms.RichTextBox rtDeleteDescription;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.Label lblDeleteDescription;
        private System.Windows.Forms.Label lblDeleteName;
        private System.Windows.Forms.Label lblDeleteCityCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDeleteCity;
    }
}