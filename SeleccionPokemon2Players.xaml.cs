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
    public sealed partial class SeleccionPokemon2Player : Page
    {
        private String pokemonSeleccionado;
        private String pokemonSeleccionado2;

        public SeleccionPokemon2Player()
        {
            this.InitializeComponent();
            btnAceptarPokemon.Visibility = Visibility.Collapsed;
            pokemonSeleccionado = "";
            pokemonSeleccionado2 = "";
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
        private void pokemonElegido(String nombrePk,int op)
        {
            if (op == 1)
            {
                //primer pokemon
                txtPokemonElegido1.Text = "Ha elegido " + nombrePk + " para combatir";
                pokemonSeleccionado = nombrePk;
                btnAceptarPokemon.Visibility = Visibility.Visible;
            }
            else
            {
                //Segundo pokemopn
                txtPokemonElegido2.Text = "Ha elegido " + nombrePk + " para combatir";
                pokemonSeleccionado2 = nombrePk;
                btnAceptarPokemon.Visibility = Visibility.Visible;
            }
            
        }

        /// <summary>
        /// Evento ejecutado al hacer
        /// click en la imagen de Charmander
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgCharmander_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Charmander",1);
        }

        /// <summary>
        /// Evento ejecutado al
        /// hacer click en la imagen de Dragonite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgDragonite_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Dragonite",1);
        }

        /// <summary>
        /// Evento ejecutado al
        /// hacer click en la imagen de Dragonite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgPokemon3_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Jigglypuff",1);
        }

        /// <summary>
        /// Evento ejecutado al
        /// hacer click en la imagen de Dragonite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgPokemon4_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Zapdos",1);
        }

        /// <summary>
        /// Evento lanzado al pulsar aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptarPokemon_Click(object sender, RoutedEventArgs e)
        {
            if (pokemonSeleccionado.Equals("") || pokemonSeleccionado2.Equals(""))
            {
                
            }
            else
            {
                CombatePokemon2Player.setPokemonSeleccionado(pokemonSeleccionado, pokemonSeleccionado2);

                Combate.frInicio.Navigate(typeof(CombatePokemon2Player));
            }

            
        }

        /// <summary>
        /// Evento pk charmander2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgCharmander2_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Charmander", 2);
        }

        /// <summary>
        /// Evento dragonite2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgDragonite2_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Dragonite", 2);
        }

        /// <summary>
        /// Evento Jiggly 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgJiggly2_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Jigglypuff", 2);
        }

        /// <summary>
        /// Evento Zapdos2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgZapdos2_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            pokemonElegido("Zapdos", 2);
        }
    }
}
