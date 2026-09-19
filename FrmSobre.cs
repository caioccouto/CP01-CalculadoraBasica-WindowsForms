using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CalculadoraSemiCientifica
{
    /// <summary>
    /// Tela "Sobre": exibe os integrantes do grupo, um resumo do trabalho
    /// e o link para o repositório do projeto no GitHub.
    /// </summary>
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }

        // Abre o link do GitHub no navegador padrão do usuário
        private void LnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string url = lnkGithub.Text;
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível abrir o link automaticamente.\r\n" + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
