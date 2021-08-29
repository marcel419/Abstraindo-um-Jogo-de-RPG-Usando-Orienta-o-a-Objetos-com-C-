namespace RPG_POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public override string Attack(){
            return this.Name + " " +"Lançou Magia de Fogo";
        }

          public string Attack(int Bonus){
                if( Bonus > 6){
                    return this.Name + " Lançou Magia Suprema " + Bonus;
                }else{
                    return this.Name + " Lançou uma Magia normal " + Bonus;
                }

        }
    }
}