using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staicInstance
{
    class staicInstance
    {
        static void Main()
        {
            circle c1 = new circle(5);
            float area = c1.CalcArea();
            Console.WriteLine("Area = {0}", area);

            circle c2 = new circle(6);
            float area1 = c2.CalcArea();
            Console.WriteLine("Area = {0}", area1);
        }
    }

    class circle
    {
        //float pi = 3.141F; //2. the issue with this is that the value of pi is not going to change so if we keep creating a new insatance (c1, c2 etc.)
                             //the memory will keep creating a new instance of pi and will take up space. so we must make it static to stop the compiler
                             //from continuing to create a new instance of it
        static float pi;
        int radius;

        static circle() //4. this is using a static constructor and only used for static fields. Also, Because we didnt not put a public in front
                        //this can only be accessed by circle class and no other class can access it.
        {
            Console.WriteLine("Static Constructor Called");
            circle.pi = 3.141f;
        }
        
        public circle(int radius) //1. to initialize a class, we must use a constructor first. we dont need to initlize pi because we already did
                                  //we are creating a copy of radius adnd then we are
                                  //doing stuff with it (i.e. pi*r*r)
        {
            Console.WriteLine("Instance Constructor Called");
            this.radius = radius;
        }

        public float CalcArea()
        {
            return circle.pi * this.radius * this.radius; //3. instead of it being this.pi, we have to use circle.pi becuase the pi is static and no
                                                          //longer an instance so we cannot use "this" anymore. "this" is only used when creating
                                                          //an instance
        }
    }
}