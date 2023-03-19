using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolEF
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Subject { get; set; }
        public ICollection<TeacherPupil> Pupils { get; set; }
    }
}
