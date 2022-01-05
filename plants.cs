using System;

namespace inheritance
{
    public class plants:bios
    {
        protected void Photosynthesis()
        {
            Console.WriteLine("Plants photosynthesise"); 
        }
       
    }

    public class plantswithseeds:plants
    {    public plantswithseeds(){
        base.Photosynthesis() ;
    }
        public void growth()
        {
              Console.WriteLine("Platswithseed growth by seeds");   
        }
    }
}