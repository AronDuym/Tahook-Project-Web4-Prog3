namespace Tahook.Domain.Model
{
    public class LeaderBoard
    {

        public User User { get; set; }

        public Session Session{ get; set; }

        public int Score { get; set; }
    }
}
