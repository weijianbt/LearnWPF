using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordBook.Models
{
    public class UserManager
    {

        public static ObservableCollection<User> DatabaseUser = new ObservableCollection<User>()
        {
            new User { Name = "andy", Email="andy@hotmail.com"},
            new User { Name = "banana", Email="banana@hotmail.com"},
            new User { Name = "apple", Email="andappley@hotmail.com"},
            new User { Name = "carry", Email="carry@hotmail.com"},
            new User { Name = "john", Email="john@hotmail.com"},
            new User { Name = "melissa", Email="melissa@hotmail.com"}
        };

        public static ObservableCollection<User> GetUsers()
        {
            return DatabaseUser;
        }

        public static void AddUser(User user)
        {
            DatabaseUser.Add(user);
        }





    }
}
