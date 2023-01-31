using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.DTO.Model;

namespace Tahook.User.ViewModels
{
    public class QuizReportViewModel : ViewModelBase
    {
        private int _id;
        private int _score;
        private Question _question;
        private Answer _answer;
        private User _user;
        private DateTime _registrationTime;

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

        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                if (_score != value)
                {
                    _score = value;
                    RaisePropertyChanged();
                }

            }
        }

        public Question Question
        { 
            get
            {
                return _question;
            }
            set
            {
                if (_question != value)
                {
                    _question = value;
                    RaisePropertyChanged();
                }

            }
        }

        public Answer Answer
        {
            get
            {
                return _answer;
            }
            set
            {
                if (_answer != value)
                {
                    _answer = value;
                    RaisePropertyChanged();
                }

            }
        }

        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                if (_user != value)
                {
                    _user = value;
                    RaisePropertyChanged();
                }

            }
        }

        public DateTime RegistrationTime
        {
            get
            {
                return _registrationTime;
            }
            set
            {
                if (_registrationTime != value)
                {
                    _registrationTime = value;
                    RaisePropertyChanged();
                }

            }
        }

        public QuizReportViewModel(QuizReport quizReport)
        {
            Id= quizReport.Id;
            Score = quizReport.Score;
            Question= quizReport.Question;
            Answer = quizReport.Answer;
            User = quizReport.User;
            RegistrationTime = quizReport.RegistrationTime.DateTime;
        }
    }
}
