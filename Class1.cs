using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<Mark> Marks { get; set; }
        public Student()
        {
            Marks = new List<Mark>();
        }
        public override string ToString()
        {
            string Raiting = String.Empty;
            foreach (var item in Marks)
            {
                Raiting = item + Environment.NewLine;
            }
            return $"---- {Name}, {Surname}, {Age}, {Raiting} ----";
        }
        public void AddMark(string subject, int value)
        {
            Marks.Add(new Mark
            {
                Subject = subject,
                Raiting = value
            });
        }
    }
  
    [Serializable]
    public class Mark
    {
        public int Raiting { get; set; }
        public string Subject { get; set; }
        public override string ToString()
        {
            return $"{Subject} ----- ";
        }
       

    }



}
