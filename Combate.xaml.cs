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
    public sealed partial class Combate : Page
    {
        public static Frame frInicio;
        public Combate()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Establece la variable Frame
        /// </summary>
        /// <param name="fr"></param>
        public static void setFrame(Frame fr)
        {
            frInicio = fr;
        }

        /// <summary>
        /// Evento de hacer click
        /// en un jugador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnJugador_Click(object sender, RoutedEventArgs e)
        {
            frInicio.Navigate(typeof(SeleccionPokemon1Player));
        }

        /// <summary>
        /// Evento de hacer click
        /// en dos jugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDosJugador_Click(object sender, RoutedEventArgs e)
        {
            frInicio.Navigate(typeof(SeleccionPokemon2Players));
        }

        private void btnUnJugador_GettingFocus(UIElement sender, GettingFocusEventArgs args)
        {
            ToolTipService.SetToolTip(btnUnJugador, "Texto de Caption");
        }
    }
}
