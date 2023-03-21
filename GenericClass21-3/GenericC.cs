using System;

namespace GenericClass21_3
{
    class MyGenericclass<T> {

        public T data { get; set; }
        public void Meth<T>(T value) {

            Console.WriteLine(value.GetType());
            Console.WriteLine("int");
        
        
        }
        public void Meth2<Y>(Y value)
        {

            Console.WriteLine("string");



        }


    }


}
