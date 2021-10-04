// See https://aka.ms/new-console-template for more information

using System;
using sample1.generic;

Console.WriteLine("Hello, World!");


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
CommonMethod.ShowName(d);

Console.ReadKey();
