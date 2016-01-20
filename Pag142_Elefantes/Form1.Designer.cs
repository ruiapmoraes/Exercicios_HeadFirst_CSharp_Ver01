namespace Pag142_Elefantes
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
            this.btnLucinda = new System.Windows.Forms.Button();
            this.btnLloyd = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLucinda
            // 
            this.btnLucinda.Location = new System.Drawing.Point(32, 16);
            this.btnLucinda.Name = "btnLucinda";
            this.btnLucinda.Size = new System.Drawing.Size(75, 23);
            this.btnLucinda.TabIndex = 0;
            this.btnLucinda.Text = "Lucinda";
            this.btnLucinda.UseVisualStyleBackColor = true;
            this.btnLucinda.Click += new System.EventHandler(this.btnLucinda_Click);
            // 
            // btnLloyd
            // 
            this.btnLloyd.Location = new System.Drawing.Point(32, 50);
            this.btnLloyd.Name = "btnLloyd";
            this.btnLloyd.Size = new System.Drawing.Size(75, 23);
            this.btnLloyd.TabIndex = 1;
            this.btnLloyd.Text = "Lloyd";
            this.btnLloyd.UseVisualStyleBackColor = true;
            this.btnLloyd.Click += new System.EventHandler(this.btnLloyd_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(32, 86);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 2;
            this.btnSwap.Text = "Swap!";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 165);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnLloyd);
            this.Controls.Add(this.btnLucinda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLucinda;
        private System.Windows.Forms.Button btnLloyd;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button button1;
    }
}

