namespace WebJokes.Models
{
    public class Jokes
    {
        public int ID { get; set; }
        public string JokePergunta { get; set; }
        public string JokeResposta { get; set; }

        public Jokes()
        {
            ID = 0;
            JokePergunta = string.Empty;
            JokeResposta = string.Empty;

        }
    }
}
