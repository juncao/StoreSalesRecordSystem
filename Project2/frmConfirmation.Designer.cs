namespace Project2
{
    partial class frmConfirmation
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(98, 164);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(90, 23);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirmed";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(174, 193);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel Order";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(24, 193);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(90, 23);
            this.modifyButton.TabIndex = 6;
            this.modifyButton.Text = "Modify Order";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(21, 46);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message";
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.lblMessage);
            this.Name = "frmConfirmation";
            this.Text = "frmConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Label lblMessage;
    }
}