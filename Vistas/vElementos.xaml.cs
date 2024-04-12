using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jcajamarcaTS2.Vistas;

public partial class vElementos : ContentPage
{
	public vElementos()
	{
		InitializeComponent();
	}

private void btnParcial1_Clicked(object sender, EventArgs e)
    {
        int valorMaximo = 10; 
        int valorMinimo = 1; 
        if (Int32.TryParse(txtSeguimiento1.Text, out int seguimiento1))
        {
            if (seguimiento1 > valorMaximo)
            {
                DisplayAlert("Validación", "El valor ingresado en la Nota de Seguimiento 1 es mayor que " + valorMaximo, "OK");
            }
            else if (seguimiento1 < valorMinimo)
            {
                DisplayAlert("Validación", "El valor ingresado en la Nota de Seguimiento 1 es menor que " + valorMinimo, "OK");
            }
        }
        else
        {
             DisplayAlert("Error", "Introduce un valor válido", "OK");
        }

        if (Int32.TryParse(txtExamen1.Text, out int examen1))
        {
            if (examen1 > valorMaximo)
            {
                DisplayAlert("Validación", "El valor ingresado en la Nota de Exámen 1 es mayor que " + valorMaximo, "OK");
            }
            else if (examen1 < valorMinimo)
            {
                DisplayAlert("Validación", "El valor ingresado en la Nota de Exámen 1 es menor que " + valorMinimo, "OK");
            }
 
        }
        else
        {
             DisplayAlert("Error", "Introduce un valor válido", "OK");
        }

        if (pkAlumnos.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un Alumno", "cerrar");
        }
          else
        {
            try
            {
                Double a = float.Parse(txtSeguimiento1.Text);
                Double b = float.Parse(txtExamen1.Text);
                Double c;
                {
                    c = a*0.3 + b*0.2;
                    string cR = c.ToString("F2");
                    txtParcial1.Text = cR.ToString();
                }
               
            }
            catch
            {
                resultado.Text = "Error en la captura de datos";
            }

        }
     
    }
    private void pkAlumnos_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtSeguimiento1.Text = string.Empty;
        txtExamen1.Text = string.Empty;
        txtParcial1.Text = string.Empty ;
        txtSeguimiento2 .Text = string.Empty ;
        txtExamen2 .Text = string.Empty ;
        txtParcial2 .Text = string.Empty ;
        txtNotaFinal.Text = string.Empty ;
    }

    private void btnParcial2_Clicked(object sender, EventArgs e)
    {
        int valorMaximo = 10;
        int valorMinimo = 1;

        if (Int32.TryParse(txtSeguimiento2.Text, out int seguimiento2))
        {
            if (seguimiento2 > valorMaximo)
            {
                DisplayAlert("Validación", "El valor ingresado en la Nota de Seguimiento 2 es mayor que " + valorMaximo, "OK");
            }
            else if (seguimiento2 < valorMinimo)
            {

                DisplayAlert("Validación", "El valor ingresado en la Nota de Seguimiento 2 es menor que " + valorMinimo, "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Introduce un valor válido", "OK");
        }

        if (Int32.TryParse(txtExamen2.Text, out int examen2))
        {
            if (examen2 > valorMaximo)
            {
                DisplayAlert("Validación", "El valor ingresado en la Nota de Exámen 2 es mayor que " + valorMaximo, "OK");
            }
            else if (examen2 < valorMinimo)
            {
                DisplayAlert("Validación", "El valor ingresado en la Nota de Exámen 2 es menor que " + valorMinimo, "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Introduce un valor válido", "OK");
        }

        if (pkAlumnos.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un Alumno", "cerrar");
            
        }
        else
        {
           

            Double h = float.Parse(txtSeguimiento2.Text);
            Double i = float.Parse(txtExamen2.Text);
            Double j;
            Double k = float.Parse(txtParcial1.Text);
            //Double l = float.Parse(txtParcial2.Text);
            Double m;
            string kR = Math.Round(k, 2).ToString("#.0");
            //string lR = Math.Round(l, 2).ToString("#.0");
                       
                    j = h * 0.3 + i * 0.2;
                    string jR = j.ToString("F2");
                    txtParcial2.Text = jR.ToString();
     
                    m = k + j;
                    string mR = m.ToString("F2");

                    txtNotaFinal.Text = mR.ToString();
                    string estado;
                    

                    if (m >= 7)
                    {
                        estado = "Aprobado";
                    }
                    else if (m >= 5 && m <= 6.9)
                    {
                        estado = "Complementario";
                    }
                    else
                    {
                        estado = "REPROBADO";
                    }

           txtEstado.Text = estado.ToString();
            // DisplayAlert("RESULTADO", "PRIMER PARCIAL: " + kR + "\n SEGUNDO PARCIAL: " + m + " \n NOTA FINAL: " + mR + "\n ESTADO: " + estado + "\n Fecha " + fecha, "Cerrar");

        }
         
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
