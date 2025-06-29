using AbstractClass;

Employee emp1 = new PermanentEmployee();
emp1.Name = "Hanif";
emp1.PrintName();
Console.WriteLine(emp1.CalculateSalary());

Employee emp2 = new ContractEmployee();
emp2.Name = "Sabbir";
emp2.PrintName();
Console.WriteLine(emp2.CalculateSalary());