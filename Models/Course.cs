using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnhancedOasis.Models
{
    public class Course
    {
        public int CourseID;
        public int ProfessorID;
        public int Credits;
        public int Capacity;
        public int Active;
        public int Remaining;
        public TimeSpan StartTime;
        public TimeSpan EndTime;
        public string Days;
        public string Course_Name;
        public string Department;
    }
}
