using Calculator.Operações;
using System.Text.RegularExpressions;
using System.Globalization;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true; // Habilita a captura de eventos de teclado
            this.KeyDown += new KeyEventHandler(Form1_BotoesTeclado); // Associa o evento KeyDown
        }




        private void Form1_BotoesTeclado(object sender, KeyEventArgs e) // bug visor duplicado e dpad e os numeros nao funcinam ao mesmo tempo
        {

            // Verifica qual tecla foi pressionada e realiza a ação correspondente
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    Visor.Text += "0";
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    Visor.Text += "1";
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    Visor.Text += "2";
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    Visor.Text += "3";
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    Visor.Text += "4";
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    Visor.Text += "5";
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    Visor.Text += "6";
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    Visor.Text += "7";
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    Visor.Text += "8";
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    Visor.Text += "9";
                    break;
                case Keys.Decimal:
                    Visor.Text += ".";
                    break;
                case Keys.Add:
                    button11_Click(sender, e); // Pressionar o botão de soma
                    break;
                case Keys.Subtract:
                    button13_Click(sender, e); // Pressionar o botão de subtração
                    break;
                case Keys.Multiply:
                    button15_Click(sender, e); // Pressionar o botão de multiplicação
                    break;
                case Keys.Divide:
                    button14_Click(sender, e); // Pressionar o botão de divisão
                    break;
                case Keys.Enter:
                    button12_Click(sender, e); // Pressionar o botão de igual
                    break;
                case Keys.Delete:
                    button16_Click(sender, e);
                    break;
                case Keys.Back:
                        C_Click(sender, e);
                    break;
                default:
                    // Lidar com outras teclas ou ignorá-las
                    break;
            }

        }


        public void ControlSetFocus(Control control)// remove o foco do botao e direciona para o visor
        {
            control?.Focus();
            Visor.DeselectAll();
        }


        Soma Soma = new Soma();
        private decimal primeiroNumero = 0m;
        private string Operador = "";


        private void button1_Click(object sender, EventArgs e)
        {
            Visor.Text += "1";
            ControlSetFocus(Visor);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visor.Text += "2";
            ControlSetFocus(Visor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visor.Text += "3";
            ControlSetFocus(Visor);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visor.Text += "4";
            ControlSetFocus(Visor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Visor.Text += "5";
            ControlSetFocus(Visor);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Visor.Text += "6";
            ControlSetFocus(Visor);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Visor.Text += "7";
            ControlSetFocus(Visor);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Visor.Text += "8";
            ControlSetFocus(Visor);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Visor.Text += "9";
            ControlSetFocus(Visor);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Visor.Text.Contains("0."))
            {
                Visor.Text += "0";
            }
            else
            {
                Visor.Text = "0";
            }




            //Visor.Text += "0";
            ControlSetFocus(Visor);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                Visor.Text += ".";
                string cleanedInput = Regex.Replace(Visor.Text, @"\.{2,}", ".");
                //Relex Substituir todas as ocorrências de um padrão de expressão regular por um valor específico em uma string.
                // O padrão \.{2,} significa "dois ou mais pontos".
                //O segundo argumento, ".,", é o texto de substituição e, neste caso, substitui todas as ocorrências encontradas pelo caractere ponto único ".".
                //Basicamente, ele está substituindo múltiplos pontos consecutivos por um único ponto.
                Visor.Text = cleanedInput;
            }
            else
            {
                Visor.Text += "0.";
                string cleanedInput = Regex.Replace(Visor.Text, @"\.{2,}", ".");
                Visor.Text = cleanedInput;
            }
            ControlSetFocus(Visor);
        }


        private void button11_Click(object sender, EventArgs e)//soma
        {
            Operador = "+";

            // Verifique se já temos o primeiro número
            if (primeiroNumero == 0m)
            {
                if (decimal.TryParse(Visor.Text, CultureInfo.InvariantCulture, out primeiroNumero))
                // o método TryParse é uma maneira segura de tentar converter uma representação de string em um tipo de dado específico e verificar se a conversão foi bem-sucedida.
                // Ele é comumente usado para converter strings em tipos numéricos, como int, decimal, double, entre outros.
                // TryParse --> Visor.Text: A string que você deseja converter em um número decimal "var primeiroNumero".
                //primeiroNumero: Uma variável de saída que conterá o valor decimal convertido se a conversão for bem-sucedida.
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo número
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, CultureInfo.InvariantCulture, out segundoNumero))
                {
                    // Use a classe Soma para fazer a soma
                    decimal resultado = Soma.soma(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString("0.##", CultureInfo.InvariantCulture);
                    primeiroNumero = 0; // Reinicie o primeiro número para futuras operações
                }

            }
            ControlSetFocus(Visor);

        }

        private void button13_Click(object sender, EventArgs e) //subtação
        {
            Operador = "-";
            // Verifique se já temos o primeiro número
            if (primeiroNumero == 0m)
            {
                if (decimal.TryParse(Visor.Text, CultureInfo.InvariantCulture, out primeiroNumero))
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo número
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, CultureInfo.InvariantCulture, out segundoNumero))
                {
                    // Use a classe Subt para fazer a subtração
                    decimal resultado = Subt.subt(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString("0.##", CultureInfo.InvariantCulture);
                    primeiroNumero = 0; // Reinicie o primeiro número para futuras operações
                }

            }
            ControlSetFocus(Visor);
        }

        private void button14_Click(object sender, EventArgs e) // divisao
        {
            Operador = "/";
            // Verifique se já temos o primeiro número
            if (primeiroNumero == 0m)
            {
                if (decimal.TryParse(Visor.Text, CultureInfo.InvariantCulture, out primeiroNumero))
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo número
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, CultureInfo.InvariantCulture, out segundoNumero))
                {
                    // Use a classe Divisao para fazer a subtração
                    decimal resultado = Divisao.devisao(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString("0.##", CultureInfo.InvariantCulture);
                    primeiroNumero = 0; // Reinicie o primeiro número para futuras operações
                }

            }
            ControlSetFocus(Visor);
        }

        private void button15_Click(object sender, EventArgs e)//multiplicaçao
        {
            Operador = "*";
            // Verifique se já temos o primeiro número
            if (primeiroNumero == 0m)
            {
                if (decimal.TryParse(Visor.Text, CultureInfo.InvariantCulture, out primeiroNumero))
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo número
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, CultureInfo.InvariantCulture, out segundoNumero))
                {
                    // Use a classe Muktio para fazer a subtração
                    decimal resultado = Multip.multip(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString("0.##", CultureInfo.InvariantCulture);
                    primeiroNumero = 0; // Reinicie o primeiro número para futuras operações
                }

            }
            ControlSetFocus(Visor);
        }

        private void button16_Click(object sender, EventArgs e)//Apagar
        {
            Visor.Text = string.Empty;
            ControlSetFocus(Visor);
        }

        private void button12_Click(object sender, EventArgs e)//igual
        {
            decimal segundoNumero;
            if (decimal.TryParse(Visor.Text, CultureInfo.InvariantCulture, out segundoNumero))
            {
                decimal resultado = 0m;

                switch (Operador)
                {
                    case "+":
                        resultado = Soma.soma(primeiroNumero, segundoNumero);
                        primeiroNumero = 0; //Reinicie o primeiro número para futuras operações
                        break;
                    case "-":
                        resultado = Subt.subt(primeiroNumero, segundoNumero);
                        primeiroNumero = 0; //Reinicie o primeiro número para futuras operações
                        break;
                    case "*":
                        resultado = Multip.multip(primeiroNumero, segundoNumero);
                        primeiroNumero = 0; //Reinicie o primeiro número para futuras operações
                        break;
                    case "/":
                        if (segundoNumero != 0)
                            resultado = Divisao.devisao(primeiroNumero, segundoNumero);
                        primeiroNumero = 0; //Reinicie o primeiro número para futuras operações
                        break;
                }

                Visor.Text = resultado.ToString("0.##", CultureInfo.InvariantCulture);
            }
            ControlSetFocus(Visor);
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (Visor.Text.Length > 0)
            {
                Visor.Text = Visor.Text.Substring(0, Visor.Text.Length - 1);
            }
        }
    }
}