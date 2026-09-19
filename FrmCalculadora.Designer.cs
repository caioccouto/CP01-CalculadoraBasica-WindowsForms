namespace CalculadoraSemiCientifica
{
    partial class FrmCalculadora
    {
    
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Formulários Windows

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.lblMemoriaIndicador = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();

            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();

            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();

            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();

            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();

            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // lblMemoriaIndicador
            // 
            this.lblMemoriaIndicador.AutoSize = true;
            this.lblMemoriaIndicador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMemoriaIndicador.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMemoriaIndicador.Location = new System.Drawing.Point(12, 30);
            this.lblMemoriaIndicador.Name = "lblMemoriaIndicador";
            this.lblMemoriaIndicador.Size = new System.Drawing.Size(17, 15);
            this.lblMemoriaIndicador.TabIndex = 1;
            this.lblMemoriaIndicador.Text = "  ";
            // 
            // txtDisplay
            // 
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular);
            this.txtDisplay.Location = new System.Drawing.Point(12, 48);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(304, 41);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.Text = "0";
            // O TextAlign = Right garante que o marcador/resultado apareça no lado direito
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // ---------- Linha 1: MC | MR | M+ | C ----------
            this.btnMC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMC.Location = new System.Drawing.Point(12, 105);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(70, 50);
            this.btnMC.TabIndex = 3;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.BtnMC_Click);

            this.btnMR.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMR.Location = new System.Drawing.Point(90, 105);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(70, 50);
            this.btnMR.TabIndex = 4;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.BtnMR_Click);

            this.btnMPlus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMPlus.Location = new System.Drawing.Point(168, 105);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(70, 50);
            this.btnMPlus.TabIndex = 5;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.BtnMPlus_Click);

            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(246, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 50);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            // ---------- Linha 2: 7 | 8 | 9 | / ----------
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn7.Location = new System.Drawing.Point(12, 163);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 50);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btn8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn8.Location = new System.Drawing.Point(90, 163);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 50);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btn9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn9.Location = new System.Drawing.Point(168, 163);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 50);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btnDiv.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDiv.Location = new System.Drawing.Point(246, 163);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(70, 50);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Tag = "/";
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.BtnOperacao_Click);

            // ---------- Linha 3: 4 | 5 | 6 | x ----------
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn4.Location = new System.Drawing.Point(12, 221);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 50);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btn5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn5.Location = new System.Drawing.Point(90, 221);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 50);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btn6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn6.Location = new System.Drawing.Point(168, 221);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 50);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btnMul.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMul.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMul.Location = new System.Drawing.Point(246, 221);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(70, 50);
            this.btnMul.TabIndex = 14;
            this.btnMul.Tag = "x";
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.BtnOperacao_Click);

            // ---------- Linha 4: 1 | 2 | 3 | - ----------
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn1.Location = new System.Drawing.Point(12, 279);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 50);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btn2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn2.Location = new System.Drawing.Point(90, 279);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 50);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btn3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn3.Location = new System.Drawing.Point(168, 279);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 50);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btnSub.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSub.Location = new System.Drawing.Point(246, 279);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(70, 50);
            this.btnSub.TabIndex = 18;
            this.btnSub.Tag = "-";
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.BtnOperacao_Click);

            // ---------- Linha 5: 0 | . | = | + ----------
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn0.Location = new System.Drawing.Point(12, 337);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 50);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.BtnNumero_Click);

            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDot.Location = new System.Drawing.Point(90, 337);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(70, 50);
            this.btnDot.TabIndex = 20;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.BtnDot_Click);

            this.btnEquals.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEquals.ForeColor = System.Drawing.Color.White;
            this.btnEquals.Location = new System.Drawing.Point(168, 337);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(70, 50);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.BtnEquals_Click);

            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAdd.Location = new System.Drawing.Point(246, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 50);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Tag = "+";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnOperacao_Click);

            // ---------- Linha 6: √y | x^y (funções científicas) ----------
            this.btnSqrt.BackColor = System.Drawing.Color.Khaki;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSqrt.Location = new System.Drawing.Point(12, 395);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(147, 50);
            this.btnSqrt.TabIndex = 23;
            this.btnSqrt.Text = "√y";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);

            this.btnPow.BackColor = System.Drawing.Color.Khaki;
            this.btnPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPow.Location = new System.Drawing.Point(168, 395);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(148, 50);
            this.btnPow.TabIndex = 24;
            this.btnPow.Tag = "^";
            this.btnPow.Text = "x^y";
            this.btnPow.UseVisualStyleBackColor = false;
            this.btnPow.Click += new System.EventHandler(this.BtnOperacao_Click);

            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 460);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblMemoriaIndicador);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Semi-Científica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label lblMemoriaIndicador;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPow;
    }
}
