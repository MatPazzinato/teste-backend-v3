namespace TheatricalPlayers.Domain.Entidades
{
    public class StatementPlay
    {
        public int Id { get; private set; }
        public int StatementId { get; private set; }
        public string Customer { get; private set; }
        public int PlayAudience { get; private set; }
        public string PlayName { get; private set; }
        public int PlayLines { get; private set; }
        public string PlayType { get; private set; }
                
        public StatementPlay(int statementId, string customer, int playAudiente, string playName, int playLines, string playType)
        {
            StatementId = statementId;
            Customer = customer;
            PlayAudience = playAudiente;
            PlayName = playName;
            PlayLines = playLines;
            PlayType = playType;
        }
    }

}
