// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DbUtil one = DbUtil.getInstance();
one.count = 9000;

DbUtil two = DbUtil.getInstance();
System.Console.WriteLine(two.count);