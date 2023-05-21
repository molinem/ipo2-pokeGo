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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace PokeGo
{
    public sealed partial class ucVisorCharmander : UserControl
    {
        DispatcherTimer dtRj;

        public ucVisorCharmander()
        {
            this.InitializeComponent();
            salud = 100;
            energia = 120;
        }

        /// <summary>
        /// Hace visible los path de salud
        /// </summary>
        public void mostrarSalud()
        {
            this.salud1.Visibility = Visibility.Visible;
            this.salud2.Visibility = Visibility.Visible;
            this.salud3.Visibility = Visibility.Visible;
            this.salud4.Visibility = Visibility.Visible;
            this.salud5.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Oculta los path de salud
        /// </summary>
        public void ocultarSalud()
        {
            this.salud1.Visibility = Visibility.Collapsed;
            this.salud2.Visibility = Visibility.Collapsed;
            this.salud3.Visibility = Visibility.Collapsed;
            this.salud4.Visibility = Visibility.Collapsed;
            this.salud5.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Mostrar estrellas
        /// </summary>
        public void mostrarEstrellas()
        {
            this.estrella1.Visibility = Visibility.Visible;
            this.estrella2.Visibility = Visibility.Visible;
            this.estrella3.Visibility = Visibility.Visible;
            this.estrella4.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Ocultar estrellas
        /// </summary>
        public void ocultarEstrellas()
        {
            this.estrella1.Visibility = Visibility.Collapsed;
            this.estrella2.Visibility = Visibility.Collapsed;
            this.estrella3.Visibility = Visibility.Collapsed;
            this.estrella4.Visibility = Visibility.Collapsed;
        }

        //----------------------------------------
        //              ProgressBar
        //----------------------------------------

        /// <summary>
        /// Getter/ setter atributo pgSalud
        /// </summary>
        public double salud
        {
            get { return this.pgSalud.Value; }
            set { this.pgSalud.Value = value; }
        }

        /// <summary>
        /// Getter/setter atributo pgEnergia
        /// </summary>
        public double energia
        {
            get { return this.pgEnergia.Value; }
            set { this.pgEnergia.Value = value; }
        }

        //----------------------------------------
        //              storyBoard
        //----------------------------------------

        /// <summary>
        /// Getter/Setter Storyboard AnimacionFuego
        /// </summary>
        public Storyboard animFuegos
        {
            get { return this.AnimacionFuegos; }
            set { this.AnimacionFuegos = value; }
        }

        /// <summary>
        /// Getter/Setter Storyboard AnimacionNivel
        /// </summary>
        public Storyboard animNivel
        {
            get { return this.AnimacionNivel; }
            set { this.AnimacionNivel = value; }
        }

        /// <summary>
        /// Getter/Setter Storyboard AnimacionLogro
        /// </summary>
        public Storyboard animLogro
        {
            get { return this.AnimacionLogro; }
            set { this.AnimacionLogro = value; }
        }

        /// <summary>
        /// Getter/Setter Storyboard AnimacionSalud
        /// </summary>
        public Storyboard animSalud
        {
            get { return this.AnimacionSalud; }
            set { this.AnimacionSalud = value; }
        }

        /// <summary>
        /// Getter/Setter Storyboard AnimacionEstrellas
        /// </summary>
        public Storyboard animEstrellas
        {
            get { return this.AnimacionEstrellitas; }
            set { this.AnimacionEstrellitas = value; }
        }

        /// <summary>
        /// Getter/Setter Storyboard AnimacionMana
        /// </summary>
        public Storyboard animMana
        {
            get { return this.AnimacionMana; }
            set { this.animMana = value; }
        }

        /// <summary>
        /// Getter/Setter Storyboard AnimacionPgVida
        /// </summary>
        public Storyboard animPgVida
        {
            get { return this.AnimacionPgVida; }
            set { this.AnimacionPgVida = value; }
        }

        /// <summary>
        /// Getter/Setter Storyboard AnimacionPgEnergia
        /// </summary>
        public Storyboard animPgEnergia
        {
            get { return this.AnimacionPgEnergia; }
            set { this.AnimacionPgEnergia = value; }
        }

        /// <summary>
        /// Getter/Setter Storyboard AnimacionPgMana
        /// </summary>
        public Storyboard animPgMana
        {
            get { return this.AnimacionPgMana; }
            set { this.AnimacionPgMana = value; }
        }

        /// <summary>
        /// Decrementa la vida en la 
        /// progressBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void pgMenos(object sender, object e)
        {
            salud -= 0.5;
            if (salud == 0)
            {
                dtRj.Stop();
            }
        }

        /// <summary>
        /// Aumenta la vida en la progressBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void pgMayor(object sender, object e)
        {
            salud += 0.5;
        }

        /// <summary>
        /// Evento de subir vida
        /// </summary>
        /// <param name="cantidad"></param>
        public void subirVida(double cantidad)
        {
            salud -= cantidad;
            dtRj = new DispatcherTimer();
            dtRj.Interval = TimeSpan.FromMilliseconds(30);
            dtRj.Tick += pgMayor;
            dtRj.Start();
        }

        /// <summary>
        /// Evento de bajar vida
        /// </summary>
        /// <param name="cantidad"></param>
        public void bajarVida(double cantidad)
        {
            salud -= cantidad;

            dtRj = new DispatcherTimer();
            dtRj.Interval = TimeSpan.FromMilliseconds(30);
            dtRj.Tick += pgMenos;
            dtRj.Start();
        }



    }
}
