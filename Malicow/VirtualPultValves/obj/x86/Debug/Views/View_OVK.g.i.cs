﻿#pragma checksum "..\..\..\..\Views\View_OVK.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB7C597D9AA9BA2A3E7ADAB5FD976C00"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using VirtualPultValves.PultControl;
using VirtualPultValves.ViewModel;
using VirtualPultValves.Views;


namespace VirtualPultValves.Views {
    
    
    /// <summary>
    /// View_OVK
    /// </summary>
    public partial class View_OVK : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 10 "..\..\..\..\Views\View_OVK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VirtualPultValves.Views.View_OVK OVKControl;
        
        #line default
        #line hidden
        
        
        #line 1108 "..\..\..\..\Views\View_OVK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid groot;
        
        #line default
        #line hidden
        
        
        #line 1227 "..\..\..\..\Views\View_OVK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid OVK_Label;
        
        #line default
        #line hidden
        
        
        #line 1228 "..\..\..\..\Views\View_OVK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path OVK_Label1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VirtualPultValves;component/views/view_ovk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\View_OVK.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.OVKControl = ((VirtualPultValves.Views.View_OVK)(target));
            return;
            case 3:
            this.groot = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            
            #line 1140 "..\..\..\..\Views\View_OVK.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 1140 "..\..\..\..\Views\View_OVK.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Button_PreviewMouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OVK_Label = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.OVK_Label1 = ((System.Windows.Shapes.Path)(target));
            
            #line 1228 "..\..\..\..\Views\View_OVK.xaml"
            this.OVK_Label1.SizeChanged += new System.Windows.SizeChangedEventHandler(this.OVK_Label_SizeChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseDownEvent;
            
            #line 16 "..\..\..\..\Views\View_OVK.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.Button_PreviewMouseDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseUpEvent;
            
            #line 17 "..\..\..\..\Views\View_OVK.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.Button_PreviewMouseUp);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}
