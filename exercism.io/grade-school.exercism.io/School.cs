using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade_school.exercism.io
{
    public class School
    {
        public Dictionary<int, List<string>> Roster { get; set; }

        public School()
        {
            Roster = new Dictionary<int, List<string>>();
        }

        public void Add(string student, int grade)
        {
            if (Roster.ContainsKey(grade))
            {
                Roster[grade].Add(student);
                Roster[grade].Sort();
            }
            else
            {
                Roster.Add(grade, new List<string>(){student});
            }
        }

        public List<string> Grade(int grade)
        {
            if (Roster.ContainsKey(grade))
            {
                return Roster[grade];
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
