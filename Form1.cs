using System;
using System.Windows.Forms;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>
namespace Actividad_Integradora_5_Problema_2
{
    public partial class Form1 : Form
    {
        CitaDental cita = new(0,0,0,0,0,0);
        public Form1()
        {
            InitializeComponent();
            lblTotal.Text = cita.SumaConsultorio.ToString();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string servicio = txtServicio.Text;
            
            switch (servicio.ToUpper())
            {
                case "EXTRACCIONES" or "1":
                    cita.CitaExtracciones();
                    break;
                case "LIMPIEZA" or "2":
                    cita.CitaLimpieza();
                    break;
                case "ENDODONCIA" or "3":
                    cita.CitaEndodoncia();
                    break;
                case "RADILOGIA DENTAL" or "4":
                    cita.CitaRadiologia();
                    break;
                case "PUENTE DENTAL" or "5":
                    cita.CitaPuenteDental();
                    break;
                default:
                    MessageBox.Show("Digite una opcion valida","Mensaje");
                    txtServicio.Text = string.Empty;
                    txtServicio.Focus();
                    break;
            }

            lblTotal.Text = cita.getSumaConsultorio().ToString();
            lblExtraccion.Text = cita.Extracciones.ToString();
            lblLimpieza.Text = cita.Limpieza.ToString();
            lblEndodoncia.Text = cita.Endodoncia.ToString();
            lblRadiologia.Text = cita.Radiologia.ToString();
            lblPuente.Text = cita.PuenteDental.ToString();
        }
    }
}
