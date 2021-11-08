using System;

namespace _3Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Class1
    {
        public delegate Class1 GetNewClass1();
        public delegate Class1 TransformClass1(Class1 class1);
        public delegate string GetClass1Description(Class1 class1, string comment);

        public GetNewClass1 Generator;
        public TransformClass1 Transformer;

        public event GetClass1Description OnDescribe;

        public Class1(GetClass1Description d1, GetClass1Description d2)
        {
            OnDescribe += d1;
            OnDescribe += d2;
        }
    }
}