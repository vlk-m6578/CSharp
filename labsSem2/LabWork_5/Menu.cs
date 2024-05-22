using System;

namespace lab5
{
    public class Menu
    {
        string labNumber;
        string taskNumber;
        string optionNumber;
        string taskDescription;
        string studentData;
        string studentGroup;
        public Menu(string labNumber, string taskNumber, string optionNumber, string taskDescription, string studentData, string studentGroup)
        {
            this.labNumber = labNumber;
            this.taskNumber = taskNumber;
            this.optionNumber = optionNumber;
            this.taskDescription = taskDescription;
            this.studentData = studentData;
            this.studentGroup = studentGroup;
        }

        public void ShowMenu()
        {
            Console.Write("Лабораторная работа  № " + labNumber);
            Console.Write(". Индивидуальное задание " + taskNumber);
            Console.Write(". Вариант " + optionNumber);
            Console.Write(". Условие: " + taskDescription);
            Console.Write(". \nВыполнила " + studentData);
            Console.Write(", " + studentGroup + "\n\n");
        }
    }
}
