namespace DesafioDeProjeto.src.entities
{
    public class WhiteWizard : Character
    {

        public WhiteWizard(string Name, string OpponentName, int Level, string HeroType)
        : base(Name, OpponentName, Level, HeroType) {
    
        }
        public override string Attack(int Attack)
        {
            if( Life > 0 )
            {
                if( Attack >= 20 && Attack <= 55 )
                {
                    return SpecialAttack(Attack);
                }
                else if( Attack < 20 && Attack > 0 )
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
            return OpponentName + Message() + "Light Orb that coast: " + Normal + " lifepoints";
        }

        protected override string SpecialAttack(int Special)
        {
            LifeScore(Special);
            return OpponentName + Message() + "Powerful Spell of " + Special + "\nLife: " + Life;
        }

        protected override string Message()
        {
            return " was charmed by a ";
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
             return "You had a Bloody Death!";
        }
    }
}