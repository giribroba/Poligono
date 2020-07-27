namespace Poligono
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Button = new System.Windows.Forms.Button();
            this.Xibx = new System.Windows.Forms.TextBox();
            this.Yibx = new System.Windows.Forms.TextBox();
            this.Xfbx = new System.Windows.Forms.TextBox();
            this.Yfbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(776, 296);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(618, 353);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(138, 36);
            this.Button.TabIndex = 1;
            this.Button.Text = "button1";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Xibx
            // 
            this.Xibx.Location = new System.Drawing.Point(26, 337);
            this.Xibx.Name = "Xibx";
            this.Xibx.Size = new System.Drawing.Size(105, 20);
            this.Xibx.TabIndex = 2;
            // 
            // Yibx
            // 
            this.Yibx.Location = new System.Drawing.Point(26, 369);
            this.Yibx.Name = "Yibx";
            this.Yibx.Size = new System.Drawing.Size(105, 20);
            this.Yibx.TabIndex = 3;
            // 
            // Xfbx
            // 
            this.Xfbx.Location = new System.Drawing.Point(156, 337);
            this.Xfbx.Name = "Xfbx";
            this.Xfbx.Size = new System.Drawing.Size(105, 20);
            this.Xfbx.TabIndex = 4;
            // 
            // Yfbx
            // 
            this.Yfbx.Location = new System.Drawing.Point(156, 369);
            this.Yfbx.Name = "Yfbx";
            this.Yfbx.Size = new System.Drawing.Size(105, 20);
            this.Yfbx.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Yfbx);
            this.Controls.Add(this.Xfbx);
            this.Controls.Add(this.Yibx);
            this.Controls.Add(this.Xibx);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox Xibx;
        private System.Windows.Forms.TextBox Yibx;
        private System.Windows.Forms.TextBox Xfbx;
        private System.Windows.Forms.TextBox Yfbx;
    }
}

