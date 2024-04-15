using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jcajamarcaTS2.Vistas;

public partial class vElementos : ContentPage
{
	public vElementos()
	{
		InitializeComponent();
	}
    private void OnNumeroChanged(object sender, TextChangedEventArgs e)
    {
        if (!Double.TryParse(e.NewTextValue, out Double nota) || nota < 1 || nota > 10)
        {
            errorMessageLabel.Text = "El nota debe estar entre 1 y 10";
            errorMessageLabel1.Text = "El nota debe estar entre 1 y 10";
            errorMessageLabel2.Text = "El nota debe estar entre 1 y 10";
            errorMessageLabel3.Text = "El nota debe estar entre 1 y 10";
        }
        else
        {
            errorMessageLabel.Text = string.Empty;
            errorMessageLabel1.Text = string.Empty;
            errorMessageLabel2.Text = string.Empty;
            errorMessageLabel3.Text = string.Empty;
        }
    }

    private void btnParcial1_Clicked(object sender, EventArgs e)
    {
        if (!Double.TryParse(txtSeguimiento1.Text, out Double nota1) || nota1 < 1 || nota1 > 10)
        {
            errorMessageLabel.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel1.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel2.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel3.Text = "La nota debe estar entre 1 y 10";
            DisplayAlert("Alerta", "Ingrese los valores correctamente", "cerrar");
            return;

        }

      
        if (!Double.TryParse(txtExamen1.Text, out Double examen1) || examen1 < 1 || examen1 > 10)
        {
            errorMessageLabel.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel1.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel2.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel3.Text = "La nota debe estar entre 1 y 10";
            DisplayAlert("Alerta", "Ingrese los valores correctamente", "cerrar");
            return;
        }



        if (pkAlumnos.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un Alumno", "cerrar");
        }
          else
        {
            try
            {
                Double seg1 = float.Parse(txtSeguimiento1.Text);
                Double exa1= float.Parse(txtExamen1.Text);
                Double par1;
                {
                    par1 = seg1 * 0.3 + exa1 * 0.2;
                    string parR = par1.ToString("F2");
                    txtParcial1.Text = parR.ToString();
                }
               
            }
            catch
            {
                resultado.Text = "Error en la captura de datos";
            }

        }
     
    }


    private void btnParcial2_Clicked(object sender, EventArgs e)
    {
        if (!Double.TryParse(txtSeguimiento2.Text, out Double notaP2) || notaP2 < 1 || notaP2 > 10)
        {
            errorMessageLabel.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel1.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel2.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel3.Text = "La nota debe estar entre 1 y 10";
            DisplayAlert("Alerta", "Ingrese los valores correctamente", "cerrar");
            return;

        }
        if (!Double.TryParse(txtExamen2.Text, out Double examenP2) || examenP2 < 1 || examenP2 > 10)
        {
            errorMessageLabel.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel1.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel2.Text = "La nota debe estar entre 1 y 10";
            errorMessageLabel3.Text = "La nota debe estar entre 1 y 10";
            DisplayAlert("Alerta", "Ingrese los valores correctamente", "cerrar");
            return;
        }
        if (pkAlumnos.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un Alumno", "cerrar");
        }
        else
        {
           

            Double seg2 = float.Parse(txtSeguimiento2.Text);
            Double exa2 = float.Parse(txtExamen2.Text);
            Double par2;
            Double par1S2 = float.Parse(txtParcial1.Text);
            Double nfin;
            string par1S2R = par1S2.ToString("F2");
            par2 = seg2 * 0.3 + exa2 * 0.2;
                    string par2R = par2.ToString("F2");
                    txtParcial2.Text = par2R.ToString();

            nfin = par1S2 + par2;
                    string nfinR = nfin.ToString("F2");

                    txtNotaFinal.Text = nfinR.ToString();
                    string estado;                

                    if (nfin >= 7)
                    {
                        estado = "Aprobado";
                    }
                    else if (nfin >= 5 && nfin <= 6.9)
                    {
                        estado = "Complementario";
                    }
                    else
                    {
                        estado = "REPROBADO";
                    }

           txtEstado.Text = estado.ToString();       

        }
         
    }
    private bool validateEntry = true;
    private void pkAlumnos_SelectedIndexChanged(object sender, EventArgs e)
    {
        validateEntry = false;
        txtSeguimiento1.Text = string.Empty;
        txtExamen1.Text = string.Empty;
        txtParcial1.Text = string.Empty;
        txtSeguimiento2.Text = string.Empty;
        txtExamen2.Text = string.Empty;
        txtParcial2.Text = string.Empty;
        txtNotaFinal.Text = string.Empty;
    }

    private void btnEstado_Clicked(object sender, EventArgs e)
    {
        if (pkAlumnos.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un Alummno e ingrese sus calificaciones", "cerrar");

        }
        else
        {
            string parcial1 = txtParcial1.Text;
            string parcial2 = txtParcial2.Text;
            string notaFinal = txtNotaFinal.Text;
            string estado = txtEstado.Text;
            string fecha = dpFecha.Date.ToString();

            DisplayAlert("RESULTADO", "PRIMER PARCIAL: " + parcial1 + "\n SEGUNDO PARCIAL: " + parcial2 + " \n NOTA FINAL: " + notaFinal + "\n ESTADO: " + estado + "\n Fecha " + fecha, "Cerrar");
        }
       
    }
}
