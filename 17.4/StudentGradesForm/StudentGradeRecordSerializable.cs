using System;
using System.Text.RegularExpressions;

namespace StudentGradesForm
{
    [Serializable]
    public class StudentGradeRecordSerializable
    {
        public int Id { get; private set; } = -1;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ClassName { get; private set; }

        private string grade;
        public string Grade
        {
            get => grade;
            private set
            {
                if (!Regex.IsMatch(value,
                    @"\A([A-D][\+\-]?)|[EF]\z"))
                        throw new FormatException("Provided grade is not valid");
                
                grade = value;
            }
        }

        public StudentGradeRecordSerializable(
            int id, string firstName, string lastName,
            string className, string grade)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            ClassName = className;
            Grade = grade;
        }

        public override string ToString() => 
            $"{LastName},   {FirstName}:   {Id}   " +
            $"\"{ClassName}\"   \"{Grade}\"";
    }
}
