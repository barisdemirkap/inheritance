using System;

namespace inheritance
{
    class Program
    {
        static void Main (string[] args)
        {
            plantswithseeds plant1 = new plantswithseeds() ;
            animals animal1= new animals ();
            birds bird1 = new birds () ;

            
            
            
            bird1.fly() ;
            
             

            plant1.growth() ;
         

        }
    }
}