namespace calculadora
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btTimes = new System.Windows.Forms.Button();
            this.btLess = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(36, 86);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(52, 23);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(36, 115);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(52, 23);
            this.bt4.TabIndex = 2;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.gerarNumero);
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(36, 173);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(52, 23);
            this.btClean.TabIndex = 3;
            this.btClean.Text = "Limpar";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(36, 144);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(52, 23);
            this.bt7.TabIndex = 4;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(104, 144);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(52, 23);
            this.bt8.TabIndex = 9;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(104, 173);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(52, 23);
            this.bt0.TabIndex = 8;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(104, 115);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(52, 23);
            this.bt5.TabIndex = 7;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(104, 86);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(52, 23);
            this.bt2.TabIndex = 6;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(171, 144);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(52, 23);
            this.bt9.TabIndex = 13;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.gerarNumero);
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(171, 173);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(52, 23);
            this.btResult.TabIndex = 12;
            this.btResult.Text = "=";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(171, 115);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(52, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(171, 86);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(52, 23);
            this.bt3.TabIndex = 10;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.gerarNumero);
            // 
            // btDivide
            // 
            this.btDivide.Location = new System.Drawing.Point(257, 144);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(41, 23);
            this.btDivide.TabIndex = 17;
            this.btDivide.Text = "/";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.operadores);
            // 
            // btTimes
            // 
            this.btTimes.Location = new System.Drawing.Point(257, 173);
            this.btTimes.Name = "btTimes";
            this.btTimes.Size = new System.Drawing.Size(41, 23);
            this.btTimes.TabIndex = 16;
            this.btTimes.Text = "X";
            this.btTimes.UseVisualStyleBackColor = true;
            this.btTimes.Click += new System.EventHandler(this.operadores);
            // 
            // btLess
            // 
            this.btLess.Location = new System.Drawing.Point(257, 115);
            this.btLess.Name = "btLess";
            this.btLess.Size = new System.Drawing.Size(41, 23);
            this.btLess.TabIndex = 15;
            this.btLess.Text = "-";
            this.btLess.UseVisualStyleBackColor = true;
            this.btLess.Click += new System.EventHandler(this.operadores);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(257, 86);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(41, 23);
            this.btPlus.TabIndex = 14;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.operadores);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(36, 51);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(262, 20);
            this.txtResult.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 223);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btTimes);
            this.Controls.Add(this.btLess);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Click += new System.EventHandler(this.gerarNumero);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btTimes;
        private System.Windows.Forms.Button btLess;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.MaskedTextBox txtResult;
    }
}

