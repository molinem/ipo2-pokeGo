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
    public sealed partial class ucVisorJigglypuff : UserControl
    {
        DispatcherTimer dtRj;
        private double salud_pk = 100.0;
        private double energia_pk = 100.0;

        public ucVisorJigglypuff()
        {
            this.InitializeComponent();
            salud = salud_pk;
            energia = energia_pk;
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
        /// El pokemon realiza la animación de saludar
        /// </summary>
        public void saludar()
        {
            Storyboard sbSaludar = (Storyboard)this.Resources["Saludar"];
            sbSaludar.Begin();
        }

        /// <summary>
        /// El pokemon realiza la animación de cantar
        /// </summary>
        public void Cantar()
        {
            Storyboard sbCantar = (Storyboard)this.Resources["Cantar"];
            sbCantar.Begin();
        }

        /// <summary>
        /// El pokemon realiza la función de morir
        /// </summary>
        public void morir()
        {
            Storyboard sbmuerte = (Storyboard)this.Resources["muerte"];
            sbmuerte.Begin();
        }

        /// <summary>
        /// El pokemon realiza la función de recuperar
        /// </summary>
        public void recuperar()
        {
            Storyboard sbRecuperar = (Storyboard)this.Resources["Recuperar"];
            sbRecuperar.Begin();
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
            dtRj = new DispatcherTimer();
            dtRj.Interval = TimeSpan.FromMilliseconds(30);
            dtRj.Tick += pgMenos;
            dtRj.Start();
        }
    }
}
