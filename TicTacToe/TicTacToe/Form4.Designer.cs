namespace TicTacToe
{
    partial class Form4
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
            this.fechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // fechar
            // 
            this.fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fechar.Image = global::TicTacToe.Properties.Resources.fechar;
            this.fechar.Location = new System.Drawing.Point(764, -1);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(37, 47);
            this.fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fechar.TabIndex = 11;
            this.fechar.TabStop = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fechar;
    }
}