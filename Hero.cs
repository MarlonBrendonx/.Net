namespace Projeto.src.Entities
{
    public abstract class Hero
    {

        public string Nome { get; set; }

        public int Level { get; set; } 
        
        public string HeroType { get; set; }

        public Hero(string Nome, int Level, string HeroType){
            
            this.Nome=Nome;
            this.Level=Level;
            this.HeroType=HeroType;

        }

        public Hero(){}

        public override string ToString(){
            return this.Nome; 
        }

        public virtual string Attack(){
            return this.Nome ; 
        }

        public virtual string Attack(int bonus){
            return this.Nome + "Atacou com espada com bonus" + bonus ; 
        }
    }
}