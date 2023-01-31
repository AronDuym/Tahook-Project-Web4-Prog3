using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.DTO.Model;

namespace Tahook.User.ViewModels
{
    public class AnswerViewModel : ViewModelBase
    {
        private int _id;
        private string _description;
        private bool _isCorrect;
        private int _questionId;
        private Question _question;
        private string _image;

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

        public bool IsCorrect
        {
            get
            {
                return _isCorrect;
            }
            set
            {
                if (_isCorrect != value)
                {
                    _isCorrect = value;
                    RaisePropertyChanged();
                }

            }
        }

        public int QuestionId
        {
            get
            {
                return _questionId;
            }
            set
            {
                if (_questionId != value)
                {
                    _questionId = value;
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

        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    RaisePropertyChanged();
                }

            }
        }

        public AnswerViewModel(Answer answer)
        {
            Id= answer.Id;
            Description= answer.Description;
            IsCorrect= answer.IsCorrect;
            QuestionId= answer.QuestionId;
            Question = answer.Question;
            Image= answer.Image;
        }

    }
}
