using System;

namespace GenericClass21_3
{
    class Program
    {
        static void Main(string[] args)
        {

            MyGenericclass<string> myGenericclass = new MyGenericclass<string>();

            string mainVal =Console.ReadLine();
            if (int.TryParse(mainVal, out int val))
                myGenericclass.Meth(val);
            else
                myGenericclass.Meth2(mainVal);


        }
    }
}
