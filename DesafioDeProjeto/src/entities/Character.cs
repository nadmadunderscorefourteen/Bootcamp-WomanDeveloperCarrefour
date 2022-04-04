namespace DesafioDeProjeto.src.entities
{
    public abstract class Character
    {
        public string Name { get = Name; set = value; }
        public string OpponentName;
        public int Life { get; set; }
        public int Level;
        public string HeroType;
        public int Hp { get; set; }
        public int Mp { get; set; }

        public Character(string OpponentName, int Level, string HeroType){
            this.OpponentName = OpponentName;
            Life = 500;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public abstract string Attack(int Attack);
        
        public abstract string NormalAttack(int Normal);
        
        public abstract string SpecialAttack(int Special);
        
        public abstract string Message();

        public abstract void LifeScore(int NewLife);

        public string ExceptionLife(int ResultLife)
        {
             return "You had a Bloody Death!";
        }
    }
}