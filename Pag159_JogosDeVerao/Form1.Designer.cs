namespace Pag159_JogosDeVerao
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
            this.btnClicaMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClicaMe
            // 
            this.btnClicaMe.Location = new System.Drawing.Point(84, 30);
            this.btnClicaMe.Name = "btnClicaMe";
            this.btnClicaMe.Size = new System.Drawing.Size(75, 23);
            this.btnClicaMe.TabIndex = 0;
            this.btnClicaMe.Text = "Clica-Me!!";
            this.btnClicaMe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 185);
            this.Controls.Add(this.btnClicaMe);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pag. 159 - Jogos de Verão";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClicaMe;
    }
}

