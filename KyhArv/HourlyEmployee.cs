namespace KyhArv
{
    public class HourlyEmployee : Employe
    {
        private int _HourlySalary;
        private readonly int _hoursWorked;
        public HourlyEmployee(string name, DateTime Birthdate, DateTime employeDate, int HourlySalary, int HoursWorked)
            : base(name,Birthdate,employeDate)
        {
            _HourlySalary = HourlySalary;
            _hoursWorked = HoursWorked;
        }
        public override int CalculateSalary()
        {
            return _HourlySalary + _hoursWorked;
        }
        
    }

}
