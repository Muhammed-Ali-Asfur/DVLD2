namespace DVLD.People
{
    partial class frmSendEmail
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPerosnName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPersonEmail = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.txtEmailMessage = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.sendMail;
            this.pictureBox1.Location = new System.Drawing.Point(229, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perosn Name:";
            // 
            // lbPerosnName
            // 
            this.lbPerosnName.AutoSize = true;
            this.lbPerosnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerosnName.Location = new System.Drawing.Point(213, 218);
            this.lbPerosnName.Name = "lbPerosnName";
            this.lbPerosnName.Size = new System.Drawing.Size(49, 29);
            this.lbPerosnName.TabIndex = 2;
            this.lbPerosnName.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Person Email : ";
            // 
            // lbPersonEmail
            // 
            this.lbPersonEmail.AutoSize = true;
            this.lbPersonEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonEmail.Location = new System.Drawing.Point(213, 285);
            this.lbPersonEmail.Name = "lbPersonEmail";
            this.lbPersonEmail.Size = new System.Drawing.Size(49, 29);
            this.lbPersonEmail.TabIndex = 4;
            this.lbPersonEmail.Text = "???";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(22, 343);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(185, 29);
            this.lb.TabIndex = 5;
            this.lb.Text = "Email Message:";
            // 
            // txtEmailMessage
            // 
            this.txtEmailMessage.Location = new System.Drawing.Point(213, 352);
            this.txtEmailMessage.Multiline = true;
            this.txtEmailMessage.Name = "txtEmailMessage";
            this.txtEmailMessage.Size = new System.Drawing.Size(227, 90);
            this.txtEmailMessage.TabIndex = 6;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Location = new System.Drawing.Point(499, 375);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(134, 54);
            this.btnSendEmail.TabIndex = 7;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // frmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 473);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.txtEmailMessage);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbPersonEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPerosnName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSendEmail";
            this.Text = "frmSendEmail";
            this.Load += new System.EventHandler(this.frmSendEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPerosnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPersonEmail;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtEmailMessage;
        private System.Windows.Forms.Button btnSendEmail;
    }
}