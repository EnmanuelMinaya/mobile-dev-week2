﻿using P1Login.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1Login.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTPage : TabbedPage
    {
        public HomeTPage()
        {
            InitializeComponent();
            BindingContext = new HomeTViewModel();

        }
    }
}