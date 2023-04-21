using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CalcStudentScore
{
	public class Subject
	{
        public string Name { get; private set; }
        public int Score { get; private set; }
        public Subject(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
