namespace Dinosaurios;
///<Summary>
///<Createddate>2023/06/30</Createddate>
///<company>SandBox</company>
///<lastmodificationdate>2024</lastmodificationdate>
///<lastmodificationdescription>
///Agregar la documentacion y la imagen
///</lastmodificationdescription>
///<lastmodifierautor>Lorena Vasquez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase 
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		//Escribimos las variables para despues hacer la converción, luego de eso multiplicamos kilos x
		//2.2, para que el resultado se muestre en libras, hacemos casi lo mismo con los metros
		//para pasarlos a centimetros y que luego se muestre el resultado.
		//se verificara si los campos estan vacios, si es asi se enviara un mensaje de error, pero si no se 
		//mostraran los resultados.
		if (!string.IsNullOrEmpty(K.Text) && !string.IsNullOrEmpty(Nom.Text) && !string.IsNullOrEmpty(Mt.Text))
		{
			
			var Noom = Convert.ToString(Nom.Text);
			

			double libr,metros,kilos,Cent;
			kilos = Convert.ToDouble(K.Text);
			libr = kilos * 2.2;
			Libras.Text = libr.ToString("N2");
			metros = Convert.ToDouble(Mt.Text);
			Cent = metros * 100;
			Centimetros.Text = Cent.ToString();

		}
		else
		{
			DisplayAlert("Error", "Ingresen todos los datos", "Oki Doki Yo");
		}

	}
}

