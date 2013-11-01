namespace Project2
{
    partial class frmCategories
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
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.lblCategoriesInfo = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.pnlCateInfo = new System.Windows.Forms.Panel();
            this.btnDeleteUploadedPicture = new System.Windows.Forms.Button();
            this.btnUploadNewPicture = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlCateTop = new System.Windows.Forms.Panel();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.pnlCateInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCateTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(118, 33);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(211, 20);
            this.txtCategoryID.TabIndex = 0;
            // 
            // picPicture
            // 
            this.picPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPicture.Location = new System.Drawing.Point(118, 164);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(211, 131);
            this.picPicture.TabIndex = 7;
            this.picPicture.TabStop = false;
            // 
            // lblCategoriesInfo
            // 
            this.lblCategoriesInfo.AutoSize = true;
            this.lblCategoriesInfo.Location = new System.Drawing.Point(137, 15);
            this.lblCategoriesInfo.Name = "lblCategoriesInfo";
            this.lblCategoriesInfo.Size = new System.Drawing.Size(104, 13);
            this.lblCategoriesInfo.TabIndex = 0;
            this.lblCategoriesInfo.Text = "Categorie Infomation";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(23, 36);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(60, 13);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "CategoryID";
            // 
            // pnlCateInfo
            // 
            this.pnlCateInfo.Controls.Add(this.lblWarningMessage);
            this.pnlCateInfo.Controls.Add(this.btnDeleteUploadedPicture);
            this.pnlCateInfo.Controls.Add(this.btnUploadNewPicture);
            this.pnlCateInfo.Controls.Add(this.panel2);
            this.pnlCateInfo.Controls.Add(this.lblCategoryID);
            this.pnlCateInfo.Controls.Add(this.txtCategoryID);
            this.pnlCateInfo.Controls.Add(this.lblCategoryName);
            this.pnlCateInfo.Controls.Add(this.picPicture);
            this.pnlCateInfo.Controls.Add(this.txtDescription);
            this.pnlCateInfo.Controls.Add(this.txtCategoryName);
            this.pnlCateInfo.Controls.Add(this.lblPicture);
            this.pnlCateInfo.Controls.Add(this.lblDescription);
            this.pnlCateInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCateInfo.Location = new System.Drawing.Point(0, 38);
            this.pnlCateInfo.Name = "pnlCateInfo";
            this.pnlCateInfo.Size = new System.Drawing.Size(442, 431);
            this.pnlCateInfo.TabIndex = 12;
            // 
            // btnDeleteUploadedPicture
            // 
            this.btnDeleteUploadedPicture.Enabled = false;
            this.btnDeleteUploadedPicture.Location = new System.Drawing.Point(237, 301);
            this.btnDeleteUploadedPicture.Name = "btnDeleteUploadedPicture";
            this.btnDeleteUploadedPicture.Size = new System.Drawing.Size(132, 23);
            this.btnDeleteUploadedPicture.TabIndex = 4;
            this.btnDeleteUploadedPicture.Text = "Delete Uploaded Picture";
            this.btnDeleteUploadedPicture.UseVisualStyleBackColor = true;
            this.btnDeleteUploadedPicture.Click += new System.EventHandler(this.btnDeleteUploadedPicture_Click);
            // 
            // btnUploadNewPicture
            // 
            this.btnUploadNewPicture.Location = new System.Drawing.Point(65, 301);
            this.btnUploadNewPicture.Name = "btnUploadNewPicture";
            this.btnUploadNewPicture.Size = new System.Drawing.Size(124, 23);
            this.btnUploadNewPicture.TabIndex = 3;
            this.btnUploadNewPicture.Text = "Upload New Picture";
            this.btnUploadNewPicture.UseVisualStyleBackColor = true;
            this.btnUploadNewPicture.Click += new System.EventHandler(this.btnUploadNewPicture_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(26, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 56);
            this.panel2.TabIndex = 10;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(39, 15);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(268, 15);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(23, 82);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(77, 13);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "CategoryName";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(118, 117);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(211, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(118, 79);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(211, 20);
            this.txtCategoryName.TabIndex = 1;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(23, 164);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(40, 13);
            this.lblPicture.TabIndex = 3;
            this.lblPicture.Text = "Picture";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 124);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // pnlCateTop
            // 
            this.pnlCateTop.Controls.Add(this.lblCategoriesInfo);
            this.pnlCateTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCateTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCateTop.Name = "pnlCateTop";
            this.pnlCateTop.Size = new System.Drawing.Size(442, 38);
            this.pnlCateTop.TabIndex = 11;
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWarningMessage.Location = new System.Drawing.Point(118, 344);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(0, 13);
            this.lblWarningMessage.TabIndex = 11;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 469);
            this.Controls.Add(this.pnlCateInfo);
            this.Controls.Add(this.pnlCateTop);
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.pnlCateInfo.ResumeLayout(false);
            this.pnlCateInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlCateTop.ResumeLayout(false);
            this.pnlCateTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.Label lblCategoriesInfo;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Panel pnlCateInfo;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlCateTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnUploadNewPicture;
        private System.Windows.Forms.Button btnDeleteUploadedPicture;
        private System.Windows.Forms.Label lblWarningMessage;
    }
}