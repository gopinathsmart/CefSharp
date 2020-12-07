using CefSharp;
using CefSharp.Enums;
using CefSharp.SchemeHandler;
using CefSharp.Structs;
using CefSharp.Wpf;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void browser_IsBrowserInitializedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // the browser control is initialized, now load the html

            this.webView1.LoadHtml("<html><head></head><body><h1>Hello, World!</h1></body></html>", "http://www.example.com/");
        }
    }
}