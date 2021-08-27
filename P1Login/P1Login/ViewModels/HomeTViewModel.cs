using P1Login.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace P1Login.ViewModels
{
    public class HomeTViewModel : INotifyPropertyChanged
    {
        public MenuOption UpdateMenuOption { get; set; } = new MenuOption();
        public MenuOption AccountMenuOption { get; set; } = new MenuOption();
        public MenuOption VisibilityMenuOption { get; set; } = new MenuOption();
        public MenuOption DangerMenuOption { get; set; } = new MenuOption();
        public MenuOption PersonelMenuOption { get; set; } = new MenuOption();
        public MenuOption NewMenuOption { get; set; } = new MenuOption();


        public HomeTViewModel()
        {
            UpdateMenuOption.Title = "Actualizar";
            UpdateMenuOption.Image = "outline_update_24";
            UpdateMenuOption.Place = "9";

            AccountMenuOption.Title = "Cuenta";
            AccountMenuOption.Image = "outline_account_box_24";
            AccountMenuOption.Place = "4";

            VisibilityMenuOption.Title = "Visibilidad";
            VisibilityMenuOption.Image = "outline_visibility_off_24";
            VisibilityMenuOption.Place = "1";

            DangerMenuOption.Title = "Peligro";
            DangerMenuOption.Image = "outline_dangerous_24";
            DangerMenuOption.Place = "9";

            PersonelMenuOption.Title = "Personal";
            PersonelMenuOption.Image = "outline_account_box_24";
            PersonelMenuOption.Place = "4";

            NewMenuOption.Title = "Nuevo";
            NewMenuOption.Image = "outline_update_24";
            NewMenuOption.Place = "1";
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

/*   



            <controls:MenuOptionView
                Grid.Row="2"
                Grid.Column="0"
                MenuOptionIconImageSource="outline_update_24"
                MenuOptionPlaceQty="3"
                MenuOptionTitle="Actualizaciones" />

            <controls:MenuOptionView
                Grid.Row="2"
                Grid.Column="1"
                MenuOptionIconImageSource="outline_account_box_24"
                MenuOptionPlaceQty="2"
                MenuOptionTitle="Safety" />*/
