using Calculator.Opera��es;


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

            // Verifique se j� temos o primeiro n�mero
            if (primeiroNumero == 0)
            {
                if (decimal.TryParse(Visor.Text, out primeiroNumero))
                // o m�todo TryParse � uma maneira segura de tentar converter uma representa��o de string em um tipo de dado espec�fico e verificar se a convers�o foi bem-sucedida.
                // Ele � comumente usado para converter strings em tipos num�ricos, como int, decimal, double, entre outros.
                // TryParse --> Visor.Text: A string que voc� deseja converter em um n�mero decimal "var primeiroNumero".
                //primeiroNumero: Uma vari�vel de sa�da que conter� o valor decimal convertido se a convers�o for bem-sucedida.
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo n�mero
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
                    primeiroNumero = 0; // Reinicie o primeiro n�mero para futuras opera��es
                }

            }

        }

        private void button13_Click(object sender, EventArgs e) //subta��o
        {
            Operador = "-";
            // Verifique se j� temos o primeiro n�mero
            if (primeiroNumero == 0)
            {
                if (decimal.TryParse(Visor.Text, out primeiroNumero))
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo n�mero
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, out segundoNumero))
                {
                    // Use a classe Calculadora para fazer a subtra��o
                    decimal resultado = Subt.subt(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString();
                    primeiroNumero = 0; // Reinicie o primeiro n�mero para futuras opera��es
                }

            }
        }

        private void button14_Click(object sender, EventArgs e) // divisao
        {
            Operador = "/";
            // Verifique se j� temos o primeiro n�mero
            if (primeiroNumero == 0)
            {
                if (decimal.TryParse(Visor.Text, out primeiroNumero))
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo n�mero
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, out segundoNumero))
                {
                    // Use a classe Calculadora para fazer a subtra��o
                    decimal resultado = Divisao.devisao(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString();
                    primeiroNumero = 0; // Reinicie o primeiro n�mero para futuras opera��es
                }

            }
        }

        private void button15_Click(object sender, EventArgs e)//multiplica�ao
        {
            Operador = "*";
            // Verifique se j� temos o primeiro n�mero
            if (primeiroNumero == 0)
            {
                if (decimal.TryParse(Visor.Text, out primeiroNumero))
                {
                    Visor.Text = string.Empty; // Limpe o visor para o segundo n�mero
                }

            }
            else
            {
                decimal segundoNumero;
                if (decimal.TryParse(Visor.Text, out segundoNumero))
                {
                    // Use a classe Calculadora para fazer a subtra��o
                    decimal resultado = Multip.multip(primeiroNumero, segundoNumero);
                    Visor.Text = resultado.ToString();
                    primeiroNumero = 0; // Reinicie o primeiro n�mero para futuras opera��es
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
                        primeiroNumero = 0; //Reinicie o primeiro n�mero para futuras opera��es
                        break;
                    case "-":
                        resultado = Subt.subt(primeiroNumero, segundoNumero);
                        primeiroNumero = 0; //Reinicie o primeiro n�mero para futuras opera��es
                        break;
                    case "*":
                        resultado = Multip.multip(primeiroNumero, segundoNumero);
                        primeiroNumero = 0; //Reinicie o primeiro n�mero para futuras opera��es
                        break;
                    case "/":
                        if (segundoNumero != 0)
                            resultado = Divisao.devisao(primeiroNumero, segundoNumero);
                        primeiroNumero = 0; //Reinicie o primeiro n�mero para futuras opera��es
                        break;
                }
                Visor.Text = resultado.ToString();
            }

        }
    }
}