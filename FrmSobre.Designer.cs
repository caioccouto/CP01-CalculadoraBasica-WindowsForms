namespace CalculadoraSemiCientifica
{
    partial class FrmSobre
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


        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIntegrantesTitulo = new System.Windows.Forms.Label();
            this.txtIntegrantes = new System.Windows.Forms.TextBox();
            this.lblResumoTitulo = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.lblGithubTitulo = new System.Windows.Forms.Label();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora Semi-Científica";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        
            this.lblIntegrantesTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIntegrantesTitulo.Location = new System.Drawing.Point(15, 60);
            this.lblIntegrantesTitulo.Name = "lblIntegrantesTitulo";
            this.lblIntegrantesTitulo.Size = new System.Drawing.Size(200, 20);
            this.lblIntegrantesTitulo.TabIndex = 1;
            this.lblIntegrantesTitulo.Text = "Integrantes do grupo:";

       
            this.txtIntegrantes.Location = new System.Drawing.Point(15, 83);
            this.txtIntegrantes.Multiline = true;
            this.txtIntegrantes.Name = "txtIntegrantes";
            this.txtIntegrantes.ReadOnly = true;
            this.txtIntegrantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIntegrantes.Size = new System.Drawing.Size(400, 80);
            this.txtIntegrantes.TabIndex = 2;
            this.txtIntegrantes.Text = "1. Caio Couto - RM563452\r\n2. Guilherme Eustáquio - RM566784\r\n3. Matheus Tavares - RM566844";

          
            this.lblResumoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResumoTitulo.Location = new System.Drawing.Point(15, 172);
            this.lblResumoTitulo.Name = "lblResumoTitulo";
            this.lblResumoTitulo.Size = new System.Drawing.Size(200, 20);
            this.lblResumoTitulo.TabIndex = 3;
            this.lblResumoTitulo.Text = "Resumo do trabalho:";

            this.txtResumo.Location = new System.Drawing.Point(15, 195);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.ReadOnly = true;
            this.txtResumo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResumo.Size = new System.Drawing.Size(400, 110);
            this.txtResumo.TabIndex = 4;
            this.txtResumo.Text = "Aplicação desenvolvida em C# (Windows Forms) que implementa uma calculadora sem" +
    "i-científica. O sistema permite realizar as quatro operações aritméticas básic" +
    "as (soma, subtração, multiplicação e divisão), além de raiz quadrada (√y), pot" +
    "enciação (x^y) e armazenamento de valores em memória (M). O projeto foi organi" +
    "zado separando a lógica de cálculo (classe CalculadoraEngine) da interface grá" +
    "fica (Forms), atendendo aos requisitos da atividade proposta.";

           
            this.lblGithubTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGithubTitulo.Location = new System.Drawing.Point(15, 315);
            this.lblGithubTitulo.Name = "lblGithubTitulo";
            this.lblGithubTitulo.Size = new System.Drawing.Size(150, 20);
            this.lblGithubTitulo.TabIndex = 5;
            this.lblGithubTitulo.Text = "Repositório do projeto:";

            this.lnkGithub.Location = new System.Drawing.Point(15, 338);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(400, 20);
            this.lnkGithub.TabIndex = 6;
            this.lnkGithub.Text = "https://github.com/seu-usuario/calculadora-semi-cientifica";
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkGithub_LinkClicked);

           
            this.btnFechar.Location = new System.Drawing.Point(340, 375);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 30);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 420);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lnkGithub);
            this.Controls.Add(this.lblGithubTitulo);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.lblResumoTitulo);
            this.Controls.Add(this.txtIntegrantes);
            this.Controls.Add(this.lblIntegrantesTitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIntegrantesTitulo;
        private System.Windows.Forms.TextBox txtIntegrantes;
        private System.Windows.Forms.Label lblResumoTitulo;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Label lblGithubTitulo;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.Button btnFechar;
    }
}
