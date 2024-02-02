using _02_02_24;
using System.Collections.Generic;



string opt;
do
{
    Console.WriteLine("1. Add new exam");
    Console.WriteLine("2. Show exams starting with 'A'");
    Console.WriteLine("3. Show passed exams");
    Console.WriteLine("4. Show exams happening in less than 1 month");
    Console.WriteLine("5. Show exams at 08:00");
    Console.WriteLine("6. Remove passed exams");
    Console.WriteLine("7. Check if there is a Math exam");
    Console.WriteLine("8. Show Math exams");
    Console.WriteLine("0. Exit");

    Console.WriteLine("Enter the operation number:");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            Exam.AddNewExam();
            break;
        case "2":
            Exam.ShowExamsStartingWithA();
            break;
        case "3":
            Exam.ShowPassedExams();
            break;
        case "4":
            Exam.ShowExamsInLessThanOneMonth();
            break;
        case "5":
            
            break;
        case "6":
            Exam.RemovePassedExams();
            break;
        case "7":
            Exam.CheckIfMathExamExists();
            break;
        case "8":
            Exam.ShowMathExams();
            break;
        case "0":
            Console.WriteLine("Program Finished");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }


} while (opt != "0");

