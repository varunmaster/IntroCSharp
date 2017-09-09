using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums2
{
    class enums2
    {
        public static void Main()
        {
            ///<summary>
            ///2. the next two lines, we are adding another Gender type and we can add to that Gender type by either adding another integer or another type
            ///</summary>
            Gender gender = (Gender)3;
            int Num = (int)Gender.Unknown;

            int[] Values = (int[]) Enum.GetValues(typeof(Gender));
            foreach (int v in Values)
            {
                Console.WriteLine(v);
            }

            string [] Names = Enum.GetNames(typeof(Gender));
            foreach(string N in Names)
            {
                Console.WriteLine(N);
            }

        }
    }

    /// <summary>
    /// 1. we are just specifying that the integers mean their respective names.
    /// </summary>
    public enum Gender
    {
        Unknown = 1,
        Male = 2,
        Female = 3
    }

    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3,
    }
}
