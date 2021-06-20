namespace DOTNET_RPG.Dtos.Fight
{
    public class HighScoreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fights { get; set; }
        public int Defeateds { get; set; }
        public int Victories { get; set; }
    }
}