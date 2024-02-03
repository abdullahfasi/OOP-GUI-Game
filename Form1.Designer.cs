
namespace Game
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
            this.repeater = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.playerbulletloop = new System.Windows.Forms.Timer(this.components);
            this.herolabel = new System.Windows.Forms.Label();
            this.herolbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.horizontalhealth = new System.Windows.Forms.Label();
            this.verticalhealth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.randomhealth = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repeater
            // 
            this.repeater.Enabled = true;
            this.repeater.Interval = 250;
            this.repeater.Tick += new System.EventHandler(this.repeater_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // scorelabel
            // 
            this.scorelabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.Yellow;
            this.scorelabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.scorelabel.Location = new System.Drawing.Point(75, 20);
            this.scorelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(25, 27);
            this.scorelabel.TabIndex = 2;
            this.scorelabel.Text = "0";
            // 
            // playerbulletloop
            // 
            this.playerbulletloop.Enabled = true;
            this.playerbulletloop.Tick += new System.EventHandler(this.playerbulletloop_Tick);
            // 
            // herolabel
            // 
            this.herolabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.herolabel.AutoSize = true;
            this.herolabel.BackColor = System.Drawing.Color.Crimson;
            this.herolabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.herolabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.herolabel.Location = new System.Drawing.Point(128, 20);
            this.herolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.herolabel.Name = "herolabel";
            this.herolabel.Size = new System.Drawing.Size(125, 27);
            this.herolabel.TabIndex = 3;
            this.herolabel.Text = "HeroHealth";
            // 
            // herolbl
            // 
            this.herolbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.herolbl.AutoSize = true;
            this.herolbl.BackColor = System.Drawing.Color.Crimson;
            this.herolbl.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.herolbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.herolbl.Location = new System.Drawing.Point(247, 20);
            this.herolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.herolbl.Name = "herolbl";
            this.herolbl.Size = new System.Drawing.Size(38, 27);
            this.herolbl.TabIndex = 4;
            this.herolbl.Text = "20";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(310, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "EnemyHealth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(25, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "10";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Aqua;
            this.label10.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.BlueViolet;
            this.label10.Location = new System.Drawing.Point(723, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 27);
            this.label10.TabIndex = 13;
            this.label10.Text = "EnemyHealth";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Aqua;
            this.label11.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.BlueViolet;
            this.label11.Location = new System.Drawing.Point(521, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 27);
            this.label11.TabIndex = 14;
            this.label11.Text = "EnemyHealth";
            // 
            // horizontalhealth
            // 
            this.horizontalhealth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.horizontalhealth.AutoSize = true;
            this.horizontalhealth.BackColor = System.Drawing.Color.Aqua;
            this.horizontalhealth.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalhealth.ForeColor = System.Drawing.Color.BlueViolet;
            this.horizontalhealth.Location = new System.Drawing.Point(658, 20);
            this.horizontalhealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.horizontalhealth.Name = "horizontalhealth";
            this.horizontalhealth.Size = new System.Drawing.Size(38, 27);
            this.horizontalhealth.TabIndex = 15;
            this.horizontalhealth.Text = "10";
            // 
            // verticalhealth
            // 
            this.verticalhealth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.verticalhealth.AutoSize = true;
            this.verticalhealth.BackColor = System.Drawing.Color.Aqua;
            this.verticalhealth.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalhealth.ForeColor = System.Drawing.Color.BlueViolet;
            this.verticalhealth.Location = new System.Drawing.Point(447, 20);
            this.verticalhealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.verticalhealth.Name = "verticalhealth";
            this.verticalhealth.Size = new System.Drawing.Size(38, 27);
            this.verticalhealth.TabIndex = 16;
            this.verticalhealth.Text = "10";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.randomhealth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.horizontalhealth);
            this.panel1.Controls.Add(this.verticalhealth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.scorelabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.herolabel);
            this.panel1.Controls.Add(this.herolbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 56);
            this.panel1.TabIndex = 17;
            // 
            // randomhealth
            // 
            this.randomhealth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.randomhealth.AutoSize = true;
            this.randomhealth.BackColor = System.Drawing.Color.Aqua;
            this.randomhealth.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomhealth.ForeColor = System.Drawing.Color.BlueViolet;
            this.randomhealth.Location = new System.Drawing.Point(861, 20);
            this.randomhealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.randomhealth.Name = "randomhealth";
            this.randomhealth.Size = new System.Drawing.Size(38, 27);
            this.randomhealth.TabIndex = 17;
            this.randomhealth.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(910, 520);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer repeater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Timer playerbulletloop;
        private System.Windows.Forms.Label herolabel;
        private System.Windows.Forms.Label herolbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label horizontalhealth;
        private System.Windows.Forms.Label verticalhealth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label randomhealth;
    }
}

