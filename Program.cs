
using static System.Console;
using Projeto.src.Entities;

public class Program{


    public static void  Main(string[] args){

       Knight arus = new Knight("Arus ",23,"Knight");
       Wizzard wizzard = new Wizzard("wizzard ",23,"wizzard");

       WriteLine(wizzard.Attack(1));
       WriteLine(wizzard.Attack(7));
      
      

    }

}