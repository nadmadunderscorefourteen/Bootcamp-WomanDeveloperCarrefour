namespace DesafioDeProjeto.src.entities
{
    public class Knight : Character
    {

        public Knight(string Name, int Level, string HeroType)
        : base(Name, Level, HeroType) {
    
        }
        public override string Attack(int Attack)
        {
            if( Life > 0 )
            {
                if( Attack >= 25 && Attack <= 50 )
                {
                    return SpecialAttack(Attack);
                }
                else if( Attack < 25 && Attack > 0 )
                {
                return NormalAttack(Attack);
                }
                return "Invalid option, please choose another value";
            }
            else{
                return ExceptionLife(Attack);
            }
        }
        protected override string NormalAttack(int Normal)
        {
            LifeScore(Normal);
            return Name + Message() + "Sword Attack that coast " + Normal + " lifepoints";
        }
        protected override string SpecialAttack(int Special)
        {
            LifeScore(Special);
            return Name + Message() + "Special Attack of " + Special + "\nLife: " + Life; 
        }
        protected override string Message()
        {
            return " was struck by a ";
        }
        protected override void LifeScore(int NewLife)
        {
            if( Life > 0)
            {
                Life -= NewLife;
            }
            else
            {
                NewLife = 0;
                ExceptionLife(NewLife);
            }            
        }
        protected override string ExceptionLife(int ResultLife)
        {
            return "You had a Bloody Death";
        }
    }
}