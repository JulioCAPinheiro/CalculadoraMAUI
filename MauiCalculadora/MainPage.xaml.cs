namespace MauiCalculadora;

public partial class MainPage : ContentPage
{
	int currentState = 1;
	string operatorMath;
	double primeiroNumero, segundoNumero;


	public MainPage()
	{
		InitializeComponent();
		ResetarValores(this, null);
	}

    private void ResetarValores(object sender, EventArgs e)
    {
		primeiroNumero = 0;
		segundoNumero = 0;
		currentState = 1;
		this.result.Text = "0";
    }

    private void Multiplicapor2x(object sender, EventArgs e)
    {
		if (primeiroNumero == 0)
		{
			return;
		}

		primeiroNumero = primeiroNumero + primeiroNumero;
		this.result.Text = primeiroNumero.ToString();
    }



    private void AoNumeroSelecionado(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		string btnPressionado = button.Text;

		if (this.result.Text == "0" || currentState < 0)
		{
			this.result.Text = string.Empty;
			if (currentState < 0)
			{
				currentState *= -1;
			}
		}

		this.result.Text += btnPressionado;

		double number;
		if(double.TryParse(this.result.Text, out number))
		{
			this.result.Text = number.ToString();

			if(currentState == 1)
			{
				primeiroNumero = number;
			}
			else
			{
				segundoNumero = number;
			}
		}

	}


    private void operadorSelecionado(object sender, EventArgs e)
    {
		currentState = -2;
		Button button = (Button)sender;
		string btnPressionado = button.Text;
		operatorMath = btnPressionado;
    }

    private void onCalcular(object sender, EventArgs e)
    {
		if(currentState == 2)
		{
			var resultado = Calcular.FazerCalculo(primeiroNumero, segundoNumero, operatorMath);

			this.result.Text = resultado.ToString();
			primeiroNumero = resultado;

			currentState = -1;
        }

    }

}

