using System;

namespace sample1
{
    class student
    {
        int sID;
        public string name;
        int physics, chemistry, maths,total;
        decimal avg;
        public static int gsid;
        //member functions//
        public student()
        {
            gsid += 1;
            name = "loda lahsun";
            physics = 100;
            sID = gsid;
        }
        public student(string name,int physics)
        {
            gsid += 1;
            this.name = name;
            this.physics = physics;
            this.sID = gsid;
        }
        void getDetail()
        {
            Console.WriteLine("Enter the stduent ID: ");
            sID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the stduent: ");
            name= Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the physics mark of the stduent: ");
            physics=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the chemistry marks of the stduent: ");
            chemistry= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maths marks of the stduent: ");
            maths= Convert.ToInt32(Console.ReadLine());
        }

        public void getDetail(int id,string name,int physics,int chemistry,int maths)
        {
            sID = id;
            this.name = name;
            this.physics = physics;
            this.chemistry = chemistry;
            this.maths = maths;
        }

        public void average()
        {
            total = physics + chemistry + maths;
            avg = total / 3;
        }
        public void display()
        {
            Console.WriteLine($"Student ID :     {sID}");
            Console.WriteLine($"Name :     {name}");
            Console.WriteLine($"Physics marks :     {physics}");
            Console.WriteLine($"Chemistry marks :     {chemistry}");
            Console.WriteLine($"Math marks :     {maths}");
            Console.WriteLine($"Total marks :     {total}");
            Console.WriteLine($"Average marks :     {avg}");
            Console.WriteLine($"GSID :     {gsid}");
        }
        
    }
}
