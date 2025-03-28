namespace TheatricalPlayers.Domain.Entidades
{
    public class Statement
    {
        public int Id { get; private set; }
        public string Content { get; private set; }

        public Statement(string content)
        {
            Content = content;
        }
    }
}
