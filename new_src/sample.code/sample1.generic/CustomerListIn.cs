// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Collections.Generic;
using sample1.generic;


Console.WriteLine("Hello, World!");
/*Console.WriteLine(typeof(List<int>));
Console.WriteLine(typeof(Dictionary<string,int>));

var i = 123;
var s = "Jonty";
var d = DateTime.Now;

Console.WriteLine("***************CommonMethod*************");
// int
CommonMethod.ShowTypeName(i);
// string
CommonMethod.ShowTypeName(s);
// datetime
CommonMethod.ShowTypeName(d);

Console.WriteLine("***************ObjectMethod*************");
// int
CommonMethod.ShowObjectName(i);
// string
CommonMethod.ShowObjectName(s);
// datetime
CommonMethod.ShowObjectName(d);


Console.WriteLine("***************GenericMethod*************");
// int
CommonMethod.ShowName(i);
// string
CommonMethod.ShowName(s);
// datetime
CommonMethod.ShowName(d);*/

// sample1.generic.Monitor.Show();

/*ArrayList arrayList = new ArrayList
{
    123,
    "jonty",
    DateTime.Now
};

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}


List<int> arrInts = new List<int>
{
    1,
    2,
    3
};*/


/*var docs = new DocumentManager<Document>();
docs.AddDocument(new Document("AAA","Test aaa"));
docs.AddDocument(new Document("BBB","Test bbb"));
docs.DisplayAllDocuments();

if (docs.IsAvailable)
{
    var doc = docs.GetDocument();
    Console.WriteLine($"{doc.Title}:{doc.Content}");
}*/


/*
StaticDemo<string>.x = 4;
StaticDemo<int>.x = 5;
Console.WriteLine(StaticDemo<string>.x);


Console.ReadKey();


public abstract class Calc<T>
{
    public abstract T Add(T x, T y);
}

public class IntCalc : Calc<int>
{
    public override int Add(int x, int y)
    {
        return x + y;
    }
}


public class StaticDemo<T>
{
    public static int x;
}*/

Animal animal = new Animal();
Cat cat = new Cat();

Animal animal1 = new Cat();

List<Animal> animals = new List<Animal>();
List<Cat>cats= new List<Cat>();

IEnumerable<Animal> list = new List<Cat>();

ICustomerListOut<Animal> list1 = new CustomerListOut<Cat>();
ICustomerListIn<Cat> list2 = new CustomerListIn<Animal>();

public class CustomerListIn<T> : ICustomerListIn<T>
{
    public void Show(T t)
    {
        
    }
}