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
        public int CalculateSalary()
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
    public class Employe
    {
        private string _name;
        protected DateTime _Birthdate;
        protected DateTime _employeDate;


        public Employe(string name, DateTime Birthdate, DateTime employeDate)
        {
            _name = name;
            _Birthdate = Birthdate;
            _employeDate = employeDate;

        }
    }

}
