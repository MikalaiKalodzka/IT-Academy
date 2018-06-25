using System;

namespace Lecture_2_6_Kalodzka_Mikalai.Exceptions
{
    // TODO Классы ошибок должны оканчиваться на Exception -> InvalidStudentInputException
    public class InvalidStudentInput: Exception
    {
        public InvalidStudentInput(): base() { }
        public InvalidStudentInput(string message): base(message) { }
        public InvalidStudentInput(string message, Exception exception): base(message, exception) { }
    }
}
