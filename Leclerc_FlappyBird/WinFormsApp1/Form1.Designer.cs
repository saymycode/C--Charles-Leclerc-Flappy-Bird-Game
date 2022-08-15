namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.Leclerc = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.Way = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.binotto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leclerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Way)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binotto)).BeginInit();
            this.SuspendLayout();
            // 
            // BoruUst
            // 
            this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
            this.BoruUst.Location = new System.Drawing.Point(507, 2);
            this.BoruUst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(109, 159);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 0;
            this.BoruUst.TabStop = false;
            this.BoruUst.Click += new System.EventHandler(this.BoruUst_Click);
            // 
            // Leclerc
            // 
            this.Leclerc.Image = ((System.Drawing.Image)(resources.GetObject("Leclerc.Image")));
            this.Leclerc.Location = new System.Drawing.Point(12, 154);
            this.Leclerc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Leclerc.Name = "Leclerc";
            this.Leclerc.Size = new System.Drawing.Size(76, 77);
            this.Leclerc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Leclerc.TabIndex = 1;
            this.Leclerc.TabStop = false;
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
            this.BoruAlt.Location = new System.Drawing.Point(407, 325);
            this.BoruAlt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(129, 168);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 2;
            this.BoruAlt.TabStop = false;
            this.BoruAlt.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Way
            // 
            this.Way.Image = ((System.Drawing.Image)(resources.GetObject("Way.Image")));
            this.Way.Location = new System.Drawing.Point(-4, 490);
            this.Way.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Way.Name = "Way";
            this.Way.Size = new System.Drawing.Size(1004, 63);
            this.Way.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Way.TabIndex = 3;
            this.Way.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(-3, 555);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(654, 38);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Points 0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameTime
            // 
            this.GameTime.Enabled = true;
            this.GameTime.Interval = 20;
            this.GameTime.Tick += new System.EventHandler(this.GameTimeEvent);
            // 
            // binotto
            // 
            this.binotto.Image = ((System.Drawing.Image)(resources.GetObject("binotto.Image")));
            this.binotto.Location = new System.Drawing.Point(725, 2);
            this.binotto.Name = "binotto";
            this.binotto.Size = new System.Drawing.Size(275, 491);
            this.binotto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.binotto.TabIndex = 5;
            this.binotto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(996, 590);
            this.Controls.Add(this.binotto);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Way);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.Leclerc);
            this.Controls.Add(this.BoruUst);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leclerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Way)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binotto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox BoruUst;
        private PictureBox Leclerc;
        private PictureBox BoruAlt;
        private PictureBox Way;
        private Label scoreText;
        private System.Windows.Forms.Timer GameTime;
        private PictureBox binotto;
    }
}