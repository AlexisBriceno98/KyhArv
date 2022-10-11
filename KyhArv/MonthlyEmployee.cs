namespace KyhArv
{
    public class MonthlyEmployee : Employe
    {
        private int _monthlySalary;
        public MonthlyEmployee(string name, DateTime Birthdate, DateTime employeDate, int monthlySalary)
        : base(name, Birthdate, employeDate)
        {
            _monthlySalary = monthlySalary;
        }
        public override int CalculateSalary()
        {
            var salary = _monthlySalary;
            if (DateTime.Now.Year - _Birthdate.Year >= 50)
            {
                salary = Convert.ToInt32(salary + 1.62);
            }
            if (DateTime.Now.Year - _employeDate.Year >= 10)
            {
                salary = Convert.ToInt32(salary + 1.62);
            }
            return salary;
        }

    }

}
