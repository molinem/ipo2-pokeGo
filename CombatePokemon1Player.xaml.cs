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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PokeGo
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CombatePokemon1Player : Page
    {
        public static String pokemonSeleccionado;
        public static String pokemonDerecha;

        private UserControl poke_1;
        private UserControl poke_2;

        ucVisorCharmander charmander;
        ucVisorZapdos zapdos;
        ucVisorDragonite dragonite;

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
                    charmander = new ucVisorCharmander();
                    setUserUserControl(poke_1, charmander, relative_poke_izquierda);
                    animacPermanentes(charmander.animFuegos);
                    txtQueDebemosHacer.Text = txtQueDebemosHacer.Text + "Charmander?";
                    break;
                case "Zapdos":
                    zapdos = new ucVisorZapdos();
                    setUserUserControl(poke_1, zapdos, relative_poke_izquierda);
                    zapdos.animacion();
                    txtQueDebemosHacer.Text = txtQueDebemosHacer.Text + "Zapdos?";
                    break;
                case "Dragonite":
                    dragonite = new ucVisorDragonite();
                    setUserUserControl(poke_1, dragonite, relative_poke_izquierda);
                    txtQueDebemosHacer.Text = txtQueDebemosHacer.Text + "Dragonite?";
                    break;
                case "Jigglypuff":
                    
                    txtQueDebemosHacer.Text = txtQueDebemosHacer.Text + "Jigglypuff?";
                    break;
            }
        }

        private void loadRelativePanelDerecha()
        {
            Random r = new Random();
            int rand = r.Next(1, 4);
            switch (rand)
            {
                case 1:
                    charmander = new ucVisorCharmander();
                    setUserUserControl(poke_2, charmander, relative_poke_derecha);
                    animacPermanentes(charmander.animFuegos);
                    pokemonDerecha = "charmander";
                    break;
                case 2:
                    zapdos = new ucVisorZapdos();
                    setUserUserControl(poke_2, zapdos, relative_poke_derecha);
                    zapdos.animacion();
                    pokemonDerecha = "zapdos";
                    break;
                case 3:
                    dragonite = new ucVisorDragonite();
                    setUserUserControl(poke_2, dragonite, relative_poke_derecha);
                    pokemonDerecha = "dragonite";
                    break;
                case 4:
                    pokemonDerecha = "jigglypuff";
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
