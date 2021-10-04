using System;

namespace Object_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // new 创建实例

            // 类类型对象通过引用传递
            PhoneCustomer phoneCustomer = new PhoneCustomer();

            // 结构类型对象按值传递
            PhoneCustomerStruct phoneCustomerStruct=new PhoneCustomerStruct();


            // 匿名类型
            var caption = new
            {
                FirstName = "Jonty",
                LastName = "Wang",
            };

            Console.WriteLine(caption.LastName);
        }
    }
}
