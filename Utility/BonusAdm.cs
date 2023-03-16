using byteBank_ADM.Employees;

namespace byteBank_ADM.Utility
{
    public class BonusAdm
    {
        public double TotalBonus { get; private set; }

        public void Register(Employee employee)
        {
            this.TotalBonus += employee.GetBonus();
        }
    }
}
