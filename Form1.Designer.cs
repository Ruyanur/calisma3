namespace cilentform
{
    partial class Form1
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
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnRequestSession = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSessionTime = new System.Windows.Forms.TextBox();
            this.lstMessageLog = new System.Windows.Forms.ListBox();
            this.lblPermission = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(536, 53);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "button1";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // btnRequestSession
            // 
            this.btnRequestSession.Location = new System.Drawing.Point(536, 83);
            this.btnRequestSession.Name = "btnRequestSession";
            this.btnRequestSession.Size = new System.Drawing.Size(75, 23);
            this.btnRequestSession.TabIndex = 1;
            this.btnRequestSession.Text = "button2";
            this.btnRequestSession.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(316, 37);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 2;
            // 
            // txtSessionTime
            // 
            this.txtSessionTime.Location = new System.Drawing.Point(316, 85);
            this.txtSessionTime.Name = "txtSessionTime";
            this.txtSessionTime.Size = new System.Drawing.Size(100, 20);
            this.txtSessionTime.TabIndex = 3;
            // 
            // lstMessageLog
            // 
            this.lstMessageLog.FormattingEnabled = true;
            this.lstMessageLog.Location = new System.Drawing.Point(88, 53);
            this.lstMessageLog.Name = "lstMessageLog";
            this.lstMessageLog.Size = new System.Drawing.Size(120, 95);
            this.lstMessageLog.TabIndex = 4;
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.Location = new System.Drawing.Point(131, 207);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(35, 13);
            this.lblPermission.TabIndex = 5;
            this.lblPermission.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPermission);
            this.Controls.Add(this.lstMessageLog);
            this.Controls.Add(this.txtSessionTime);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnRequestSession);
            this.Controls.Add(this.btnSendMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnRequestSession;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSessionTime;
        private System.Windows.Forms.ListBox lstMessageLog;
        private System.Windows.Forms.Label lblPermission;
    }
}

