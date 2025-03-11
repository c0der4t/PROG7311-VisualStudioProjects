// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MenuItem ThinkChickenCheeseTomato = new ThinCrust();

ThinkChickenCheeseTomato = new Chicken(ThinkChickenCheeseTomato);
ThinkChickenCheeseTomato = new Cheese(ThinkChickenCheeseTomato);
ThinkChickenCheeseTomato = new Tomot(ThinkChickenCheeseTomato);

System.Console.WriteLine($"{ThinkChickenCheeseTomato.GetDescription()} : {ThinkChickenCheeseTomato.GetPrice()}");