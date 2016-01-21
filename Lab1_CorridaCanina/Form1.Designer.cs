namespace Lab1_CorridaCanina
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
            this.pbCorrida = new System.Windows.Forms.PictureBox();
            this.pbCao1 = new System.Windows.Forms.PictureBox();
            this.pbCao2 = new System.Windows.Forms.PictureBox();
            this.pbCao3 = new System.Windows.Forms.PictureBox();
            this.pbCao4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMinimumBet = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblBettor = new System.Windows.Forms.Label();
            this.btnBets = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCao3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCao4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCorrida
            // 
            this.pbCorrida.Image = global::Lab1_CorridaCanina.corrida.racetrack;
            this.pbCorrida.Location = new System.Drawing.Point(0, 0);
            this.pbCorrida.Name = "pbCorrida";
            this.pbCorrida.Size = new System.Drawing.Size(824, 292);
            this.pbCorrida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCorrida.TabIndex = 0;
            this.pbCorrida.TabStop = false;
            // 
            // pbCao1
            // 
            this.pbCao1.Image = global::Lab1_CorridaCanina.corrida.dog;
            this.pbCao1.Location = new System.Drawing.Point(21, 21);
            this.pbCao1.Name = "pbCao1";
            this.pbCao1.Size = new System.Drawing.Size(100, 33);
            this.pbCao1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCao1.TabIndex = 1;
            this.pbCao1.TabStop = false;
            // 
            // pbCao2
            // 
            this.pbCao2.Image = global::Lab1_CorridaCanina.corrida.dog;
            this.pbCao2.Location = new System.Drawing.Point(21, 90);
            this.pbCao2.Name = "pbCao2";
            this.pbCao2.Size = new System.Drawing.Size(100, 33);
            this.pbCao2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCao2.TabIndex = 2;
            this.pbCao2.TabStop = false;
            // 
            // pbCao3
            // 
            this.pbCao3.Image = global::Lab1_CorridaCanina.corrida.dog;
            this.pbCao3.Location = new System.Drawing.Point(21, 159);
            this.pbCao3.Name = "pbCao3";
            this.pbCao3.Size = new System.Drawing.Size(100, 33);
            this.pbCao3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCao3.TabIndex = 3;
            this.pbCao3.TabStop = false;
            // 
            // pbCao4
            // 
            this.pbCao4.Image = global::Lab1_CorridaCanina.corrida.dog;
            this.pbCao4.Location = new System.Drawing.Point(21, 229);
            this.pbCao4.Name = "pbCao4";
            this.pbCao4.Size = new System.Drawing.Size(100, 33);
            this.pbCao4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCao4.TabIndex = 4;
            this.pbCao4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btnBets);
            this.groupBox1.Controls.Add(this.lblBettor);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lblMinimumBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // lblMinimumBet
            // 
            this.lblMinimumBet.AutoSize = true;
            this.lblMinimumBet.Location = new System.Drawing.Point(7, 20);
            this.lblMinimumBet.Name = "lblMinimumBet";
            this.lblMinimumBet.Size = new System.Drawing.Size(92, 17);
            this.lblMinimumBet.TabIndex = 0;
            this.lblMinimumBet.Text = "Minimum Bet:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Joe";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bob";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 102);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(38, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Al";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Location = new System.Drawing.Point(11, 139);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(46, 17);
            this.lblBettor.TabIndex = 4;
            this.lblBettor.Text = "Bettor";
            // 
            // btnBets
            // 
            this.btnBets.Location = new System.Drawing.Point(63, 136);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(75, 23);
            this.btnBets.TabIndex = 5;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 137);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "bucks on dog number";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(404, 136);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bets";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(541, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Joe hasn\'t a bet";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(541, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Joe hasn\'t a bet";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(541, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Joe hasn\'t a bet";
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(674, 128);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(131, 37);
            this.btnRace.TabIndex = 13;
            this.btnRace.Text = "Race!!";
            this.btnRace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbCao4);
            this.Controls.Add(this.pbCao3);
            this.Controls.Add(this.pbCao2);
            this.Controls.Add(this.pbCao1);
            this.Controls.Add(this.pbCorrida);
            this.Name = "Form1";
            this.Text = "Dia de Corrida";
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCao3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCao4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCorrida;
        private System.Windows.Forms.PictureBox pbCao1;
        private System.Windows.Forms.PictureBox pbCao2;
        private System.Windows.Forms.PictureBox pbCao3;
        private System.Windows.Forms.PictureBox pbCao4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblMinimumBet;
    }
}

