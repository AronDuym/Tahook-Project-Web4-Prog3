using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Host.ViewModels
{
    public class QuizViewModel : ViewModelBase
    {
        private int _id;
        private string _name;
        private string _pinCode;
        private DateTime _start;
        private DateTime _stop;
        private GameTopic _gameTopic;
        private int _userId;
        private List<User> _users;
        private List<Question> _questions;

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

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }

            }
        }

        public string PinCode
        {
            get
            {
                return _pinCode;
            }
            set
            {
                if (_pinCode != value)
                {
                    _pinCode = value;
                    RaisePropertyChanged();
                }

            }
        }

        public DateTime Start
        {
            get
            {
                return _start;
            }
            set
            {
                if (_start != value)
                {
                    _start = value;
                    RaisePropertyChanged();
                }

            }
        }

        public DateTime Stop
        {
            get
            {
                return _stop;
            }
            set
            {
                if (_stop != value)
                {
                    _stop = value;
                    RaisePropertyChanged();
                }

            }
        }

        public GameTopic GameTopic
        {
            get
            {
                return _gameTopic;
            }
            set
            {
                if (_gameTopic != value)
                {
                    _gameTopic = value;
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

        public List<Question> Questions
        {
            get
            {
                return _questions;
            }
            set
            {
                if (_questions != value)
                {
                    _questions = value;
                    RaisePropertyChanged();
                }

            }
        }

        public QuizViewModel(Quiz quiz)
        {
            Id = quiz.Id;
            Name = quiz.Name;
            PinCode = quiz.PinCode;
            Start = quiz.Start.DateTime;
            Stop= quiz.Stop.DateTime;
            GameTopic = quiz.GameTopic;
            UserId = quiz.UserId;
            Users = quiz.Users.ToList();
            Questions = quiz.Questions.ToList();

        }

    }
}
