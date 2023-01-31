using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.Domain.Model;

namespace Tahook.Tests.Data
{
    public class DummyDbContext
    {
        public List<Answer> Answers { get; set; } //4 Answers
        public List<GameTopic> GameTopics { get; set; } //1 Game Topic
        public List<Question> Questions { get; set; } //1 Question
        public List<Quiz> Quizzes { get; set; } // 1 Quiz
        public List<QuizReport> QuizReports { get; set; } //1 QuizReport
        public List<Role> Roles { get; set; } //2 Roles Host & User
        public List<User> Users { get; set; } //2 Users Host & User

        public DummyDbContext()
        {
            Answers = new List<Answer>();
            GameTopics = new List<GameTopic>();
            Questions = new List<Question>();
            Quizzes= new List<Quiz>();
            QuizReports = new List<QuizReport>();
            Roles = new List<Role>();
            Users = new List<User>();

            //--------------------------------------------------------------------------------------------------------------------------------------

            Role role1 = new Role("Host", 1, new List<User>());
            Role role2 = new Role("User", 2, new List<User>());

            GameTopic gameTopic = new GameTopic("Wiskunde", new List<Quiz>());

            DateTime time = DateTime.Now;
            Quiz quiz = new Quiz("Een wiskundige test", "2023", time, time.AddHours(1), gameTopic, 1, new List<User>(), new List<Question>());

            User user1 = new User("Aron", "aron.duym@student.hogent.be", "Test123", role2, quiz);
            User user2 = new User("Luc Vervoort", "luc.vervoort@hogent.be", "ZwarteRidder123", role1, quiz);

            Question question = new Question("Wat is de stelling van Pythagoras?", true, 60, 1, quiz, new List<Answer>());

            Answer answer1 = new Answer("A² * B² = C²", false, 1, question, "foto1");
            Answer answer2 = new Answer("A² / B² = C²", false, 1, question, "foto2");
            Answer answer3 = new Answer("A² + B² = C²", true, 1, question, "foto3");
            Answer answer4 = new Answer("A² - B² = C²", false, 1, question, "foto4");

            QuizReport quizReport = new QuizReport(100, question, answer3, user2, time.AddMinutes(1));


            //--------------------------------------------------------------------------------------------------------------------------------------

            role1.Users.Add(user2);
            role2.Users.Add(user1);

            gameTopic.Quizzes.Add(quiz);

            quiz.Users.Add(user1);
            quiz.Users.Add(user2);

            quiz.Questions.Add(question);

            question.Answers.AddRange(new Answer[] { answer1, answer2, answer3, answer4 });

            //--------------------------------------------------------------------------------------------------------------------------------------

            Answers.AddRange(new Answer[] { answer1, answer2, answer3, answer4 });
            GameTopics.Add(gameTopic);
            Questions.Add(question);
            Quizzes.Add(quiz);
            QuizReports.Add(quizReport);
            Roles.AddRange(new Role[] {role1, role2});
            Users.AddRange(new User[] {user1,user2});

        }
    }
}
