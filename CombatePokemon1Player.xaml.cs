using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

            recTurnoJugador2.Visibility = Visibility.Collapsed;
            txtTurnoJugador2.Visibility = Visibility.Collapsed;

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
            txtQueDebemosHacer.Visibility = Visibility.Collapsed;
            btnAtacar.Visibility = Visibility.Collapsed;
            btnCurar.Visibility = Visibility.Collapsed;
            btnSubirAtaque.Visibility = Visibility.Collapsed;
            btnRendirseCombate.Visibility = Visibility.Collapsed;

            recTurnoJugador2.Visibility = Visibility.Visible;
            txtTurnoJugador2.Visibility = Visibility.Visible;

        }

        /// <summary>
        /// Desbloquear al jugador 1
        /// </summary>
        private void unblockPlayer1()
        {
            txtQueDebemosHacer.Visibility = Visibility.Visible;
            btnAtacar.Visibility = Visibility.Visible;
            btnCurar.Visibility = Visibility.Visible;
            btnSubirAtaque.Visibility = Visibility.Visible;
            btnRendirseCombate.Visibility = Visibility.Visible;

            recTurnoJugador2.Visibility = Visibility.Collapsed;
            txtTurnoJugador2.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Cuando le toca al jugador 2
        /// en este caso es la máquina
        /// </summary>
        private async void turnoPlayer2()
        {
            await Task.Delay(3000);
            int g = generarAleatorio(1, 4);
            switch (g)
            {
                case 1:
                    curarPlayer2();
                    break;
                case 2:
                    subirAtaquePlayer2();
                    break;
                case 3:
                    atacarPlayer2();
                    break;
            }
        }

        /// <summary>
        /// Curamos al pokemon de la derecha
        /// </summary>
        private async void curarPlayer2()
        {
            txtTurnoJugador1.Text = pokemonDerecha + " usó curación";
            await Task.Delay(3000);
            double vidaMax = (double)generarAleatorio(5, 14);
            switch (pokemonDerecha)
            {
                case "Charmander":
                    charmander_2.subirVida(vidaMax);
                    break;
                case "Zapdos":
                    zapdos_2.subirVida(vidaMax);
                    break;
                case "Dragonite":
                    dragonite_2.subirVida(vidaMax);
                    break;
                case "Jigglypuff":
                    jigglypuff_2.subirVida(vidaMax);
                    break;
            }
            txtTurnoJugador1.Text = "Es el turno del Jugador 1";
            unblockPlayer1();
        }

        /// <summary>
        /// Subir ataque al pokemon de la derecha
        /// </summary>
        private async void subirAtaquePlayer2()
        {
            txtTurnoJugador1.Text = pokemonDerecha + " usó subir ataque";
            await Task.Delay(3000);
            switch (pokemonDerecha)
            {
                case "Charmander":
                    charmander_2.subirDanio();
                    break;
                case "Zapdos":
                    zapdos_2.subirDanio();
                    break;
                case "Dragonite":
                    dragonite_2.subirDanio();
                    break;
                case "Jigglypuff":
                    jigglypuff_2.subirDanio();
                    break;
            }
            txtTurnoJugador1.Text = "Es el turno del Jugador 1";
            unblockPlayer1();
        }


        /// <summary>
        /// El pokemon de la derecha realiza un ataque
        /// </summary>
        private async void atacarPlayer2()
        {
            txtTurnoJugador1.Text = pokemonDerecha + " usó atacar";
            await Task.Delay(3000);
            //Animaciones ataques
            lanzarAnimacion(charmander_2.animAtaque);
            dragonite_2.luchar();
            jigglypuff_2.Cantar();
            zapdos_2.animacion();
            double danio = (double)generarAleatorio(5, 15);
            switch (pokemonSeleccionado)
            {
                case "Charmander":
                    dragonite_1.bajarVida(zapdos_1.danio_pk);
                    jigglypuff_1.bajarVida(dragonite_1.danio_pk);
                    zapdos_1.bajarVida(jigglypuff_1.danio_pk);
                    break;
                case "Zapdos":
                    dragonite_1.bajarVida(jigglypuff_1.danio_pk);
                    jigglypuff_1.bajarVida(zapdos_1.danio_pk);
                    charmander_1.bajarVida(jigglypuff_1.danio_pk);
                    break;
                case "Dragonite":
                    jigglypuff_1.bajarVida(zapdos_1.danio_pk);
                    charmander_1.bajarVida(dragonite_1.danio_pk);
                    zapdos_1.bajarVida(jigglypuff_1.danio_pk);
                    break;
                case "Jigglypuff":
                    dragonite_1.bajarVida(charmander_1.danio_pk);
                    charmander_1.bajarVida(jigglypuff_1.danio_pk);
                    zapdos_1.bajarVida(dragonite_1.danio_pk);
                    break;
            }

            if (!checkEstadoPokemons2())//No tiene vida el pokemon 1
            {
                /// Gana la IA
                Combate.frInicio.Navigate(typeof(Ganar));
            }
            else
            {
                txtTurnoJugador1.Text = "Es el turno del Jugador 1";
                unblockPlayer1();
            }
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
        /// Comprueba la vida de los pokemons
        /// </summary>
        private Boolean checkEstadoPokemons()
        {
            Boolean tienenVida = true;
            if (charmander_2.salud <= 0 || dragonite_2.salud <= 0 || jigglypuff_2.salud <= 0 || zapdos_2.salud <= 0)
            {
                //Ganas el combate
                tienenVida = false;
            }
            return tienenVida;
        }

        /// <summary>
        /// Comprueba la vida de los pokemons (de la derecha)
        /// </summary>
        private Boolean checkEstadoPokemons2()
        {
            Boolean tienenVida = true;
            if (charmander_1.salud <= 0 || dragonite_1.salud <= 0 || jigglypuff_1.salud <= 0 || zapdos_1.salud <= 0)
            {
                //Ganas el combate
                tienenVida = false;
            }
            return tienenVida;
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
                    dragonite_2.bajarVida(zapdos_2.danio_pk);
                    jigglypuff_2.bajarVida(dragonite_2.danio_pk);
                    zapdos_2.bajarVida(jigglypuff_2.danio_pk);
                    break;
                case "Zapdos":
                    dragonite_2.bajarVida(jigglypuff_2.danio_pk);
                    jigglypuff_2.bajarVida(zapdos_2.danio_pk);
                    charmander_2.bajarVida(jigglypuff_2.danio_pk);
                    break;
                case "Dragonite":
                    jigglypuff_2.bajarVida(zapdos_2.danio_pk);
                    charmander_2.bajarVida(dragonite_2.danio_pk);
                    zapdos_2.bajarVida(jigglypuff_2.danio_pk);
                    break;
                case "Jigglypuff":
                    dragonite_2.bajarVida(charmander_2.danio_pk);
                    charmander_2.bajarVida(jigglypuff_2.danio_pk);
                    zapdos_2.bajarVida(dragonite_2.danio_pk);
                    break;
            }

            if (checkEstadoPokemons())
            {
                turnoPlayer2();
            }
            else
            {
                //Hemos ganado
                Combate.frInicio.Navigate(typeof(Ganar));
            }
        }

        /// <summary>
        /// Sube el ataque del pokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubirAtaque_Click(object sender, RoutedEventArgs e)
        {
            blockPlayer1();
            switch (pokemonSeleccionado)
            {
                case "Charmander":
                    charmander_1.subirDanio();
                    break;
                case "Zapdos":
                    zapdos_1.subirDanio();
                    break;
                case "Dragonite":
                    dragonite_1.subirDanio();
                    break;
                case "Jigglypuff":
                    jigglypuff_1.subirDanio();
                    break;
            }

            if (checkEstadoPokemons())
            {
                turnoPlayer2();
            }
        }

        /// <summary>
        /// Botón para curar a un pokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCurar_Click(object sender, RoutedEventArgs e)
        {
            blockPlayer1();
            double vidaMax = (double) generarAleatorio(5,14);
            switch (pokemonSeleccionado)
            {
                case "Charmander":
                    charmander_1.subirVida(vidaMax);
                    break;
                case "Zapdos":
                    zapdos_1.subirVida(vidaMax);
                    break;
                case "Dragonite":
                    dragonite_1.subirVida(vidaMax);
                    break;
                case "Jigglypuff":
                    jigglypuff_1.subirVida(vidaMax);
                    break;
            }

            if (checkEstadoPokemons())
            {
                turnoPlayer2();
            }
            else
            {
                Combate.frInicio.Navigate(typeof(Ganar));
            }
        }

        /// <summary>
        /// El jugador decide rendirse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRendirseCombate_Click(object sender, RoutedEventArgs e)
        {
            Combate.frInicio.Navigate(typeof(Rendirse));
        }
    }
}
