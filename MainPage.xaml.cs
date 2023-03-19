using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace PokeGo
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(320, 320));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;

            fmMain.Navigate(typeof(Inicio));
            checkBackStack();
            SystemNavigationManager.GetForCurrentView().BackRequested += opcionVolver;
        }

        /// <summary>
        /// Para detectar cuando cambia el tamaño de 
        /// la pantallla y así adaptarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void MainPage_VisibleBoundsChanged(ApplicationView sender, object args)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width >= 720)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactInline;
                sView.IsPaneOpen = true;
            }
            else if (Width >= 360)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                sView.IsPaneOpen = false;
            }
            else
            {
                sView.DisplayMode = SplitViewDisplayMode.Overlay;
                sView.IsPaneOpen = false;
            }

        }

        /// <summary>
        /// Método encargado de implementar la 
        /// función de retroceso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionVolver(object sender, BackRequestedEventArgs e)
        {
            if (fmMain.BackStack.Any())
            {
                fmMain.GoBack();
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        /// <summary>
        /// Método encargado de comprobar si existe algún
        /// alguna pagina en la pila de navegación usando
        /// para ello la propiedad BackStack. Hace visible/collapse
        /// el botón de retroceso
        /// </summary>
        private void checkBackStack() 
        {
            if (fmMain.BackStack.Any())
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        /// <summary>
        /// Evento al pulsar el botón inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(Inicio));
            checkBackStack();
        }

        /// <summary>
        /// Evento al pulsar el boton pokeDex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPokedex_Click(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(PokeDex));
            checkBackStack();
        }

        /// <summary>
        /// Evento al pulsar el botón combate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCombate_Click(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(Combate));
            checkBackStack();
        }

        /// <summary>
        /// Evento al pulsar el botón captura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCaptura_Click(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(Captura));
            checkBackStack();
        }

        /// <summary>
        /// Evento click en el botón
        /// del menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sView.IsPaneOpen = !sView.IsPaneOpen;
        }
    }
}
