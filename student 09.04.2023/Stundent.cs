Student Student1 = new Student("Izzat", "Abdullayev", "P234", 85, true);
Student Student2 = new Student("Hasan", "Qasimli", "A534", 63,false);


Console.WriteLine(Student1.GetAllInfo());
Console.WriteLine(Student1.CanTakeNextExam() ? "Can take the next exam." : "Cannot take the next exam.");

Console.WriteLine(Student2.GetAllInfo());
Console.WriteLine(Student2.CanTakeNextExam() ? "Can take the next exam." : "Cannot take the next exam.");