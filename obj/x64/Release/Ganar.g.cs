﻿#pragma checksum "C:\Repositorios\ipo2-pokeGo\Ganar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA7CCA9E124A5CB53A099620E5C8BF0AF7ADD9EB480268D6D5A50E092F447C2B"
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
    partial class Ganar : 
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
            case 1: // Ganar.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // Ganar.xaml line 18
                {
                    this.mediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.mediaElement).MediaEnded += this.MediaElement_MediaEnded;
                }
                break;
            case 3: // Ganar.xaml line 20
                {
                    this.imgAtras = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgAtras).PointerReleased += this.imgAtras_PointerReleased;
                }
                break;
            case 4: // Ganar.xaml line 21
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

