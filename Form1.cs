using System;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Calculadora : Form
    {
        private Operacoes _operacoes;

        private double ultimoResultado;
        private double ultimoOperando;
        private string ultimaOperacao;
        private bool operacaoRepetida;
        private double resultado = 0;

        public Calculadora()
        {
            InitializeComponent();
            _operacoes = new Operacoes();
            LimparTudo();
        }

        private void LimparTudo()
        {
            BoxResultado.Text = "";
            txtOperacao.Text = "";
            ultimoResultado = 0;
            ultimoOperando = 0;
            ultimaOperacao = "";
            operacaoRepetida = false;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            string valorLabel = BoxResultado.Text;
            if (string.IsNullOrEmpty(BoxResultado.Text) || BoxResultado.Text == "0")
            {
                BoxResultado.Text = "0";
            }
            else
            {
                BoxResultado.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (BoxResultado.Text == "0")
            {
                BoxResultado.Text = "1";
            }
            else
            {
                BoxResultado.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (BoxResultado.Text == "0")
            {
                BoxResultado.Text = "2";
            }
            else
            {
                BoxResultado.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (BoxResultado.Text == "0")
            {
                BoxResultado.Text = "3";
            }
            else
            {
                BoxResultado.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (BoxResultado.Text == "0")
            {
                BoxResultado.Text = "4";
            }
            else
            {
                BoxResultado.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (BoxResultado.Text == "0")
            {
                BoxResultado.Text = "5";
            }
            else
            {
                BoxResultado.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (BoxResultado.Text == "0")
            {
                BoxResultado.Text = "6";
            }
            else
            {
                BoxResultado.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (BoxResultado.Text == "0")
            {
                BoxResultado.Text = "7";
            }
            else
            {
                BoxResultado.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (BoxResultado.Text == "0")
            {
                BoxResultado.Text = "8";
            }
            else
            {
                BoxResultado.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (BoxResultado.Text == "0")
            {
                BoxResultado.Text = "9";
            }
            else
            {
                BoxResultado.Text += "9";
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            string valorLabel = txtOperacao.Text;
            if (string.IsNullOrEmpty(valorLabel))
            {
                string valor = BoxResultado.Text;

                if (!string.IsNullOrEmpty(valor))
                {
                    BoxResultado.Text = "";
                    txtOperacao.Text = valor;
                    txtOperacao.Text += " + ";
                    ultimoResultado = Convert.ToDouble(valor);
                    ultimaOperacao = "+";
                    operacaoRepetida = false;
                }
            }
            else
            {
                valorLabel = valorLabel.Replace(ultimaOperacao, "+");
                txtOperacao.Text = valorLabel;
                ultimaOperacao = "+";
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            string valorLabel = txtOperacao.Text;
            if (string.IsNullOrEmpty(valorLabel))
            {
                string valor = BoxResultado.Text;

                if (!string.IsNullOrEmpty(valor))
                {
                    BoxResultado.Text = "";
                    txtOperacao.Text = valor;
                    txtOperacao.Text += " - ";
                    ultimoResultado = Convert.ToDouble(valor);
                    ultimaOperacao = "-";
                    operacaoRepetida = false;
                }
            }
            else
            {
                valorLabel = valorLabel.Replace(ultimaOperacao, "-");
                txtOperacao.Text = valorLabel;
                ultimaOperacao = "-";

            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            string valorLabel = txtOperacao.Text;
            if (string.IsNullOrEmpty(valorLabel))
            {
                string valor = BoxResultado.Text;

                if (!string.IsNullOrEmpty(valor))
                {
                    BoxResultado.Text = "";
                    txtOperacao.Text = valor;
                    txtOperacao.Text += " * ";
                    ultimoResultado = Convert.ToDouble(valor);
                    ultimaOperacao = "*";
                    operacaoRepetida = false;
                }
            }
            else
            {
                valorLabel = valorLabel.Replace(ultimaOperacao, "*");
                txtOperacao.Text = valorLabel;
                ultimaOperacao = "*";
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            string valorLabel = txtOperacao.Text;
            if (string.IsNullOrEmpty(valorLabel))
            {
                string valor = BoxResultado.Text;

                if (!string.IsNullOrEmpty(valor))
                {
                    BoxResultado.Text = "";
                    txtOperacao.Text = valor;
                    txtOperacao.Text += " / ";
                    ultimoResultado = Convert.ToDouble(valor);
                    ultimaOperacao = "/";
                    operacaoRepetida = false;
                }
            }
            else
            {
                valorLabel = valorLabel.Replace(ultimaOperacao, "/");
                txtOperacao.Text = valorLabel;
                ultimaOperacao = "/";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(BoxResultado.Text, out double segundoValor)) return;

            var indexOper = txtOperacao.Text.IndexOf(ultimaOperacao);
            var primOpr = txtOperacao.Text.Substring(0, indexOper - 1);
            double.TryParse(primOpr, out double primeiroValor);

            if (resultado != 0)
            {
                ultimoOperando = ultimoResultado;
            }

            if (!operacaoRepetida)
            {
                ultimoOperando = segundoValor;
            }

            if (ultimaOperacao == "/" && ultimoOperando == 0)
            {
                MessageBox.Show("Divisão por zero não é permitida.");
                return;
            }

            if (!string.IsNullOrEmpty(BoxResultado.Text))
            {

                switch (ultimaOperacao)
                {
                    case "+":
                        resultado = _operacoes.Soma(primeiroValor, ultimoOperando);
                        break;
                    case "-":
                        resultado = _operacoes.Subtracao(primeiroValor, ultimoOperando);
                        break;
                    case "*":
                        resultado = _operacoes.Mult(primeiroValor, ultimoOperando);
                        break;
                    case "/":
                        resultado = _operacoes.Divisao(primeiroValor, ultimoOperando);
                        break;
                }

                
                txtOperacao.Text = primOpr.Trim() + " " + ultimaOperacao + " " + ultimoOperando + " = ";
                BoxResultado.Text = resultado.ToString();
                ultimoResultado = resultado;
                operacaoRepetida = true;
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!BoxResultado.Text.Contains(","))
            {
                BoxResultado.Text += ",";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
    }
}
