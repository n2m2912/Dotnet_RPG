using System.Collections.Generic;

namespace DOTNET_RPG.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoint { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public User User { get; set; }
        public Weapon Weapon { get; set; }
        public List<Skill> Skills { get; set; }
        public int Fights { get; set; }
        public int Vitories { get; set; }
        public int Defeats { get; set; }
    }
}