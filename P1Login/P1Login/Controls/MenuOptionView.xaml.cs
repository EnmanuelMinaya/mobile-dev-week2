using P1Login.ViewModels;
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
    public partial class MenuOptionView : ContentView
    {
        public MenuOptionView()
        {
            InitializeComponent();
            BindingContext = new HomeTViewModel();

        }
        public string MenuOptionTitle
        {
            get => (string)GetValue(MenuOptionView.MenuOptionTitleProperty);
            set => SetValue(MenuOptionView.MenuOptionTitleProperty, value);
        }

        public static readonly BindableProperty MenuOptionTitleProperty = BindableProperty.Create(
            "MenuOptionTitle",        // the name of the bindable property
            typeof(string),     // the bindable property type
            typeof(MenuOptionView),   // the parent object type
            string.Empty);      // the default value for the property

        public int MenuOptionPlaceQty
        {
            get => (int)GetValue(MenuOptionView.MenuOptionPlaceQtyProperty);
            set => SetValue(MenuOptionView.MenuOptionPlaceQtyProperty, value);
        }

        public static readonly BindableProperty MenuOptionPlaceQtyProperty = BindableProperty.Create(
            "MenuOptionPlaceQty",        // the name of the bindable property
            typeof(int),     // the bindable property type
            typeof(MenuOptionView),   // the parent object type
            0);      // the default value for the property

        public string MenuOptionIconImageSource
        {
            get => (string)GetValue(MenuOptionView.MenuOptionIconImageSourceProperty);
            set => SetValue(MenuOptionView.MenuOptionIconImageSourceProperty, value);
        }

        public static readonly BindableProperty MenuOptionIconImageSourceProperty = BindableProperty.Create(
            "MenuOptionIconImageSource",        // the name of the bindable property
            typeof(string),     // the bindable property type
            typeof(MenuOptionView),   // the parent object type
            null);      // the default value for the property

    }
}