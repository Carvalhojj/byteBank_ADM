using byteBank_ADM.Employees;
using byteBank_ADM.Utility;

Employee employee = new Employee();

employee.Name = "Guilherme";
employee.CPF = "123.456.789-10";
employee.Salary = 5000;

Console.WriteLine("Meu nome é " + employee.Name + " e meu bônus é de: " + employee.GetBonus());


Director director = new Director();

director.Name = "Mary";
director.CPF = "123.456.589-11";
director.Salary = 10000;

Console.WriteLine("Meu nome é " + director.Name + " e meu bônus é de: " + director.GetBonus());


BonusAdm adm = new BonusAdm();

adm.Register(employee);
adm.Register(director);

Console.WriteLine("Total de bonificações: " + adm.TotalBonus);