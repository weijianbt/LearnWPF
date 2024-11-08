using RecordBook.Commands;
using RecordBook.Models;
using RecordBook.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RecordBook.ViewModels
{
    public class MainWindowViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainWindowViewModel()
        {
            Users = UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUserView addUserWindow = new AddUserView();
            addUserWindow.Owner = mainWindow;
            addUserWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWindow.ShowDialog();
        }
    }
}
