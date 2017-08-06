using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = ProjectA.TeamA;
using B = ProjectA.TeamB;

namespace Namespaces
{
    class Namespaces
    {
        static void Main()
        {
            //ProjectA.TeamA.ClassA.Print();
            //ClassA.Print(); //this is similar to the above line becauase in line 6 we specified 'using ProjectA.TeamA' ***before we add the A = ... and B = ...***

            //ClassA.Print(); //this will not run because the compiler doesn't know where you pulled ClassA from. It could be either from
                              //TeamA or TeamB. To fix this we can either write the full namespaces or use and alias (below)
            A.ClassA.Print();
            B.ClassA.Print();
        }
    }
}

/// <summary>
/// We removed this be we built another Class Library called ProjectA.TeamA
/// </summary>
/*
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print method from class ClassA, namespace TeamA, namespace ProjectA");
            }
        }
    }
}
*/

/*******************************************************************************************************************************/

    /// <summary>
/// We removed this be we built another Class Library called ProjectA.TeamA
/// </summary>

/*
namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B print method from class ClassA, namespace TeamB, namespace ProjectA");
            }
        }
    }
}
*/
