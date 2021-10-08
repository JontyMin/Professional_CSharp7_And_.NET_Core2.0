using System;

namespace sample1.generic
{
    public static class CommonMethod
    {
        public static void ShowTypeName(int i)
        {
            Console.WriteLine(i.GetType().Name);
        }

        public static void ShowTypeName(string i)
        {
            Console.WriteLine(i.GetType().Name);
        }

        public static void ShowTypeName(DateTime i)
        {
            Console.WriteLine(i.GetType().Name);
        }


        public static void ShowObjectName(object i)
        {
            Console.WriteLine(i.GetType().Name);
        }


        public static void ShowName<T>(T i)
        {
            Console.WriteLine(i?.GetType().Name);
        }
    }
}