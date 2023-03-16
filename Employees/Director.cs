namespace byteBank_ADM.Employees;

public class Director : Employee
{
    public override double GetBonus()
    {
        return this.Salary + base.GetBonus();
    }
}
