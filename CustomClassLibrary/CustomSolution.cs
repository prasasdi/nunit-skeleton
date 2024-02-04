using System.Runtime.CompilerServices;

namespace CustomClassLibrary
{
    public class CustomSolution
    {
        /**
         * You could made an method either it static or public
         * What matter the most is how would it will be used for
         */

        public CustomSolution() 
        {

        } 

        public static int Foo(int x)
        {
            return x % 3;
        }
    }
}
