//Compile - Time Polymorphism(Static Polymorphism)
using Polymorphism;

Calculator cal = new Calculator();
int Sum1 = cal.Add(10, 20);
Console.WriteLine($"Sum1 er value : {Sum1}");

double Sum2 = cal.Add(5, 10);
Console.WriteLine($"Sum2 er Value : {Sum2}");

int Sum3 = cal.Add(10, 20 , 30);
Console.WriteLine($"Sum3 er value : {Sum3}");



//Run - Time Polymorphism(Dynamic Polymorphism)
Animal animal1 = new Cow();
animal1.MakeSound();

Animal animal2 = new Dog();
animal2.MakeSound();