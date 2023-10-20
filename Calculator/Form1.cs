using Calculator.Operações;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Soma Soma = new Soma();
        private decimal primeiroNumero;
        private string Operador = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Visor.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visor.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visor.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visor.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Visor.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Visor.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Visor.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Visor.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Visor.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Visor.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)//soma
        {
            Operador = "+";

            // Verifique se já temos o primeiro número
            if (primeiroNumero == 0)
            {
                if (decimal.TryParse(Visor.Text, out primeiroNumero))
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
                if (decimal.TryParse(Visor.Text, out segundoNumero))
                {
                    // Use a classe Calculadora para fazer a soma
                    decimal resultado = Soma.soma(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString();
                    primeiroNumero = 0; // Reinicie o primeiro número para futuras operações
                }

            }

        }

        private void button13_Click(object sender, EventArgs e) //subtação
        {
            Operador = "-";
            // Verifique se já temos o primeiro número
            if (primeiroNumero == 0)
            {
                if (decimal.TryParse(Visor.Text, out primeiroNumero))
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo número
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, out segundoNumero))
                {
                    // Use a classe Calculadora para fazer a subtração
                    decimal resultado = Subt.subt(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString();
                    primeiroNumero = 0; // Reinicie o primeiro número para futuras operações
                }

            }
        }

        private void button14_Click(object sender, EventArgs e) // divisao
        {
            Operador = "/";
            // Verifique se já temos o primeiro número
            if (primeiroNumero == 0)
            {
                if (decimal.TryParse(Visor.Text, out primeiroNumero))
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo número
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, out segundoNumero))
                {
                    // Use a classe Calculadora para fazer a subtração
                    decimal resultado = Divisao.devisao(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString();
                    primeiroNumero = 0; // Reinicie o primeiro número para futuras operações
                }

            }
        }

        private void button15_Click(object sender, EventArgs e)//multiplicaçao
        {
            Operador = "*";
            // Verifique se já temos o primeiro número
            if (primeiroNumero == 0)
            {
                if (decimal.TryParse(Visor.Text, out primeiroNumero))
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo número
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, out segundoNumero))
                {
                    // Use a classe Calculadora para fazer a subtração
                    decimal resultado = Multip.multip(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString();
                    primeiroNumero = 0; // Reinicie o primeiro número para futuras operações
                }

            }
        }

        private void button16_Click(object sender, EventArgs e)//Apagar
        {
            Visor.Text = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)//igual
        {
            decimal segundoNumero;
            if (decimal.TryParse(Visor.Text, out segundoNumero))
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
                Visor.Text = resultado.ToString();
            }

        }
    }
}