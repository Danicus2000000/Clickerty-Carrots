namespace Clickerty_Carrots
{
    partial class Clickerty_Carrots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clickerty_Carrots));
            this.plot_img = new System.Windows.Forms.PictureBox();
            this.currentmoney_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.shop_btn = new System.Windows.Forms.Button();
            this.watercan_img = new System.Windows.Forms.PictureBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.inspiration_lbl = new System.Windows.Forms.Label();
            this.fertilizer_img = new System.Windows.Forms.PictureBox();
            this.heart_img = new System.Windows.Forms.PictureBox();
            this.shrooms_img = new System.Windows.Forms.PictureBox();
            this.ending_btn = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Timer(this.components);
            this.men_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plot_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watercan_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizer_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrooms_img)).BeginInit();
            this.SuspendLayout();
            // 
            // plot_img
            // 
            this.plot_img.ImageLocation = "E:\\C# Projects\\Clickerty Carrots\\Clickerty Carrots\\bin\\Debug\\plotlvl1.png";
            this.plot_img.Location = new System.Drawing.Point(375, 295);
            this.plot_img.Name = "plot_img";
            this.plot_img.Size = new System.Drawing.Size(288, 222);
            this.plot_img.TabIndex = 0;
            this.plot_img.TabStop = false;
            this.plot_img.Click += new System.EventHandler(this.plot_img_Click);
            // 
            // currentmoney_lbl
            // 
            this.currentmoney_lbl.AutoSize = true;
            this.currentmoney_lbl.Location = new System.Drawing.Point(465, 143);
            this.currentmoney_lbl.Name = "currentmoney_lbl";
            this.currentmoney_lbl.Size = new System.Drawing.Size(107, 13);
            this.currentmoney_lbl.TabIndex = 1;
            this.currentmoney_lbl.Text = "Carrots Clicked Up: 0";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.close_btn.Location = new System.Drawing.Point(450, -1);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(87, 41);
            this.close_btn.TabIndex = 2;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // shop_btn
            // 
            this.shop_btn.BackColor = System.Drawing.Color.Fuchsia;
            this.shop_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.shop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shop_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.shop_btn.Location = new System.Drawing.Point(468, 523);
            this.shop_btn.Name = "shop_btn";
            this.shop_btn.Size = new System.Drawing.Size(87, 30);
            this.shop_btn.TabIndex = 3;
            this.shop_btn.Text = "Shop";
            this.shop_btn.UseVisualStyleBackColor = false;
            this.shop_btn.Click += new System.EventHandler(this.shop_btn_Click);
            // 
            // watercan_img
            // 
            this.watercan_img.Enabled = false;
            this.watercan_img.ImageLocation = "E:\\C# Projects\\Clickerty Carrots\\Clickerty Carrots\\bin\\Debug\\watercan.png";
            this.watercan_img.Location = new System.Drawing.Point(304, 435);
            this.watercan_img.Name = "watercan_img";
            this.watercan_img.Size = new System.Drawing.Size(65, 54);
            this.watercan_img.TabIndex = 4;
            this.watercan_img.TabStop = false;
            this.watercan_img.Visible = false;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(-11, -1);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(349, 50);
            this.title_lbl.TabIndex = 5;
            this.title_lbl.Text = "Clickerty Carrots";
            // 
            // inspiration_lbl
            // 
            this.inspiration_lbl.AutoSize = true;
            this.inspiration_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspiration_lbl.Location = new System.Drawing.Point(738, 101);
            this.inspiration_lbl.Name = "inspiration_lbl";
            this.inspiration_lbl.Size = new System.Drawing.Size(185, 24);
            this.inspiration_lbl.TabIndex = 6;
            this.inspiration_lbl.Text = "Get Clicken Chicken!";
            // 
            // fertilizer_img
            // 
            this.fertilizer_img.Enabled = false;
            this.fertilizer_img.ImageLocation = "E:\\C# Projects\\Clickerty Carrots\\Clickerty Carrots\\bin\\Debug\\fertilizer.png";
            this.fertilizer_img.Location = new System.Drawing.Point(669, 410);
            this.fertilizer_img.Name = "fertilizer_img";
            this.fertilizer_img.Size = new System.Drawing.Size(65, 54);
            this.fertilizer_img.TabIndex = 8;
            this.fertilizer_img.TabStop = false;
            this.fertilizer_img.Visible = false;
            // 
            // heart_img
            // 
            this.heart_img.ImageLocation = "E:\\C# Projects\\Clickerty Carrots\\Clickerty Carrots\\bin\\Debug\\heart.png";
            this.heart_img.Location = new System.Drawing.Point(742, 143);
            this.heart_img.Name = "heart_img";
            this.heart_img.Size = new System.Drawing.Size(254, 411);
            this.heart_img.TabIndex = 9;
            this.heart_img.TabStop = false;
            // 
            // shrooms_img
            // 
            this.shrooms_img.Enabled = false;
            this.shrooms_img.ImageLocation = "E:\\C# Projects\\Clickerty Carrots\\Clickerty Carrots\\bin\\Debug\\shrooms.png";
            this.shrooms_img.Location = new System.Drawing.Point(669, 470);
            this.shrooms_img.Name = "shrooms_img";
            this.shrooms_img.Size = new System.Drawing.Size(65, 54);
            this.shrooms_img.TabIndex = 10;
            this.shrooms_img.TabStop = false;
            this.shrooms_img.Visible = false;
            // 
            // ending_btn
            // 
            this.ending_btn.BackColor = System.Drawing.Color.Fuchsia;
            this.ending_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ending_btn.Enabled = false;
            this.ending_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ending_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.ending_btn.Location = new System.Drawing.Point(561, 523);
            this.ending_btn.Name = "ending_btn";
            this.ending_btn.Size = new System.Drawing.Size(87, 30);
            this.ending_btn.TabIndex = 11;
            this.ending_btn.Text = "See Ending";
            this.ending_btn.UseVisualStyleBackColor = false;
            this.ending_btn.Visible = false;
            this.ending_btn.Click += new System.EventHandler(this.ending_btn_Click);
            // 
            // check
            // 
            this.check.Interval = 1;
            this.check.Tick += new System.EventHandler(this.check_Tick);
            // 
            // men_btn
            // 
            this.men_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.men_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.men_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.men_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.men_btn.Location = new System.Drawing.Point(543, -1);
            this.men_btn.Name = "men_btn";
            this.men_btn.Size = new System.Drawing.Size(87, 41);
            this.men_btn.TabIndex = 12;
            this.men_btn.Text = "Return to menu";
            this.men_btn.UseVisualStyleBackColor = false;
            this.men_btn.Click += new System.EventHandler(this.men_btn_Click);
            // 
            // Clickerty_Carrots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.close_btn;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.men_btn);
            this.Controls.Add(this.ending_btn);
            this.Controls.Add(this.shrooms_img);
            this.Controls.Add(this.heart_img);
            this.Controls.Add(this.fertilizer_img);
            this.Controls.Add(this.inspiration_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.watercan_img);
            this.Controls.Add(this.shop_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.currentmoney_lbl);
            this.Controls.Add(this.plot_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clickerty_Carrots";
            this.Text = "Clickerty Carrots";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clickerty_Carrots_FormClosing);
            this.Load += new System.EventHandler(this.Clickerty_Carrots_Load);
            this.Click += new System.EventHandler(this.Clickerty_Carrots_Click);
            ((System.ComponentModel.ISupportInitialize)(this.plot_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watercan_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizer_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrooms_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plot_img;
        private System.Windows.Forms.Label currentmoney_lbl;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button shop_btn;
        private System.Windows.Forms.PictureBox watercan_img;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label inspiration_lbl;
        private System.Windows.Forms.PictureBox fertilizer_img;
        private System.Windows.Forms.PictureBox heart_img;
        private System.Windows.Forms.PictureBox shrooms_img;
        private System.Windows.Forms.Button ending_btn;
        private System.Windows.Forms.Timer check;
        private System.Windows.Forms.Button men_btn;
    }
}

