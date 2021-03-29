namespace Helicopter_game
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
            this.components = new System.ComponentModel.Container();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ufo = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.BackColor = System.Drawing.Color.Transparent;
            this.scoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTxt.Location = new System.Drawing.Point(12, 18);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(30, 31);
            this.scoreTxt.TabIndex = 4;
            this.scoreTxt.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTick);
            // 
            // ufo
            // 
            this.ufo.BackColor = System.Drawing.Color.Transparent;
            this.ufo.Image = global::Helicopter_game.Properties.Resources.alien1;
            this.ufo.Location = new System.Drawing.Point(713, 255);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(68, 72);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            // 
            // pillar2
            // 
            this.pillar2.Image = global::Helicopter_game.Properties.Resources.pillar;
            this.pillar2.Location = new System.Drawing.Point(463, 404);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(75, 164);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 2;
            this.pillar2.TabStop = false;
            // 
            // pillar1
            // 
            this.pillar1.Image = global::Helicopter_game.Properties.Resources.pillar;
            this.pillar1.Location = new System.Drawing.Point(357, -22);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(75, 232);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 1;
            this.pillar1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Helicopter_game.Properties.Resources.Halicopter;
            this.player.Location = new System.Drawing.Point(81, 255);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 54);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "HelicopterRush";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Timer gameTimer;
    }
}

