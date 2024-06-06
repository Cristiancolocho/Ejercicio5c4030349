namespace Ejercicio5c4030349;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

   

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Base.Text))
        {
            int Resultado, Resultado2, n1, n2;
            n1 = Convert.ToInt32(Altura.Text);
            n2 = Convert.ToInt32(Base.Text);
            Resultado = 2 * (n1 + n2);
            Resultado2 = n1 * n2;
            Result.Text = Resultado.ToString();
            Result2.Text = Resultado2.ToString();
        }
        else
        {
            DisplayAlert("Error", "Introduce todas las calificaciones", "ok");
        }
    }
}