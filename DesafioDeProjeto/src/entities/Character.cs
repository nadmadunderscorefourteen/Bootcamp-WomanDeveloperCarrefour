namespace DesafioDeProjeto.src.entities
{
    public abstract class Character
    {
        public string Name;
        public int Life;
        public int Level;
        public string HeroType;
        public int Hp;
        public int Mp;
        public Character(string Name, int Level, string HeroType){
            this.Name = Name;
            Life = 0;
            this.Level = Level;
            this.HeroType = HeroType;
            Hp = 0;
            Mp = 0;
        }
        public abstract string Attack(int Attack);
        protected abstract string NormalAttack(int Normal);
        protected abstract string SpecialAttack(int Special);
        protected abstract string Message();
        protected abstract void LifeScore(int NewLife);
        protected abstract string ExceptionLife(int ResultLife);

    }
}