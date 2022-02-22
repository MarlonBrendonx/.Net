namespace Projeto.src.Entities
{
    public class Wizzard : Hero
    {

       public Wizzard(string Nome, int Level, string HeroType){
            
            this.Nome=Nome;
            this.Level=Level;
            this.HeroType=HeroType;

        }
        public override string Attack(){
             return this.Nome + "Lançou magia";
        }

        public override string Attack(int bonus){

             if( bonus > 6 )
              return this.Nome + "Lançou magia efetiva de bonus " + bonus;
             else
               return this.Nome + "Lançou magia com força fraca com bonus " + bonus;
        }
    }
}