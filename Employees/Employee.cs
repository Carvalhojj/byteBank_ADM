namespace byteBank_ADM.Employees;

public class Employee
{
    public string Name { get; set; }
    public string CPF { get; set; }
    public double Salary { get; set; }
    public virtual double GetBonus()
    {
        return this.Salary * 0.10;
    }
}
