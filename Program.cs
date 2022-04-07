using System;
namespace sample1
{
    class input
        
    {
        static void Main(string[] args)
        {
            student shane = new student("shane",100);
       
            //shane.getDetail(834,"shane shih",99,98,93);
            shane.average();
            shane.display();
            student shih = new student("shih", 99);
            
            //shane.getDetail(834,"shane shih",99,98,93);
            shane.average();
            shane.display();
            
        }
        
    }
}