﻿#pragma checksum "C:\Repositorios\ipo2-pokeGo\Combate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0CAD3FF5BB7FA815E88EC91D76C6749D6DD8E3241904EA67AD245228F4B8BF91"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokeGo
{
    partial class Combate : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Combate.xaml line 21
                {
                    this.imgFondo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3: // Combate.xaml line 29
                {
                    this.txt1Jugador = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Combate.xaml line 30
                {
                    this.btnUnJugador = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnUnJugador).Click += this.btnUnJugador_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnUnJugador).GettingFocus += this.btnUnJugador_GettingFocus;
                }
                break;
            case 5: // Combate.xaml line 34
                {
                    this.txt2Jugador = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Combate.xaml line 35
                {
                    this.btnDosJugador = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDosJugador).Click += this.btnDosJugador_Click;
                }
                break;
            case 7: // Combate.xaml line 36
                {
                    this.imgVolto2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8: // Combate.xaml line 31
                {
                    this.imgVolto1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9: // Combate.xaml line 26
                {
                    this.imgCombate = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

