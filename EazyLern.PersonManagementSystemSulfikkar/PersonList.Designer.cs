namespace EazyLern.PersonManagementSystemSulfikkar
{
    partial class PersonList
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
            this.dgvPersonList = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonList
            // 
            this.dgvPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonList.Location = new System.Drawing.Point(12, 90);
            this.dgvPersonList.Name = "dgvPersonList";
            this.dgvPersonList.Size = new System.Drawing.Size(776, 348);
            this.dgvPersonList.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Location = new System.Drawing.Point(291, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(202, 39);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Person List";
            // 
            // PersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvPersonList);
            this.Name = "PersonList";
            this.Text = "PersonList";
            this.Load += new System.EventHandler(this.PersonList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonList;
        private System.Windows.Forms.Label lblName;
    }
}