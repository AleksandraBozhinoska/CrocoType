using System.Drawing;
using System.Windows.Forms;
namespace Proekt
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
            this.pbCrocodile = new System.Windows.Forms.PictureBox();
            this.pbKid = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLives = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrocodile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLives)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCrocodile
            // 
            this.pbCrocodile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbCrocodile.BackColor = System.Drawing.Color.Transparent;
            this.pbCrocodile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCrocodile.BackgroundImage")));
            this.pbCrocodile.Location = new System.Drawing.Point(1038, 357);
            this.pbCrocodile.Margin = new System.Windows.Forms.Padding(2);
            this.pbCrocodile.Name = "pbCrocodile";
            this.pbCrocodile.Size = new System.Drawing.Size(512, 346);
            this.pbCrocodile.TabIndex = 0;
            this.pbCrocodile.TabStop = false;
            this.pbCrocodile.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCrocodile_Paint);
            // 
            // pbKid
            // 
            this.pbKid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbKid.BackColor = System.Drawing.Color.Transparent;
            this.pbKid.Image = ((System.Drawing.Image)(resources.GetObject("pbKid.Image")));
            this.pbKid.Location = new System.Drawing.Point(10, 351);
            this.pbKid.Margin = new System.Windows.Forms.Padding(2);
            this.pbKid.Name = "pbKid";
            this.pbKid.Size = new System.Drawing.Size(233, 324);
            this.pbKid.TabIndex = 1;
            this.pbKid.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(480, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 78);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 3;
            // 
            // pbLives
            // 
            this.pbLives.BackColor = System.Drawing.Color.Transparent;
            this.pbLives.Location = new System.Drawing.Point(1144, 28);
            this.pbLives.Name = "pbLives";
            this.pbLives.Size = new System.Drawing.Size(200, 50);
            this.pbLives.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLives.TabIndex = 4;
            this.pbLives.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbLives);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbKid);
            this.Controls.Add(this.pbCrocodile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrocoType";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrocodile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCrocodile;
        private System.Windows.Forms.PictureBox pbKid;
        private Label label1;
        private Label label2;
        private PictureBox pbLives;
        private Button button1;
    }
}

