using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_24
{
    internal class Exam
    {
        public string Subject;
        public DateTime Date;
        public Exam(string subject, DateTime date)
        {
            this.Subject = subject;
            this.Date = date;
        }

        public static List<Exam> exams = new List<Exam>();
        
        public static void AddNewExam()
        {
            string subject;
            do
            {
                Console.Write("Enter subject: ");
                subject = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(subject));

            string dateStr;
            DateTime date;
            do
            {
                Console.Write("Enter exam date: ");
                dateStr = Console.ReadLine();
            } while (!DateTime.TryParse(dateStr, out date));

            if (!exams.Exists(x=>x.Subject == subject))
            {
                exams.Add(new Exam(subject, date));
                Console.WriteLine("Exam added successfully!");
                
            }
            else
            {
                Console.WriteLine("Exam already exists!");
            }
            
        }

        public static void ShowExamsStartingWithA()
        {
            var filteredExams = FilterExams(exam => exam.Subject.StartsWith("A"));
            DisplayExams(filteredExams);
        }

        public static void ShowPassedExams()
        {
            var filteredExams = FilterExams(exam => exam.Date < DateTime.Now);
            DisplayExams(filteredExams);
        }

        public static void ShowExamsInLessThanOneMonth()
        {
            var filteredExams = FilterExams(exam => exam.Date.Month < DateTime.Now.Month + 1 && exam.Date > DateTime.Now);
            DisplayExams(filteredExams);
        }

        public static void RemovePassedExams()
        {
            exams.RemoveAll(exam => exam.Date < DateTime.Now);
            Console.WriteLine("Passed exams removed successfully!");
        }

        public static void CheckIfMathExamExists()
        {
            bool exists = exams.Any(exam => exam.Subject.Equals("Riyaziyyat", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Math exam exists: {exists}");
        }

        public static void ShowMathExams()
        {
            var filteredExams = FilterExams(exam => exam.Subject.Equals("Riyaziyyat", StringComparison.OrdinalIgnoreCase));
            DisplayExams(filteredExams);
        }

        private static List<Exam> FilterExams(Func<Exam,bool> abc)
        {
            return exams.Where(abc).ToList();
        }
        
        private static void DisplayExams(List<Exam> exams)
        {
            foreach (var exam in exams)
            {
                Console.WriteLine($"Subject: {exam.Subject}, Date: {exam.Date.Date}");
            }
        }
    }
}
