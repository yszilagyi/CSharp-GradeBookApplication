using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        
        public RankedGradeBook(string name, bool weighted) : base(name, weighted)
        {
            Type = GradeBookType.Ranked;
        }

        public override void CalculateStatistics()
        {
            if (this.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 " +
                    "students with grades in order to properly calculate a student's overall grade.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (this.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 " +
                    "students with grades in order to properly calculate a student's overall grade.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }

        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (this.Students.Count < 5)
            {

                throw new InvalidOperationException();
            }
            else if (averageGrade >= 80)
            {
                return 'A';
            }
            else if (averageGrade >= 60)
            {
                return 'B';
            }
            else if (averageGrade >= 40)
            {
                return 'C';
            }
            else if (averageGrade >= 20)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

        }
    }
}
