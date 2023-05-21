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
        /// Carga con el pokemon seleccionado
        /// previamente el Relative panel que
        /// contendrá el UserControl
        /// </summary>
        private void loadRelativePanel()
        {
            switch (pokemonSeleccionado)
            {
                case "Charmander":
                    charmander_1 = new ucVisorCharmander();
                    setUserUserControl(poke_1, charmander_1, relative_poke_izquierda);
                    animacPermanentes(charmander_1.animFuegos);
                    txtQueDebemosHacer.Text += "Charmander?";
                    break;
                case "Zapdos":
                    zapdos_1 = new ucVisorZapdos();
                    setUserUserControl(poke_1, zapdos_1, relative_poke_izquierda);
                    zapdos_1.animacion();
                    txtQueDebemosHacer.Text += "Zapdos?";
                    break;
                case "Dragonite":
                    dragonite_1 = new ucVisorDragonite();
                    setUserUserControl(poke_1, dragonite_1, relative_poke_izquierda);
                    dragonite_2.moverAlas();
                    txtQueDebemosHacer.Text += "Dragonite?";
                    break;
                case "Jigglypuff":
                    jigglypuff_1 = new ucVisorJigglypuff();
                    setUserUserControl(poke_1, jigglypuff_1, relative_poke_izquierda);
                    txtQueDebemosHacer.Text += "Jigglypuff?";
                    break;
            }
        }

        /// <summary>
        /// Cargamos un pokemon aleatorio 
        /// en el relative panel situado
        /// a la derecha de la ventana
        /// </summary>
        private void loadRelativePanelDerecha()
        {
            Random r = new Random();
            int rand = r.Next(1, 4);
            switch (rand)
            {
                case 1:
                    charmander_2 = new ucVisorCharmander();
                    setUserUserControl(poke_2, charmander_2, relative_poke_derecha);
                    animacPermanentes(charmander_2.animFuegos);
                    pokemonDerecha = "charmander";
                    break;
                case 2:
                    zapdos_2 = new ucVisorZapdos();
                    setUserUserControl(poke_2, zapdos_2, relative_poke_derecha);
                    zapdos_2.animacion();
                    pokemonDerecha = "zapdos";
                    break;
                case 3:
                    dragonite_2 = new ucVisorDragonite();
                    setUserUserControl(poke_2, dragonite_2, relative_poke_derecha);
                    dragonite_2.moverAlas();
                    pokemonDerecha = "dragonite";
                    break;
                case 4:
                    pokemonDerecha = "jigglypuff";
                    jigglypuff_2 = new ucVisorJigglypuff();
                    jigglypuff_2.saludar();
                    setUserUserControl(poke_2, jigglypuff_2, relative_poke_izquierda);
                    break;
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
        /// Evento del botón atacar de un pokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtacar_Click(object sender, RoutedEventArgs e)
        {
            switch (pokemonSeleccionado)
            {
                case "Charmander":
                    
                    break;
                case "Zapdos":
                    
                    break;
                case "Dragonite":
                    
                    break;
                case "Jigglypuff":
                    break;
            }
        }
    }
}
