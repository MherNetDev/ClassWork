using System;

delegate int Deleg(int n);

namespace DelegateAppl
{

    class TestDelegate
    {
        static void Main(string[] args)
        {
            Deleg deleg = new Deleg(DMethod);
            deleg += DMethod2;
            deleg += DMethod3;


            deleg(1);
        }

        public static int DMethod(int p)
        {
            Console.WriteLine(p);
            return p+1;
        }
        public static int DMethod2(int p)
        {
            Console.WriteLine(p+1);
            return p+2;
        }
        public static int DMethod3(int p)
        {
            Console.WriteLine(p+2);
            return p+3;
        }
    }
}