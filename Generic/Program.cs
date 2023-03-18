using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datas <string> some = new Datas<string>();
            Datas datas = new Datas();
            datas.someT(5,'s');
        
        }

   
    }

    class Datas {



        public void someT<T>(T f,T r)
        {
            Console.WriteLine(f.GetType());
            Console.WriteLine(r.GetType());

        }

    }
}
