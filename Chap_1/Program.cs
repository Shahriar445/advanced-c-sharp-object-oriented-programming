// called the first class and pass parameter 
Rectangel obj = new Rectangel(10, 20);

Rectangel obj2 = new Rectangel(30);

Console.WriteLine("Area of Rectangel height and width: " + obj.getArea());
Console.WriteLine("Area of Rectangel with side: " + obj2.getArea());

obj.height = 2;
obj.width = 3;
Console.WriteLine("After chang height and width: " + obj.getArea());