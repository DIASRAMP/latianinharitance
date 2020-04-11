namespace baru.LatihanInheritance
{
    public class Program
    {

        static void Main( string[] args )
        {
            Person person = new Person("vien",19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("gustian",26,"4646","Math");
            teacher.GetNameAndAge();

            Student student = new Student("kepin",20,"6969","kepinsajiwo@gmail.com");
            student.GetNameAndAge();
        }
    }
}