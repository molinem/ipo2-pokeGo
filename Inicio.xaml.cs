using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PokeGo
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Inicio : Page
    {
        public Inicio()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Se carga una vez el Page es cargado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string rutaCarpeta = "Assets"; // Ruta relativa de la carpeta dentro del proyecto
            string nombreArchivo = "inicio.mp4"; // Nombre del archivo

            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
            string ruta = Path.Combine(directorioBase, rutaCarpeta, nombreArchivo);

            // Establece la fuente del MediaElement como el archivo de video
            if (ruta != null)
            {
                mediaElement.Source = new Uri(ruta);
                mediaElement.IsMuted = true;
                mediaElement.Play();
            }
            
        }

        /// <summary>
        /// Evento cuando acaba el vídeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            // Reinicia el video en bucle cuando se completa la reproducción
            mediaElement.Position = TimeSpan.Zero;
            mediaElement.Play();
        }
    }
}
