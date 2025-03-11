
lunch myOrder = lunch.getInstance();

myOrder.setLunchOrder("ham and cheese toasty ");

lunch order2 = lunch.getInstance();
order2.setLunchOrder("mayo on bread");

lunch order3 = lunch.getInstance();
System.Console.WriteLine(order3.getLunchOrder());
System.Console.WriteLine(myOrder.getLunchOrder());