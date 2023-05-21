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
    public sealed partial class ucVisorDragonite : UserControl
    {

        private double salud_pk = 100.0;
        private double energia_pk = 100.0;

        public ucVisorDragonite()
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
        /// Animación enfado
        /// </summary>
        public void enfadarse()
        {
            Storyboard sb = (Storyboard)FindName("enfado");
            sb.Begin();
        }

        /// <summary>
        /// Animación moverse
        /// </summary>
        public void desaparecer()
        {
            Storyboard sb = (Storyboard)FindName("Moverse");
            sb.Begin();
        }

        /// <summary>
        /// Animación lucha
        /// </summary>
        public void luchar()
        {
            Storyboard sb = (Storyboard)FindName("lucha");
            sb.Begin();
        }

        /// <summary>
        /// Animación mover alas
        /// </summary>
        public void moverAlas()
        {
            Storyboard sb = (Storyboard)FindName("MoverAlas");
            sb.Begin();
        }
    }
}
