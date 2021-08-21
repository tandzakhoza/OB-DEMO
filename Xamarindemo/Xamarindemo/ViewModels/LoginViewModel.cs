﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarindemo.Views;

namespace Xamarindemo.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string confirm_password { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
