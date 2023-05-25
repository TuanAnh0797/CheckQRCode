namespace CheckQRCode
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
            this.fileSystemWatcherCheckQR = new System.IO.FileSystemWatcher();
            this.btn_measure = new System.Windows.Forms.Button();
            this.dtg_listerror = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherCheckQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listerror)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcherCheckQR
            // 
            this.fileSystemWatcherCheckQR.EnableRaisingEvents = true;
            this.fileSystemWatcherCheckQR.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fileSystemWatcherCheckQR.SynchronizingObject = this;
            this.fileSystemWatcherCheckQR.Created += new System.IO.FileSystemEventHandler(this.FileSystemWatcherCheckQR_Created);
            // 
            // btn_measure
            // 
            this.btn_measure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_measure.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_measure.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_measure.Location = new System.Drawing.Point(138, 12);
            this.btn_measure.Name = "btn_measure";
            this.btn_measure.Size = new System.Drawing.Size(122, 65);
            this.btn_measure.TabIndex = 0;
            this.btn_measure.Text = "Measure";
            this.btn_measure.UseVisualStyleBackColor = false;
            this.btn_measure.Click += new System.EventHandler(this.Btn_measure_Click);
            // 
            // dtg_listerror
            // 
            this.dtg_listerror.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_listerror.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listerror.Location = new System.Drawing.Point(9, 83);
            this.dtg_listerror.Name = "dtg_listerror";
            this.dtg_listerror.ReadOnly = true;
            this.dtg_listerror.Size = new System.Drawing.Size(256, 196);
            this.dtg_listerror.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 284);
            this.Controls.Add(this.dtg_listerror);
            this.Controls.Add(this.btn_measure);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherCheckQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listerror)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcherCheckQR;
        private System.Windows.Forms.DataGridView dtg_listerror;
        private System.Windows.Forms.Button btn_measure;
    }
}

