﻿#pragma checksum "C:\Users\angel\Desktop\ipo2-pokeGo\PokeDex.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E6E50DAE695816B769D7E0EFA53021C3B10952254CB52CADB90277E812FB2873"
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
    partial class PokeDex : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PokeDex_obj12_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPokeDex_Bindings
        {
            private global::PokeGo.Pokemon dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;
            private global::Windows.UI.Xaml.Controls.TextBlock obj14;
            private global::Windows.UI.Xaml.Controls.Image obj15;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj13TextDisabled = false;
            private static bool isobj14TextDisabled = false;
            private static bool isobj15SourceDisabled = false;

            public PokeDex_obj12_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 37 && columnNumber == 67)
                {
                    isobj13TextDisabled = true;
                }
                else if (lineNumber == 38 && columnNumber == 67)
                {
                    isobj14TextDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 64)
                {
                    isobj15SourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 12: // PokeDex.xaml line 36
                        this.obj12 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 13: // PokeDex.xaml line 37
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 14: // PokeDex.xaml line 38
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 15: // PokeDex.xaml line 39
                        this.obj15 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj12.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::PokeGo.Pokemon) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IPokeDex_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::PokeGo.Pokemon)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::PokeGo.Pokemon obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Numero(obj.Numero, phase);
                        this.Update_Nombre(obj.Nombre, phase);
                        this.Update_Imagen(obj.Imagen, phase);
                    }
                }
            }
            private void Update_Numero(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // PokeDex.xaml line 37
                    if (!isobj13TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, obj.ToString(), null);
                    }
                }
            }
            private void Update_Nombre(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // PokeDex.xaml line 38
                    if (!isobj14TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj14, obj, null);
                    }
                }
            }
            private void Update_Imagen(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // PokeDex.xaml line 39
                    if (!isobj15SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj15, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // PokeDex.xaml line 1
                {
                    this.pokedex = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)this.pokedex).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // PokeDex.xaml line 17
                {
                    this.mediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.mediaElement).MediaEnded += this.MediaElement_MediaEnded;
                }
                break;
            case 3: // PokeDex.xaml line 33
                {
                    this.lstPokemon = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lstPokemon).SelectionChanged += this.lstPokemon_SelectionChanged;
                }
                break;
            case 4: // PokeDex.xaml line 45
                {
                    this.txtNombrePk = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // PokeDex.xaml line 46
                {
                    this.txtDescripcionPk = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // PokeDex.xaml line 47
                {
                    this.txtCategoriaPk = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // PokeDex.xaml line 48
                {
                    this.txtAlturaPk = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // PokeDex.xaml line 49
                {
                    this.txtPesoPk = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // PokeDex.xaml line 50
                {
                    this.imgPokedex = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10: // PokeDex.xaml line 51
                {
                    this.imgPokemon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 16: // PokeDex.xaml line 22
                {
                    this.txtFiltroNombre = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17: // PokeDex.xaml line 23
                {
                    this.btnLupa = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnLupa).Click += this.Filtrar_Click;
                }
                break;
            case 18: // PokeDex.xaml line 26
                {
                    this.btnActualizar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnActualizar).Click += this.btnActualizar_Click;
                }
                break;
            case 19: // PokeDex.xaml line 27
                {
                    this.imgActualizar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 20: // PokeDex.xaml line 24
                {
                    this.imgLupa = (global::Windows.UI.Xaml.Controls.Image)(target);
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
            switch(connectionId)
            {
            case 12: // PokeDex.xaml line 36
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element12 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    PokeDex_obj12_Bindings bindings = new PokeDex_obj12_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element12.DataContext);
                    element12.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element12, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element12, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
