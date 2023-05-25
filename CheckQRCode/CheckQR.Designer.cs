namespace CheckQRCode
{
    partial class CheckQR
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
            this.components = new System.ComponentModel.Container();
            this.lbl_CSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_CodeCheckSheet = new System.Windows.Forms.TextBox();
            this.txb_CodeLen = new System.Windows.Forms.TextBox();
            this.timerendcheck = new System.Windows.Forms.Timer(this.components);
            this.CheckRecivedBarcode = new System.Windows.Forms.Timer(this.components);
            this.TimerCheckEnd = new System.Windows.Forms.Timer(this.components);
            this.timesearch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_CSV
            // 
            this.lbl_CSV.AutoSize = true;
            this.lbl_CSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CSV.Location = new System.Drawing.Point(186, 9);
            this.lbl_CSV.Name = "lbl_CSV";
            this.lbl_CSV.Size = new System.Drawing.Size(61, 17);
            this.lbl_CSV.TabIndex = 7;
            this.lbl_CSV.Text = "Mã CSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quét QR trên Checksheet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quét QR trên Ống kính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "QR đọc từ mạch chính";
            // 
            // Txb_CodeCheckSheet
            // 
            this.Txb_CodeCheckSheet.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_CodeCheckSheet.Location = new System.Drawing.Point(183, 83);
            this.Txb_CodeCheckSheet.Name = "Txb_CodeCheckSheet";
            this.Txb_CodeCheckSheet.ReadOnly = true;
            this.Txb_CodeCheckSheet.ShortcutsEnabled = false;
            this.Txb_CodeCheckSheet.Size = new System.Drawing.Size(205, 24);
            this.Txb_CodeCheckSheet.TabIndex = 9;
            // 
            // txb_CodeLen
            // 
            this.txb_CodeLen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CodeLen.Location = new System.Drawing.Point(183, 42);
            this.txb_CodeLen.Name = "txb_CodeLen";
            this.txb_CodeLen.ReadOnly = true;
            this.txb_CodeLen.ShortcutsEnabled = false;
            this.txb_CodeLen.Size = new System.Drawing.Size(205, 24);
            this.txb_CodeLen.TabIndex = 8;
            // 
            // timerendcheck
            // 
            this.timerendcheck.Interval = 2000;
            this.timerendcheck.Tick += new System.EventHandler(this.Endcheck_Tick);
            // 
            // CheckRecivedBarcode
            // 
            this.CheckRecivedBarcode.Interval = 500;
            this.CheckRecivedBarcode.Tick += new System.EventHandler(this.CheckRecivedBarcode_Tick);
            // 
            // TimerCheckEnd
            // 
            this.TimerCheckEnd.Interval = 30000;
            this.TimerCheckEnd.Tick += new System.EventHandler(this.TimerCheckEnd_Tick);
            // 
            // timesearch
            // 
            this.timesearch.Interval = 2000;
            this.timesearch.Tick += new System.EventHandler(this.timesearch_Tick);
            // 
            // CheckQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(397, 125);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_CSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_CodeCheckSheet);
            this.Controls.Add(this.txb_CodeLen);
            this.Name = "CheckQR";
            this.Text = "CheckQR";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckQR_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_CodeCheckSheet;
        private System.Windows.Forms.TextBox txb_CodeLen;
        private System.Windows.Forms.Timer timerendcheck;
        private System.Windows.Forms.Timer CheckRecivedBarcode;
        private System.Windows.Forms.Timer TimerCheckEnd;
        private System.Windows.Forms.Timer timesearch;
    }
}