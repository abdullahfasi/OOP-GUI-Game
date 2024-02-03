
namespace Game
{
    partial class firstform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstform));
            this.startlbl = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startlbl
            // 
            this.startlbl.AutoSize = true;
            this.startlbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.startlbl.Location = new System.Drawing.Point(316, 159);
            this.startlbl.Name = "startlbl";
            this.startlbl.Size = new System.Drawing.Size(144, 30);
            this.startlbl.TabIndex = 0;
            this.startlbl.Text = "Start Game";
            this.startlbl.Click += new System.EventHandler(this.startlbl_Click);
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitlbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitlbl.Location = new System.Drawing.Point(315, 270);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.exitlbl.Size = new System.Drawing.Size(145, 30);
            this.exitlbl.TabIndex = 1;
            this.exitlbl.Text = "Exit";
            this.exitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(316, 216);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(35, 0, 30, 0);
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rules";
            // 
            // firstform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.startlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "firstform";
            this.Text = "firstform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startlbl;
        private System.Windows.Forms.Label exitlbl;
        private System.Windows.Forms.Label label1;
    }
}