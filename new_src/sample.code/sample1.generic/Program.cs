// See https://aka.ms/new-console-template for more information

using System;
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

sample1.generic.Monitor.Show();




Console.ReadKey();
