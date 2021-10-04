using System;

namespace Object_Class
{
    // 引用类型 堆(heap)
    public class PhoneCustomer
    {
        public const string DayOfSendingBil = "SunDay";
        public int CustomerId;


        // 可以设置属性访问修饰符

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            private set => _firstName = value;
        }
        public string LastName;

        // 自动属性 属性初始化器
        public int Age { get; private set; } = 18;

        // 表达式体 属性
        public string FullName => $"{FirstName} {LastName}";
    }
    // 结构不同于类，结构是值类型，在栈(stack) 不支持继承
    struct PhoneCustomerStruct
    {
        public const string DayOfSendingBil = "SunDay";
        public int CustomerId;
        public string FirstName;
        public string LastName;
    }
}