﻿#pragma checksum "C:\Users\Jesper\source\repos\Kommandobogen\KommandoBogApp\View\CalendarViewView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BEEB43E8BB275CAC426A8F3A889824B6"
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
                    this.StartDate = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 2:
                {
                    this.EndDate = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 3:
                {
                    this.SetActivity = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 4:
                {
                    this.Opret = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 5:
                {
                    this.Annuller = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 6:
                {
                    this.Ferie = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 7:
                {
                    this.Kursus = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 8:
                {
                    this.Vagt = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 9:
                {
                    this.Fri = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 10:
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
            case 11:
                {
                    this.CreateUserButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 12:
                {
                    this.ClickedDatesActivity = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 13:
                {
                    this.CreateActivityButton = (global::Windows.UI.Xaml.Controls.Button)(target);
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

