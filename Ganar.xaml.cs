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

namespace PokeGo
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Ganar : Page
    {
        public Ganar()
        {
            this.InitializeComponent();
        }

        private void imgAtras_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Combate.frInicio.Navigate(typeof(Combate));
        }

        /// <summary>
        /// Se carga una vez el Page es cargado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string nombreArchivo = "ganar.mp4"; // Nombre del archivo
            string rutaCarpeta = "VIDEOS"; // Ruta relativa de la carpeta dentro del proyecto
            string videoFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), rutaCarpeta, nombreArchivo);

            // Establece la fuente del MediaElement como el archivo de video
            mediaElement.Source = new Uri(videoFilePath);
            mediaElement.IsMuted = true;
            mediaElement.Play();
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
