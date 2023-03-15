using System;

class FinalExamples {
    public record Student {
        public readonly int id;
        public string firstName;
        public string lastName;
        public string middleName = "";
    } // end record

    public static void Main() {
        Student student = new Student();
        //student.id = 1;    id cannot be assigned since the member is readonly
        student.firstName = "Stephen";
        student.lastName = "Britt";
        student.middleName = "";
        Console.Write(student);
    } // end method
} // end class