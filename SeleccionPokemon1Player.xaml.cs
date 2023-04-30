using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
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
    public sealed partial class SeleccionPokemon1Player : Page
    {
        public SeleccionPokemon1Player()
        {
            this.InitializeComponent();
            btnAceptarPokemon.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Evento ejecutado al pulsar
        /// la imagen de atrás en la interfaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgAtras_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Combate.frInicio.Navigate(typeof(Combate));
        }

        /// <summary>
        /// Cuando el pokemon es elegido
        /// </summary>
        /// <param name="nombrePk"></param>
        private void pokemonElegido(String nombrePk)
        {
            txtPokemonElegido.Text = "Ha elegido " + nombrePk + " para combatir";
            btnAceptarPokemon.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Evento ejecutado al hacer
        /// click en la imagen de Charmander
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgCharmander_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Charmander");
        }

        /// <summary>
        /// Evento ejecutado al
        /// hacer click en la imagen de Dragonite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgDragonite_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Dragonite"); ;
        }

        /// <summary>
        /// Evento ejecutado al
        /// hacer click en la imagen de Dragonite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgPokemon3_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Jigglypuff");
        }

        /// <summary>
        /// Evento ejecutado al
        /// hacer click en la imagen de Dragonite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgPokemon4_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Zapdos");
        }

        /// <summary>
        /// Evento lanzado al pulsar aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptarPokemon_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
