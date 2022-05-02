using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DTO
{
    public class Teacher
    {
        private string _ID;
        private string _Name;
        private string _BirthDay;
        private bool _Gender;
        private string _Phone;
        private string _Address;
        private string _Mail;
        private string _Level;
        private string _Expertise;
        private string _Salary;

        public string Phone { get => _Phone; set => _Phone = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public string Level { get => _Level; set => _Level = value; }
        public string Expertise { get => _Expertise; set => _Expertise = value; }
        public string Salary { get => _Salary; set => _Salary = value; }
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string BirthDay { get => _BirthDay; set => _BirthDay = value; }
        public bool Gender { get => _Gender; set => _Gender = value; }
    }
}
