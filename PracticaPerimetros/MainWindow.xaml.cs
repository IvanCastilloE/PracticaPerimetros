using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaPerimetros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            controlPerimetroCirculo.Visibility = Visibility.Collapsed;
            controlPerimetroCuadrado.Visibility = Visibility.Collapsed;
            controlPerimetroTrapecio.Visibility = Visibility.Collapsed;
            controlPerimetroRectangulo.Visibility = Visibility.Collapsed;

            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Circulo
                    controlPerimetroCirculo.Visibility = Visibility.Visible;
                    break;
                case 1: //Cuadrado
                    controlPerimetroCuadrado.Visibility = Visibility.Visible;
                    break;
                case 2: //Trapecio
                    controlPerimetroTrapecio.Visibility = Visibility.Visible;
                    break;
                case 3: //Rectangulo
                    controlPerimetroRectangulo.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            float perimetro = 0.0f;

            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Circulo
                    float radio = float.Parse(controlPerimetroCirculo.txtRadio.Text);
                    perimetro = 2 * radio * 3.14159f;
                    break;
                    
                case 1: //Cuadrado
                    float lado = float.Parse(controlPerimetroCuadrado.txtLado.Text);
                    perimetro = 4 * lado;
                    break;

                case 2: //Trapecio
                    float ladoSuperior = float.Parse(controlPerimetroTrapecio.txtLadoSuperior.Text);
                    float ladoInferior = float.Parse(controlPerimetroTrapecio.txtLadoInferior.Text);
                    float ladoDerecho = float.Parse(controlPerimetroTrapecio.txtLadoDerecho.Text);
                    float ladoIzquierdo = float.Parse(controlPerimetroTrapecio.txtLadoIzquierdo.Text);
                    perimetro = ladoDerecho + ladoInferior + ladoIzquierdo + ladoSuperior;
                    break;

                case 3: //Rectangulo
                    float ladoMayor = float.Parse(controlPerimetroRectangulo.txtLadoMayor.Text);
                    float ladoMenor = float.Parse(controlPerimetroRectangulo.txtLadoMenor.Text);
                    perimetro=(ladoMayor*2)+(ladoMenor*2);
                    break;
                default:
                    break;

            }
            lblResultado.Text = perimetro.ToString();
        }
    }
}
