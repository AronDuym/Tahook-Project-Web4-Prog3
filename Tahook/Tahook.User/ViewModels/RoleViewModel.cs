using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.DTO.Model;

namespace Tahook.User.ViewModels
{
    public class RoleViewModel : ViewModelBase
    {
        private int _id;
        private string _description;
        private int _userId;
        private List<User> _users;

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

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }

            }
        }

        public int UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                if (_userId != value)
                {
                    _userId = value;
                    RaisePropertyChanged();
                }

            }
        }

        public List<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                if (_users != value)
                {
                    _users = value;
                    RaisePropertyChanged();
                }

            }
        }

        public RoleViewModel(Role role)
        {
            Id = role.Id;
            Description = role.Description;
            UserId = role.UserId;
            Users = (List<User>)role.Users;
        }
    }
}
