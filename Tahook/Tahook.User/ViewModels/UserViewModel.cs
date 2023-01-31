using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.DTO.Model;

namespace Tahook.User.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private int _id;
        private string _userName;
        private string _email;
        private string _password;
        private Role _role;
        private Quiz _quiz;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }

            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    RaisePropertyChanged();
                }

            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    RaisePropertyChanged();
                }

            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    RaisePropertyChanged();
                }

            }
        }

        public Role Role
        {
            get
            {
                return _role;
            }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    RaisePropertyChanged();
                }

            }
        }

        public Quiz Quiz
        {
            get
            {
                return _quiz;
            }
            set
            {
                if (_quiz != value)
                {
                    _quiz = value;
                    RaisePropertyChanged();
                }

            }
        }

        public UserViewModel(User user)
        {
            Id = user.Id;
            UserName = user.UserName;
            Email = user.Email;
            Password = user.Password;
            Role = user.Role;
            Quiz = user.Quiz;
        }
    }
}
