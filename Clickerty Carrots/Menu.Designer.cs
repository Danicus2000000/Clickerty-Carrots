namespace Clickerty_Carrots
{
    partial class Menu_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_game));
            this.name_lbl = new System.Windows.Forms.Label();
            this.newgame_btn = new System.Windows.Forms.Button();
            this.loadgame_btn = new System.Windows.Forms.Button();
            this.options_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(99, 9);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(213, 25);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Clickerty Carrots";
            // 
            // newgame_btn
            // 
            this.newgame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newgame_btn.Location = new System.Drawing.Point(91, 52);
            this.newgame_btn.Name = "newgame_btn";
            this.newgame_btn.Size = new System.Drawing.Size(75, 34);
            this.newgame_btn.TabIndex = 1;
            this.newgame_btn.Text = "New Game";
            this.newgame_btn.UseVisualStyleBackColor = true;
            this.newgame_btn.Click += new System.EventHandler(this.newgame_btn_Click);
            // 
            // loadgame_btn
            // 
            this.loadgame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadgame_btn.Location = new System.Drawing.Point(172, 52);
            this.loadgame_btn.Name = "loadgame_btn";
            this.loadgame_btn.Size = new System.Drawing.Size(75, 34);
            this.loadgame_btn.TabIndex = 2;
            this.loadgame_btn.Text = "Load Game";
            this.loadgame_btn.UseVisualStyleBackColor = true;
            this.loadgame_btn.Click += new System.EventHandler(this.loadgame_btn_Click);
            // 
            // options_btn
            // 
            this.options_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.options_btn.Location = new System.Drawing.Point(253, 52);
            this.options_btn.Name = "options_btn";
            this.options_btn.Size = new System.Drawing.Size(75, 34);
            this.options_btn.TabIndex = 3;
            this.options_btn.Text = "Audio Settings";
            this.options_btn.UseVisualStyleBackColor = true;
            this.options_btn.Click += new System.EventHandler(this.options_btn_Click);
            // 
            // Menu_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(394, 159);
            this.Controls.Add(this.options_btn);
            this.Controls.Add(this.loadgame_btn);
            this.Controls.Add(this.newgame_btn);
            this.Controls.Add(this.name_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_game";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_game_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button newgame_btn;
        private System.Windows.Forms.Button loadgame_btn;
        private System.Windows.Forms.Button options_btn;
    }
}