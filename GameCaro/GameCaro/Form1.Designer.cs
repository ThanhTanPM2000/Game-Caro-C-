namespace GameCaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.btnLan = new System.Windows.Forms.Button();
            this.txbLan = new System.Windows.Forms.TextBox();
            this.pcbTimeToEnd = new System.Windows.Forms.ProgressBar();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.ptbCaro = new System.Windows.Forms.PictureBox();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(12, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(538, 538);
            this.pnl1.TabIndex = 0;
            // 
            // pnl2
            // 
            this.pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl2.Controls.Add(this.ptbCaro);
            this.pnl2.Location = new System.Drawing.Point(570, 12);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(271, 311);
            this.pnl2.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl3.Controls.Add(this.btnLan);
            this.pnl3.Controls.Add(this.txbLan);
            this.pnl3.Controls.Add(this.pcbTimeToEnd);
            this.pnl3.Controls.Add(this.ptbAvatar);
            this.pnl3.Controls.Add(this.txbUserName);
            this.pnl3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl3.Location = new System.Drawing.Point(570, 343);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(271, 166);
            this.pnl3.TabIndex = 2;
            // 
            // btnLan
            // 
            this.btnLan.Location = new System.Drawing.Point(36, 95);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(75, 23);
            this.btnLan.TabIndex = 4;
            this.btnLan.Text = "Lan";
            this.btnLan.UseVisualStyleBackColor = true;
            // 
            // txbLan
            // 
            this.txbLan.Location = new System.Drawing.Point(4, 69);
            this.txbLan.Name = "txbLan";
            this.txbLan.Size = new System.Drawing.Size(132, 20);
            this.txbLan.TabIndex = 3;
            // 
            // pcbTimeToEnd
            // 
            this.pcbTimeToEnd.Location = new System.Drawing.Point(3, 39);
            this.pcbTimeToEnd.Name = "pcbTimeToEnd";
            this.pcbTimeToEnd.Size = new System.Drawing.Size(133, 23);
            this.pcbTimeToEnd.TabIndex = 2;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(4, 13);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(133, 20);
            this.txbUserName.TabIndex = 0;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAvatar.Location = new System.Drawing.Point(153, 13);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(115, 114);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 1;
            this.ptbAvatar.TabStop = false;
            // 
            // ptbCaro
            // 
            this.ptbCaro.BackgroundImage = global::GameCaro.Properties.Resources.co_caro_la_gi_1;
            this.ptbCaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbCaro.Location = new System.Drawing.Point(4, 4);
            this.ptbCaro.Name = "ptbCaro";
            this.ptbCaro.Size = new System.Drawing.Size(264, 304);
            this.ptbCaro.TabIndex = 0;
            this.ptbCaro.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 564);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro ";
            this.pnl2.ResumeLayout(false);
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.PictureBox ptbCaro;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.TextBox txbLan;
        private System.Windows.Forms.ProgressBar pcbTimeToEnd;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.TextBox txbUserName;
    }
}

