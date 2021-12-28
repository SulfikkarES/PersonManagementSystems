namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class CountryDelete
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
            this.lblCDeleteDescription = new System.Windows.Forms.Label();
            this.lblDeleteName = new System.Windows.Forms.Label();
            this.lblDeleteCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCancel.Location = new System.Drawing.Point(413, 392);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(118, 31);
            this.btnDeleteCancel.TabIndex = 24;
            this.btnDeleteCancel.Text = "Cancel";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDeleteSave
            // 
            this.btnDeleteSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSave.Location = new System.Drawing.Point(239, 391);
            this.btnDeleteSave.Name = "btnDeleteSave";
            this.btnDeleteSave.Size = new System.Drawing.Size(118, 32);
            this.btnDeleteSave.TabIndex = 23;
            this.btnDeleteSave.Text = "Save";
            this.btnDeleteSave.UseVisualStyleBackColor = true;
            this.btnDeleteSave.Click += new System.EventHandler(this.btnDeleteSave_Click);
            // 
            // rtDeleteDescription
            // 
            this.rtDeleteDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtDeleteDescription.Location = new System.Drawing.Point(239, 209);
            this.rtDeleteDescription.Name = "rtDeleteDescription";
            this.rtDeleteDescription.Size = new System.Drawing.Size(294, 127);
            this.rtDeleteDescription.TabIndex = 22;
            this.rtDeleteDescription.Text = "";
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDeleteName.Location = new System.Drawing.Point(239, 135);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(294, 20);
            this.txtDeleteName.TabIndex = 21;
            this.txtDeleteName.TextChanged += new System.EventHandler(this.txtDeleteName_TextChanged);
            // 
            // lblCDeleteDescription
            // 
            this.lblCDeleteDescription.AutoSize = true;
            this.lblCDeleteDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDeleteDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCDeleteDescription.Location = new System.Drawing.Point(106, 209);
            this.lblCDeleteDescription.Name = "lblCDeleteDescription";
            this.lblCDeleteDescription.Size = new System.Drawing.Size(89, 20);
            this.lblCDeleteDescription.TabIndex = 20;
            this.lblCDeleteDescription.Text = "Description";
            // 
            // lblDeleteName
            // 
            this.lblDeleteName.AutoSize = true;
            this.lblDeleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeleteName.Location = new System.Drawing.Point(107, 139);
            this.lblDeleteName.Name = "lblDeleteName";
            this.lblDeleteName.Size = new System.Drawing.Size(82, 20);
            this.lblDeleteName.TabIndex = 19;
            this.lblDeleteName.Text = "Country Id";
            // 
            // lblDeleteCaption
            // 
            this.lblDeleteCaption.AutoSize = true;
            this.lblDeleteCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDeleteCaption.Location = new System.Drawing.Point(205, 23);
            this.lblDeleteCaption.Name = "lblDeleteCaption";
            this.lblDeleteCaption.Size = new System.Drawing.Size(386, 39);
            this.lblDeleteCaption.TabIndex = 18;
            this.lblDeleteCaption.Text = "Delete Country Details";
            // 
            // CountryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteCancel);
            this.Controls.Add(this.btnDeleteSave);
            this.Controls.Add(this.rtDeleteDescription);
            this.Controls.Add(this.txtDeleteName);
            this.Controls.Add(this.lblCDeleteDescription);
            this.Controls.Add(this.lblDeleteName);
            this.Controls.Add(this.lblDeleteCaption);
            this.Name = "CountryDelete";
            this.Text = "countryDelete";
            this.Load += new System.EventHandler(this.countryDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDeleteSave;
        private System.Windows.Forms.RichTextBox rtDeleteDescription;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.Label lblCDeleteDescription;
        private System.Windows.Forms.Label lblDeleteName;
        private System.Windows.Forms.Label lblDeleteCaption;
    }
}