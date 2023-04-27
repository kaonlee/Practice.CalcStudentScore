using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CalcStudentScore
{
    public class Student
    {
        public string Name { get; set; }
		public Subject Math { get; private set; }
		public Subject English { get; private set; }
		public Subject Science { get; private set; }
		public Subject Social { get; private set; }
		public double AverageScore { get;}


        public Student(string name, int mathScore , int engScore, int sciScore, int hssScore)
        {
            
            this.Name = name;
            this.Math = new Subject("Math",mathScore);
            this.English = new Subject( "English", engScore );
            this.Science = new Subject( "Science", sciScore );
            this.Social = new Subject( "Social", hssScore );
            this.AverageScore = GetAverageScore();
        }

		public Student( string name, string mathS, string engS, string sciS, string hssS )
		{
            int mathScore = int.TryParse( mathS, out mathScore ) ? mathScore : -1;
            int engScore = int.TryParse ( engS, out engScore )?engScore : -1;
            int sciScore = int.TryParse( sciS, out sciScore ) ?sciScore : -1;
            int hssScore = int.TryParse( hssS, out hssScore )?hssScore: -1;
            this.Name = name;
            this.Math = new Subject("Math", mathScore);
            this.English = new Subject("English", engScore);
            this.Science = new Subject("Science", sciScore);
            this.Social = new Subject("Social", hssScore);
            this.AverageScore = GetAverageScore();
        }

        private double GetAverageScore()
        =>  new[] { Math, English, Science, Social }
                .Where(s => s.Score >= 0)
                .Select(s => s.Score)
                .DefaultIfEmpty()
                .Average();

        /// <summary>
        /// 印出學生的成績與最高/最低/平均成績
        /// </summary>
        /// <returns></returns>
        public string PrintStudentScore()
        {
            FindSubject find = new FindSubject();
            Subject [] subjects = new Subject [] { this.Math,this.English,this.Science,this.Social};
            Subject minSub = find.Min( subjects );
            Subject maxSub = find.Max( subjects );

            StringBuilder message = new StringBuilder();
            message.AppendLine( $@"Student : {Name}" );
            message.AppendLine( );
            foreach( Subject subject in subjects ) { message.AppendLine( SubjectMessage( subject) ); }
			message.AppendLine( );
			message.AppendLine( "最高分 | "+SubjectMessage(minSub));
            message.AppendLine( "最低分 | "+SubjectMessage(maxSub));
			message.AppendLine( );
			message.AppendLine( "平均分數 | " + this.AverageScore.ToString("N2")+" 分"
                );

            return message.ToString();
        }

        private class FindSubject
        {
            public Subject Min( Subject [] Subjects ) 
                => Subjects.Where( s => s.Score >= 0 ).OrderByDescending( s => s.Score ).FirstOrDefault( );

			public Subject Max ( Subject [] Subjects )
                => Subjects.Where( s => s.Score >= 0 ).OrderBy(s=>s.Score).FirstOrDefault();
		}

        private string SubjectMessage( Subject s )
        {
            if ( s == null )
            {
                return "請輸入值 :) ";
            }
            else
            {
                return ( s.Score >= 0 ) ? $"{s.Name} : {s.Score} 分" : $"{s.Name} :成績有誤，請檢查！";
            }
        }

    }

    
}
