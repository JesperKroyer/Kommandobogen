﻿#pragma checksum "C:\Users\Jesper\source\repos\Kommandobogen\KommandoBogApp\View\HelpView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D296899CEEC4F161F89C97DAAFD1084D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KommandoBogApp.View
{
    partial class HelpView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MenuBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.OverskriftBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.NavigationBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.HelpBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.HelpBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.HelpBlock3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.HelpBlock4 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.HelpBlock5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.HelpBlock6 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 107 "..\..\..\View\HelpView.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.HelpBlock6).SelectionChanged += this.HelpBlock6_SelectionChanged;
                    #line default
                }
                break;
            case 10:
                {
                    this.OverskriftBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.MAFraloginTest = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.NavnFraLoginTest = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.BrugerNavn = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.HjemKnap = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 15:
                {
                    this.Arbejdstid = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 16:
                {
                    this.Overblik = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 35 "..\..\..\View\HelpView.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Overblik).Click += this.LeavingPage;
                    #line default
                }
                break;
            case 17:
                {
                    this.Hjælp = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 18:
                {
                    this.Leder = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.Merarbejde = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 20:
                {
                    this.Statistik = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 21:
                {
                    this.Admin = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22:
                {
                    this.Opret_bruger = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 65 "..\..\..\View\HelpView.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Opret_bruger).Click += this.NavigateToPageOpretBruger;
                    #line default
                }
                break;
            case 23:
                {
                    this.Rediger_bruger = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 24:
                {
                    this.Logout = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 73 "..\..\..\View\HelpView.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Logout).Click += this.LeavingPage;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

