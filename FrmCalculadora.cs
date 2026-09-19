using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalculadoraSemiCientifica
{
    /// <summary>
    /// Formulário principal da calculadora semi-científica.
    /// Toda a matemática fica na classe CalculadoraEngine; aqui só tratamos
    /// a interação com o usuário (cliques nos botões e atualização do visor).
    /// </summary>
    public partial class FrmCalculadora : Form
    {
        // Objeto responsável pelas contas (classe de negócio)
        private readonly CalculadoraEngine _engine = new CalculadoraEngine();

        // Guarda o primeiro operando da conta (antes de uma operação)
        private double _valorAnterior = 0;

        // Guarda qual operação está pendente: "+", "-", "x", "/" ou "^"
        private string _operacaoAtual = string.Empty;

        // Indica se o próximo dígito digitado deve iniciar um número novo
        private bool _novoNumero = true;

        // Cultura usada para garantir que o "." seja sempre o separador decimal
        private static readonly CultureInfo Cultura = CultureInfo.InvariantCulture;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        // ---------------------------------------------------------------
        // Botões numéricos (0 a 9)
        // ---------------------------------------------------------------
        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string digito = botao.Text;

            if (_novoNumero || txtDisplay.Text == "0")
            {
                txtDisplay.Text = digito;
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += digito;
            }
        }

        // Botão de ponto decimal
        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "0.";
                _novoNumero = false;
                return;
            }

            if (!txtDisplay.Text.Contains('.'))
            {
                txtDisplay.Text += ".";
            }
        }

        // ---------------------------------------------------------------
        // Botões de operação: + , - , x , / e x^y
        // Todos usam o mesmo evento; a operação é identificada pelo Tag.
        // ---------------------------------------------------------------
        private void BtnOperacao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string operacao = (string)botao.Tag;

            // Se já existe uma operação pendente e o usuário digitou um novo
            // número, calcula o resultado parcial antes de iniciar a próxima
            // operação (permite contas encadeadas, ex.: 2 + 3 + 4 =)
            if (!string.IsNullOrEmpty(_operacaoAtual) && !_novoNumero)
            {
                CalcularResultado();
            }
            else
            {
                _valorAnterior = ObterValorDoDisplay();
            }

            _operacaoAtual = operacao;
            _novoNumero = true;
        }

        // Botão "=" 
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            CalcularResultado();
            _operacaoAtual = string.Empty;
            _novoNumero = true;
        }

        // Executa efetivamente a conta usando a classe CalculadoraEngine
        private void CalcularResultado()
        {
            if (string.IsNullOrEmpty(_operacaoAtual))
            {
                return;
            }

            double valorAtual = ObterValorDoDisplay();

            try
            {
                double resultado = _engine.Calcular(_valorAnterior, valorAtual, _operacaoAtual);
                ExibirResultado(resultado);
                _valorAnterior = resultado;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparTudo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparTudo();
            }
        }

        // ---------------------------------------------------------------
        // Botão raiz quadrada (√y) - operação unária, aplica direto no visor
        // ---------------------------------------------------------------
        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = ObterValorDoDisplay();
                double resultado = _engine.RaizQuadrada(valor);
                ExibirResultado(resultado);
                _valorAnterior = resultado;
                _novoNumero = true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ---------------------------------------------------------------
        // Botão limpar (C)
        // ---------------------------------------------------------------
        private void BtnClear_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }

        private void LimparTudo()
        {
            txtDisplay.Text = "0";
            _valorAnterior = 0;
            _operacaoAtual = string.Empty;
            _novoNumero = true;
        }

        // ---------------------------------------------------------------
        // Botões de memória (M): M+ adiciona, MR recupera, MC limpa
        // ---------------------------------------------------------------
        private void BtnMPlus_Click(object sender, EventArgs e)
        {
            double valor = ObterValorDoDisplay();
            _engine.AdicionarNaMemoria(valor);
            AtualizarIndicadorMemoria();
            _novoNumero = true;
        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            double valorMemoria = _engine.RecuperarMemoria();
            ExibirResultado(valorMemoria);
            _valorAnterior = valorMemoria;
            _novoNumero = false;
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            _engine.LimparMemoria();
            AtualizarIndicadorMemoria();
        }

        private void AtualizarIndicadorMemoria()
        {
            lblMemoriaIndicador.Text = _engine.PossuiValorNaMemoria ? "M" : "  ";
        }

        // ---------------------------------------------------------------
        // Métodos auxiliares
        // ---------------------------------------------------------------

        // Lê o valor exibido no visor como número (double)
        private double ObterValorDoDisplay()
        {
            if (double.TryParse(txtDisplay.Text, NumberStyles.Float, Cultura, out double valor))
            {
                return valor;
            }

            return 0;
        }

        // Exibe um resultado no visor, formatado com o ponto decimal fixo
        private void ExibirResultado(double resultado)
        {
            // Remove zeros desnecessários mantendo até 10 casas decimais
            txtDisplay.Text = resultado.ToString("0.##########", Cultura);
        }

        // ---------------------------------------------------------------
        // Menu: Sobre / Sair
        // ---------------------------------------------------------------
        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmSobre telaSobre = new FrmSobre())
            {
                telaSobre.ShowDialog(this);
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
