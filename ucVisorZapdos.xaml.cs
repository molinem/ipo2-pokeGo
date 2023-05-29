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
    public sealed partial class ucVisorZapdos : UserControl
    {
        Storyboard sbOjoDer;
        Storyboard sbVolar;
        Storyboard sbOjoIzq;

        DispatcherTimer dtRj;
        private double salud_pk = 100.0;
        private double energia_pk = 100.0;
        public double danio_pk = 10.0;
        public double danio_rival_pk;

        public ucVisorZapdos()
        {
            this.InitializeComponent();
            salud = 50;
            energia = 50;
        }

        /// <summary>
        /// Animación inicial
        /// </summary>
        public async void animacion()
        {
            sbOjoDer = (Storyboard)this.ePupilaDer.Resources["sbColorOjoDerKey"];
            sbOjoIzq = (Storyboard)this.ePupilaIzq.Resources["sbColorOjoIzqKey"];
            sbVolar = (Storyboard)this.Resources["Vuelo"];
            sbVolar.Begin();
            sbOjoDer.Begin();
            sbOjoIzq.Begin();
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

        /// <summary>
        /// Daño que hace el pokemon
        /// </summary>
        public double danio_rival_pk_set
        {
            get { return this.danio_rival_pk; }
            set { this.danio_rival_pk = value; }
        }

        //----------------------------------------
        //              storyBoard
        //----------------------------------------

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
        /// Decrementa la vida en la 
        /// progressBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void pgMenos(object sender, object e)
        {
            salud -= 0.5;
            if (salud <= salud_pk || salud == 0)
            {
                dtRj.Stop();
            }
        }

        /// <summary>
        /// Aumenta la vida en la progressBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void pgMayor(object sender, object e)
        {
            if (salud == 100)
            {
                dtRj.Stop();
            }
            else
            {
                salud += 0.5;
                dtRj.Stop();
            }
        }

        /// <summary>
        /// Evento de subir vida
        /// </summary>
        /// <param name="cantidad"></param>
        public void subirVida(double cantidad)
        {
            salud += cantidad;
            dtRj = new DispatcherTimer();
            dtRj.Interval = TimeSpan.FromMilliseconds(10);
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
            salud -= danio_rival_pk;
            dtRj = new DispatcherTimer();
            dtRj.Interval = TimeSpan.FromMilliseconds(30);
            dtRj.Tick += pgMenos;
            animacion();
            dtRj.Start();
        }

        /// <summary>
        /// Decrementa la vida en la 
        /// progressBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void subirEnergia(object sender, object e)
        {
            energia += 4;
            if (energia <= energia_pk || energia == 0)
            {
                dtRj.Stop();
            }
        }

        /// <summary>
        /// Sube el daño que hace el pokemon
        /// </summary>
        public void subirDanio()
        {
            if (danio_pk < 100)
            {
                int danio_generado = new Random().Next(5, 20);
                danio_pk = danio_pk + danio_generado;
            }
            dtRj = new DispatcherTimer();
            dtRj.Interval = TimeSpan.FromMilliseconds(20);
            dtRj.Tick += subirEnergia;
            dtRj.Start();
        }
    }
}
