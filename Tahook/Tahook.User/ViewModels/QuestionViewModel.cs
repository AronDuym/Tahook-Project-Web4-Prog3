using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Host.ViewModels
{
    public class QuestionViewModel : ViewModelBase
    {
        private int _id;
        private string _description;
        private bool _isActive;
        private int _durationTime;
        private int _quizId;
        private Quiz _quiz;
        private List<Answer> _answers;

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

        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    RaisePropertyChanged();
                }

            }
        }

        public int DurationTime
        {
            get
            {
                return _durationTime;
            }
            set
            {
                if (_durationTime != value)
                {
                    _durationTime = value;
                    RaisePropertyChanged();
                }

            }
        }

        public int QuizId
        {
            get
            {
                return _quizId;
            }
            set
            {
                if (_quizId != value)
                {
                    _quizId = value;
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

        public List<Answer> Answers
        {
            get
            {
                return _answers;
            }
            set
            {
                if (_answers != value)
                {
                    _answers = value;
                    RaisePropertyChanged();
                }

            }
        }

        public QuestionViewModel(Question question)
        {
            Id = question.Id;
            Description = question.Description;
            IsActive = question.IsActive;
            DurationTime = question.DurationTime;
            QuizId = question.QuizId;
            Quiz = question.Quiz;
            Answers = question.Answers.ToList();
        }
    }
}
