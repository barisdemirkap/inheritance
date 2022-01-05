using System;

namespace inheritance
{
    public class animals:bios
    {   public animals () {
        base.breathing();
        base.feeding() ;
        base.pooping() ;

    }
       protected void adaptating ()
        {
            Console.WriteLine("animals adapting"); 
        }
       
    }

    public class reptiles:animals
    {   public reptiles(){
        base.adaptating() ;
        

    }
       public  void crawl ()
        {
            Console.WriteLine("reptiles crawl"); 
        }
    }
    public class birds:animals
    {   public birds() {
        base.adaptating() ;
      
    }
       public  void fly ()
        {
            Console.WriteLine("birds fly"); 
        }
    }
}