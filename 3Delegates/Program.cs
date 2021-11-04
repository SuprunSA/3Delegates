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
        delegate Class1 GetNewClass1();
        delegate Class1 TransformClass1(Class1 class1);
        delegate string GetClass1Description(Class1 class1, string comment);

        GetNewClass1 Generator;
        TransformClass1 Transformer;

        event GetClass1Description OnDescribe;

        Class1(GetClass1Description d1, GetClass1Description d2)
        {
            OnDescribe += d1;
            OnDescribe += d2;
        }
    }
}