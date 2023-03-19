using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolEF
{
    public class TeacherService
    {
        public SchoolEFContext dbContext { get; set; }

        public TeacherService(SchoolEFContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Teacher[] GetAllTeachersByStudent(string studentName)
        {
            var teachers = dbContext.TeacherPupil.Where(x => x.Pupil.Name == studentName).Select(x => x.Teacher);
            return teachers.ToArray();
        }
    }
}
