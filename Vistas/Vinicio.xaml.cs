using System;

namespace JMacasT2.Vistas;

public partial class Vinicio : ContentPage
{
    public Vinicio()
    {
        InitializeComponent();
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        // Obtener la fecha actual del sistema
        DateTime fechaActual = DateTime.Now;
        // se declara las variables que se usan para la conversion
        double nota1, examen1, nota2, examen2;

        if (double.TryParse(txtNota1.Text, out nota1) &&
            double.TryParse(txtExamen1.Text, out examen1) &&
            double.TryParse(txtNota2.Text, out nota2) &&
            double.TryParse(txtExamen2.Text, out examen2))
        {
            if (nota1 >= 0 && nota1 <= 10 &&
                examen1 >= 0 && examen1 <= 10 &&
                nota2 >= 0 && nota2 <= 10 &&
                examen2 >= 0 && examen2 <= 10)
            {
                double calNota1 = nota1 * 0.3;
                double calExamen1 = examen1 * 0.2;
                double parcial1 = calNota1 + calExamen1;

                double calNota2 = nota2 * 0.3;
                double calExamen2 = examen2 * 0.2;
                double parcial2 = calNota2 + calExamen2;

                double notaFinal = parcial1 + parcial2;

                if (pkestudiantes.SelectedIndex == -1)
                {
                    DisplayAlert("Alerta", "NO existe dato", "Cerrar");
                }
                else
                {
                    String dato = pkestudiantes.Items[pkestudiantes.SelectedIndex].ToString();


                    if (notaFinal >= 7 && notaFinal <= 10)
                    {
                        DisplayAlert("Alerta", "ESTUDIANTE: " + dato + "\nFECHA: " + fechaActual.ToString("dd/MM/yyyy") + "\nPARCIAL 1: " + parcial1.ToString() + "\nPARCIAL 2: " + parcial2.ToString() + "\nNOTA FINAL: " + notaFinal.ToString() + "\nAPROBADO", "Cerrar");
                    }
                    else
                    {

                        if (notaFinal >= 5 && notaFinal <= 6.9)
                        {
                            //DisplayAlert("Alerta", " COMPLEMENTARIO " + notaFinal.ToString(), "Cerrar");
                            DisplayAlert("Alerta", "ESTUDIANTE: " + dato + "\nFECHA: " + fechaActual.ToString("dd/MM/yyyy") + "\nPARCIAL 1: " + parcial1.ToString() + "\nPARCIAL 2: " + parcial2.ToString() + "\nNOTA FINAL: " + notaFinal.ToString() + "\nCOMPLEMENTARIO", "Cerrar");

                        }
                        else
                        {
                            if (notaFinal <= 5)
                            {
                                //DisplayAlert("Alerta", "REPROBADO " + notaFinal.ToString(), "Cerrar");
                                DisplayAlert("Alerta", "ESTUDIANTE: " + dato + "\nFECHA: " + fechaActual.ToString("dd/MM/yyyy") + "\nPARCIAL 1: " + parcial1.ToString() + "\nPARCIAL 2: " + parcial2.ToString() + "\nNOTA FINAL: " + notaFinal.ToString() + "\nREPROBADO", "Cerrar");
                            }

                        }
                    }
                    //DisplayAlert("Alerta", "Nota final: " + notaFinal.ToString(), "Cerrar");
                }
            }
            else
            {
                DisplayAlert("Error", "Las notas y exámenes deben estar entre 0 y 10.", "Aceptar");
            }
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese números válidos para las notas y los exámenes.", "Aceptar");
            }
        }
    }

  



    
