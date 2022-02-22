namespace Projeto.src.Entities
{
    public class Knight : Hero 
    {
         public Knight(string Nome, int Level, string HeroType){
            
            this.Nome=Nome;
            this.Level=Level;
            this.HeroType=HeroType;

        }
        public override string Attack(){
             return this.Nome + "Atacou com espada";
        }

        public override string Attack(int bonus){
             return this.Nome + "Ataque de espada com bonus de " + bonus;
        }
    }
}