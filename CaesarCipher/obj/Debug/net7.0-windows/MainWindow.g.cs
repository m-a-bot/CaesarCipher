﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3CE52DC0F533C60A3D1007E72E771804E1B669DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CaesarCipher;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CaesarCipher {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmboxAlphabet;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SourceText;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EncryptionKey;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EncryptedText;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EncryptButton;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DecryptButton;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DecryptedText;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmboxAlphabet1;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SourceText1;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EncryptionKey1;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EncryptedText1;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EncryptBtn;
        
        #line default
        #line hidden
        
        
        #line 284 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOfSaveToFileHackedText;
        
        #line default
        #line hidden
        
        
        #line 294 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOfSaveToFileEncryptedText;
        
        #line default
        #line hidden
        
        
        #line 304 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HackBtn;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HackedText;
        
        #line default
        #line hidden
        
        
        #line 351 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SelectedKey;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CaesarCipher;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cmboxAlphabet = ((System.Windows.Controls.ComboBox)(target));
            
            #line 47 "..\..\..\MainWindow.xaml"
            this.cmboxAlphabet.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmboxAlphabet_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SourceText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.EncryptionKey = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.EncryptedText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.EncryptButton = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\MainWindow.xaml"
            this.EncryptButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DecryptButton = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\MainWindow.xaml"
            this.DecryptButton.Click += new System.Windows.RoutedEventHandler(this.DecryptButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DecryptedText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cmboxAlphabet1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 184 "..\..\..\MainWindow.xaml"
            this.cmboxAlphabet1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmboxAlphabet1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SourceText1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.EncryptionKey1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.EncryptedText1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.EncryptBtn = ((System.Windows.Controls.Button)(target));
            
            #line 262 "..\..\..\MainWindow.xaml"
            this.EncryptBtn.Click += new System.Windows.RoutedEventHandler(this.EncryptBtn_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 271 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 14:
            this.BtnOfSaveToFileHackedText = ((System.Windows.Controls.Button)(target));
            
            #line 289 "..\..\..\MainWindow.xaml"
            this.BtnOfSaveToFileHackedText.Click += new System.Windows.RoutedEventHandler(this.BtnOfSaveToFileHackedText_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.BtnOfSaveToFileEncryptedText = ((System.Windows.Controls.Button)(target));
            
            #line 299 "..\..\..\MainWindow.xaml"
            this.BtnOfSaveToFileEncryptedText.Click += new System.Windows.RoutedEventHandler(this.BtnOfSaveToFileEncryptedText_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.HackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 309 "..\..\..\MainWindow.xaml"
            this.HackBtn.Click += new System.Windows.RoutedEventHandler(this.HackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.HackedText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            this.SelectedKey = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

