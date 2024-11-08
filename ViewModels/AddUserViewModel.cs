using RecordBook.Commands;
using RecordBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecordBook.ViewModels
{
    internal class AddUserViewModel
    {

        public AddUserViewModel()
        {
            WireCommands();
        }

        public string Name { get; set; }
        public string Email { get; set; }

        public ICommand AddUserCommand { get; set; }

        private void WireCommands()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private void AddUser(object obj)
        {
            UserManager.AddUser(new User() { Name= Name, Email= Email });
        }

        private bool CanAddUser(object obj)
        {
            //if (Name == null || Email == null)
            //{
            //    return false;
            //}
            
            return true;
        }
    }
}
