using System;

namespace Lecture_2_6_Kalodzka_Mikalai.Exceptions
{
    public class PropertyInitializationIssue: Exception
    {
        public PropertyInitializationIssue() : base() { }

        public PropertyInitializationIssue(string message): base(message) { }

        public PropertyInitializationIssue(string message, Exception exception): base(message, exception) { }        
    }
}
