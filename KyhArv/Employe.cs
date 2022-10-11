using System.Reflection.Metadata.Ecma335;

namespace KyhArv
{
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
        public virtual int CalculateSalary()
        {
            return 0;
        }
    }

}
