namespace PacketCrafter
{
    partial class frmMainUI
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
            this.cmdSend = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayload = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDestAddress = new System.Windows.Forms.TextBox();
            this.txtDestPort = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdViewPacket = new System.Windows.Forms.Button();
            this.txtPacket = new System.Windows.Forms.TextBox();
            this.txtHelper = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdSend
            // 
            this.cmdSend.BackColor = System.Drawing.Color.Orange;
            this.cmdSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSend.Location = new System.Drawing.Point(131, 239);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(75, 23);
            this.cmdSend.TabIndex = 0;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = false;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // cmbType
            // 
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "DNS Request",
            "ICMP"});
            this.cmbType.Location = new System.Drawing.Point(145, 97);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(139, 24);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Packet Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payload:";
            // 
            // txtPayload
            // 
            this.txtPayload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayload.Location = new System.Drawing.Point(16, 144);
            this.txtPayload.Multiline = true;
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(268, 74);
            this.txtPayload.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination Port:";
            // 
            // txtDestAddress
            // 
            this.txtDestAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestAddress.Location = new System.Drawing.Point(145, 45);
            this.txtDestAddress.Name = "txtDestAddress";
            this.txtDestAddress.Size = new System.Drawing.Size(139, 22);
            this.txtDestAddress.TabIndex = 7;
            // 
            // txtDestPort
            // 
            this.txtDestPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestPort.Location = new System.Drawing.Point(145, 71);
            this.txtDestPort.Name = "txtDestPort";
            this.txtDestPort.Size = new System.Drawing.Size(139, 22);
            this.txtDestPort.TabIndex = 8;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Orange;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(212, 239);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdViewPacket
            // 
            this.cmdViewPacket.BackColor = System.Drawing.Color.Orange;
            this.cmdViewPacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdViewPacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewPacket.Location = new System.Drawing.Point(50, 239);
            this.cmdViewPacket.Name = "cmdViewPacket";
            this.cmdViewPacket.Size = new System.Drawing.Size(75, 23);
            this.cmdViewPacket.TabIndex = 10;
            this.cmdViewPacket.Text = "View\r";
            this.cmdViewPacket.UseVisualStyleBackColor = false;
            this.cmdViewPacket.Click += new System.EventHandler(this.cmdViewPacket_Click);
            // 
            // txtPacket
            // 
            this.txtPacket.Location = new System.Drawing.Point(16, 275);
            this.txtPacket.Multiline = true;
            this.txtPacket.Name = "txtPacket";
            this.txtPacket.Size = new System.Drawing.Size(268, 73);
            this.txtPacket.TabIndex = 11;
            // 
            // txtHelper
            // 
            this.txtHelper.BackColor = System.Drawing.Color.Orange;
            this.txtHelper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelper.Location = new System.Drawing.Point(3, 12);
            this.txtHelper.Name = "txtHelper";
            this.txtHelper.ReadOnly = true;
            this.txtHelper.Size = new System.Drawing.Size(299, 22);
            this.txtHelper.TabIndex = 13;
            this.txtHelper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 357);
            this.Controls.Add(this.txtHelper);
            this.Controls.Add(this.txtPacket);
            this.Controls.Add(this.cmdViewPacket);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtDestPort);
            this.Controls.Add(this.txtDestAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPayload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmdSend);
            this.Name = "frmMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packet Maker";
            this.Load += new System.EventHandler(this.frmMainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPayload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDestAddress;
        private System.Windows.Forms.TextBox txtDestPort;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdViewPacket;
        private System.Windows.Forms.TextBox txtPacket;
        private System.Windows.Forms.TextBox txtHelper;
    }
}

