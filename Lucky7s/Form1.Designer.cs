namespace Lucky7s
{
    partial class frmLucky7s
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLucky7s));
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnSpin = new System.Windows.Forms.Button();
            this.cmdAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picPenny = new System.Windows.Forms.PictureBox();
            this.picCoins = new System.Windows.Forms.PictureBox();
            this.picMoney = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPenny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(72, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(346, 80);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "\"Spin to Win!\"";
            // 
            // lblNumber1
            // 
            this.lblNumber1.BackColor = System.Drawing.Color.White;
            this.lblNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber1.Font = new System.Drawing.Font("Myanmar Text", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(12, 98);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(150, 150);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber2
            // 
            this.lblNumber2.BackColor = System.Drawing.Color.White;
            this.lblNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber2.Font = new System.Drawing.Font("Myanmar Text", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(168, 98);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(150, 150);
            this.lblNumber2.TabIndex = 2;
            this.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber3
            // 
            this.lblNumber3.BackColor = System.Drawing.Color.White;
            this.lblNumber3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber3.Font = new System.Drawing.Font("Myanmar Text", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber3.Location = new System.Drawing.Point(324, 98);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(150, 150);
            this.lblNumber3.TabIndex = 3;
            this.lblNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(12, 260);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(238, 159);
            this.lblResults.TabIndex = 4;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(482, 12);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(64, 32);
            this.btnSpin.TabIndex = 5;
            this.btnSpin.Text = "&Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // cmdAbout
            // 
            this.cmdAbout.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbout.Location = new System.Drawing.Point(482, 50);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(64, 32);
            this.cmdAbout.TabIndex = 6;
            this.cmdAbout.Text = "&About";
            this.cmdAbout.UseVisualStyleBackColor = true;
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(482, 88);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picPenny
            // 
            this.picPenny.Image = ((System.Drawing.Image)(resources.GetObject("picPenny.Image")));
            this.picPenny.Location = new System.Drawing.Point(460, 335);
            this.picPenny.Name = "picPenny";
            this.picPenny.Size = new System.Drawing.Size(86, 84);
            this.picPenny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPenny.TabIndex = 8;
            this.picPenny.TabStop = false;
            this.picPenny.Visible = false;
            // 
            // picCoins
            // 
            this.picCoins.Image = ((System.Drawing.Image)(resources.GetObject("picCoins.Image")));
            this.picCoins.Location = new System.Drawing.Point(460, 335);
            this.picCoins.Name = "picCoins";
            this.picCoins.Size = new System.Drawing.Size(86, 84);
            this.picCoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoins.TabIndex = 9;
            this.picCoins.TabStop = false;
            this.picCoins.Visible = false;
            // 
            // picMoney
            // 
            this.picMoney.Image = ((System.Drawing.Image)(resources.GetObject("picMoney.Image")));
            this.picMoney.Location = new System.Drawing.Point(460, 335);
            this.picMoney.Name = "picMoney";
            this.picMoney.Size = new System.Drawing.Size(86, 84);
            this.picMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMoney.TabIndex = 10;
            this.picMoney.TabStop = false;
            this.picMoney.Visible = false;
            // 
            // frmLucky7s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 427);
            this.Controls.Add(this.picMoney);
            this.Controls.Add(this.picCoins);
            this.Controls.Add(this.picPenny);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmdAbout);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblNumber3);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLucky7s";
            this.Text = "\"Lucky 7s";
            ((System.ComponentModel.ISupportInitialize)(this.picPenny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picPenny;
        private System.Windows.Forms.PictureBox picCoins;
        private System.Windows.Forms.PictureBox picMoney;
    }
}

