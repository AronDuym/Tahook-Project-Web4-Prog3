using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.DTO.Model;

namespace Tahook.User.ViewModels
{
    public class GameTopicViewModel : ViewModelBase
    {
        private int _id;
        private string _description;
        private List<Quiz> _quizzes;

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

        public List<Quiz> Quizzes
        {
            get
            {
                return _quizzes;
            }
            set
            {
                if (_quizzes != value)
                {
                    _quizzes = value;
                    RaisePropertyChanged();
                }

            }
        }

        public GameTopicViewModel(GameTopic gameTopic)
        {
            Id= gameTopic.Id;
            Description= gameTopic.Description;
            Quizzes = gameTopic.Quizzes.ToList();
        }
    }
}
