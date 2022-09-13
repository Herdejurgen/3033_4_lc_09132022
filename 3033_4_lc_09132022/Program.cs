// Jack Herdejurgen 113436899
// Lecture Code Sept 13, 2022
// Class

Person p1;
p1 = new Person();

Student stu = new Student();

Console.WriteLine(p1);
Console.WriteLine(stu);

Console.ReadKey();
// Object automatically inherited
public class Person
{
    private string name="Jack Herdejurgen";
    public string Name { get { return name.Substring(0,2)+"***"; } set { Name = name; } }
    public int age=0;
    public override string ToString()
    {
        return Name;
    }
}
public class Student : Person
{
    public int ID;
}