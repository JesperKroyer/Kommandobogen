﻿#pragma checksum "C:\Users\Jesper\source\repos\Kommandobogen\KommandoBogApp\View\CalendarViewView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0864B8BF6484CDB2BB81A73636E2DFCF"
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
    partial class CalendarViewView : 
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
                    this.SetActivity = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 2:
                {
                    this.Opret = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 3:
                {
                    this.Annuller = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 4:
                {
                    this.Ferie = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 5:
                {
                    this.Kursus = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 6:
                {
                    this.Vagt = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 7:
                {
                    this.Fri = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 8:
                {
                    this.CalendarView1 = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                    #line 60 "..\..\..\View\CalendarViewView.xaml"
                    ((global::Windows.UI.Xaml.Controls.CalendarView)this.CalendarView1).SelectedDatesChanged += this.CalendarView_OnSelectedDatesChanged;
                    #line 60 "..\..\..\View\CalendarViewView.xaml"
                    ((global::Windows.UI.Xaml.Controls.CalendarView)this.CalendarView1).CalendarViewDayItemChanging += this.CalendarView_CalendarViewDayItemChanging;
                    #line 60 "..\..\..\View\CalendarViewView.xaml"
                    ((global::Windows.UI.Xaml.Controls.CalendarView)this.CalendarView1).KeyDown += this.CalendarView1_OnKeyDown;
                    #line 60 "..\..\..\View\CalendarViewView.xaml"
                    ((global::Windows.UI.Xaml.Controls.CalendarView)this.CalendarView1).KeyUp += this.CalendarView1_OnKeyUp;
                    #line default
                }
                break;
            case 9:
                {
                    this.ClickedDatesActivity = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 10:
                {
                    this.CreateActivityButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 11:
                {
                    this.MenuBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 12:
                {
                    this.OverskriftBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13:
                {
                    this.NavigationBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 14:
                {
                    this.NavigationBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.OverskriftBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.MAFraloginTest = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.NavnFraLoginTest = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.BrugerNavn = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.HjemKnap = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 20:
                {
                    this.Arbejdstid = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 21:
                {
                    this.Overblik = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 98 "..\..\..\View\CalendarViewView.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Overblik).Click += this.LeavingPage;
                    #line default
                }
                break;
            case 22:
                {
                    this.Hjælp = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 23:
                {
                    this.Leder = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24:
                {
                    this.Merarbejde = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 25:
                {
                    this.Statistik = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 26:
                {
                    this.Admin = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27:
                {
                    this.Opret_bruger = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 110 "..\..\..\View\CalendarViewView.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Opret_bruger).Click += this.NavigateToPageOpretBruger;
                    #line default
                }
                break;
            case 28:
                {
                    this.Rediger_bruger = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 29:
                {
                    this.Logout = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 113 "..\..\..\View\CalendarViewView.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Logout).Click += this.LeavingPage;
                    #line default
                }
                break;
            case 30:
                {
                    global::Windows.UI.Xaml.Controls.Button element30 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 72 "..\..\..\View\CalendarViewView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element30).Click += this.SelfDestruct;
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

