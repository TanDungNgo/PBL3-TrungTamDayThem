using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DTO
{
    public class PersonNameComparer : IComparer <Student>
    {
        int IComparer<Student>.Compare(Student x, Student y)
        {
            return x.HoTenHV.CompareTo(y.HoTenHV);
            throw new NotImplementedException();
        }
    }
}
