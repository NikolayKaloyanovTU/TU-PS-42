using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            System.Console.WriteLine("Welcome");
            System.Console.WriteLine("User: " + _viewModel.Name);
            System.Console.WriteLine("Role: " + _viewModel.Role);
            System.Console.WriteLine("Pass: " + _viewModel.Password);
        }
    }
}