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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace PokeGo
{
    /// <summary>
    /// Clase encargada de realizar el combate pokemon
    /// </summary>
    public sealed partial class CombatePokemon1Player : Page
    {
        /// <summary>
        /// Variables donde almacenamos el nombre de los pokemons
        /// </summary>
        public static String pokemonSeleccionado;
        public static String pokemonDerecha;

        private UserControl poke_1;
        private UserControl poke_2;

        ucVisorCharmander charmander_1;
        ucVisorZapdos zapdos_1;
        ucVisorDragonite dragonite_1;
        ucVisorJigglypuff jigglypuff_1;

        ucVisorCharmander charmander_2;
        ucVisorZapdos zapdos_2;
        ucVisorDragonite dragonite_2;
        ucVisorJigglypuff jigglypuff_2;

        public CombatePokemon1Player()
        {
            this.InitializeComponent();
            poke_1 = null;
            poke_2 = null;

            //Inicialización pokemons
            charmander_1 = new ucVisorCharmander();
            zapdos_1 = new ucVisorZapdos();
            dragonite_1 = new ucVisorDragonite();
            jigglypuff_1 = new ucVisorJigglypuff();

            charmander_2 = new ucVisorCharmander();
            zapdos_2 = new ucVisorZapdos();
            dragonite_2 = new ucVisorDragonite();
            jigglypuff_2 = new ucVisorJigglypuff();

            loadRelativePanel();
            loadRelativePanelDerecha();
        }

        /// <summary>
        /// Establece el control de usuario
        /// </summary>
        /// <param name="establecer_poke_activo"></param>
        /// <param name="poke_seleccionado_usu"></param>
        /// <param name="panel"></param>
        private void setUserUserControl(UserControl establecer_poke_activo, UserControl poke_seleccionado_usu, RelativePanel panel)
        {
            if(establecer_poke_activo == null){
                establecer_poke_activo = poke_seleccionado_usu;
                panel.Children.Add(poke_seleccionado_usu);
            }
            else
            {
                panel.Children.Clear();
            }
        }

        /// <summary>
        /// Establecer el pokemon 
        /// seleccionado de otra ventana
        /// </summary>
        /// <param name="pk"></param>
        public static void setPokemonSeleccionado(String pk)
        {
            pokemonSeleccionado = pk;
        }
        
        /// <summary>
        /// Genera un número aleatorio dado
        /// el límite inferior y superior
        /// </summary>
        /// <param name="limiteInferior"></param>
        /// <param name="limiteSuperior"></param>
        /// <returns></returns>
        private int generarAleatorio(int limiteInferior, int limiteSuperior)
        {
            Random r = new Random();
            int rand = r.Next(limiteInferior, limiteSuperior);
            return rand;
        }

        /// <summary>
        /// Carga con el pokemon seleccionado
        /// previamente el Relative panel que
        /// contendrá el UserControl
        /// </summary>
        private void loadRelativePanel()
        {
            //panel izquierda
            switch (pokemonSeleccionado)
            {
                case "Charmander":
                    txtQueDebemosHacer.Text += "Charmander?";
                    setUserUserControl(poke_1, charmander_1, relative_poke_izquierda);
                    lanzarAnimacion(charmander_1.animFuegos);
                    break;
                case "Zapdos":
                    txtQueDebemosHacer.Text += "Zapdos?";
                    setUserUserControl(poke_1, zapdos_1, relative_poke_izquierda);
                    zapdos_1.animacion();
                    break;
                case "Dragonite":
                    txtQueDebemosHacer.Text += "Dragonite?";
                    setUserUserControl(poke_1, dragonite_1, relative_poke_izquierda);
                    dragonite_2.moverAlas();
                    break;
                case "Jigglypuff":
                    txtQueDebemosHacer.Text += "Jigglypuff?";
                    setUserUserControl(poke_1, jigglypuff_1, relative_poke_izquierda);
                    jigglypuff_1.saludar();
                    break;
            }
        }

        /// <summary>
        /// Carga el relative Panel de la
        /// derecha con un pokemon aleatorio
        /// </summary>
        private void loadRelativePanelDerecha()
        {
            int rand = generarAleatorio(1, 4);
            switch (rand)
            {
                case 1:
                    setUserUserControl(poke_2, charmander_2, relative_poke_derecha);
                    animacPermanentes(charmander_2.animFuegos);
                    pokemonDerecha = "Charmander";
                    break;
                case 2:
                    setUserUserControl(poke_2, zapdos_2, relative_poke_derecha);
                    zapdos_2.animacion();
                    pokemonDerecha = "Zapdos";
                    break;
                case 3:
                    setUserUserControl(poke_2, dragonite_2, relative_poke_derecha);
                    dragonite_2.moverAlas();
                    pokemonDerecha = "Dragonite";
                    break;
                case 4:
                    jigglypuff_2.saludar();
                    setUserUserControl(poke_2, jigglypuff_2, relative_poke_izquierda);
                    pokemonDerecha = "Jigglypuff";
                    break;
            }

            if (pokemonSeleccionado.Equals(pokemonDerecha))
            {
                relative_poke_derecha.Children.Clear();
                loadRelativePanelDerecha();
            }
        }

        /// <summary>
        /// Evento ejecutado al pulsar
        /// la imagen de atrás en la interfaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgAtras_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Combate.frInicio.Navigate(typeof(SeleccionPokemon1Player));
        }


        /// <summary>
        /// Lanza animaciones permanentes
        /// </summary>
        /// <param storyBoard="sbA"></param>
        private void animacPermanentes(Storyboard sbA)
        {
            if (sbA != null)
            {
                sbA.RepeatBehavior = RepeatBehavior.Forever;
                sbA.Begin();
            }
        }

        /// <summary>
        /// Bloquea al jugador 1
        /// </summary>
        private void blockPlayer1()
        {

        }

        /// <summary>
        /// Método para lanzar animaciones
        /// </summary>
        /// <param name="sb"></param>
        private void lanzarAnimacion(Storyboard sb)
        {
            sb.Begin();
        }

        /// <summary>
        /// Evento del botón atacar de un pokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAtacar_Click(object sender, RoutedEventArgs e)
        {
            blockPlayer1();

            //Animaciones ataques
            lanzarAnimacion(charmander_1.animAtaque);
            dragonite_1.luchar();
            jigglypuff_1.Cantar();
            zapdos_1.animacion();
            double danio = (double) generarAleatorio(5, 15);
            switch (pokemonSeleccionado)
            {
                case "Charmander":
                    dragonite_2.bajarVida(danio);
                    jigglypuff_2.bajarVida(danio);
                    zapdos_2.bajarVida(danio);
                    break;
                case "Zapdos":
                    dragonite_2.bajarVida(danio);
                    jigglypuff_2.bajarVida(danio);
                    charmander_2.bajarVida(danio);
                    break;
                case "Dragonite":
                    jigglypuff_2.bajarVida(danio);
                    charmander_2.bajarVida(danio);
                    zapdos_2.bajarVida(danio);
                    break;
                case "Jigglypuff":
                    dragonite_2.bajarVida(danio);
                    charmander_2.bajarVida(danio);
                    zapdos_2.bajarVida(danio);
                    break;
            }
        }
    }
}
