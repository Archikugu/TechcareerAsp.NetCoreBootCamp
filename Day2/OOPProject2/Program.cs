// See https://aka.ms/new-console-template for more information
using OOPProject2.Abstracts;
using OOPProject2.Classes;
using OOPProject2.Constructors;

Mathematics mathematics = new Mathematics();

int result = mathematics.Plus(5, 5);
Console.WriteLine("Result: " + result);

Console.WriteLine("Result2: " + mathematics.Multipy(15, 15));

Person person = new Person();
int age = person.AgeCalculate(1999);
Console.WriteLine(age);


GeneralManager generalManager = new GeneralManager();
Manager manager = new Manager();
Developer developer = new Developer();
Intern intern = new Intern();

double totalSalary = 0.00;
totalSalary += generalManager.Salary();
totalSalary += manager.Salary();
totalSalary += developer.Salary();
totalSalary += intern.Salary();

Console.WriteLine("Total Salary " + totalSalary);

new Person();
new Person("Gökhan", "Gök");


Ear ear = new("prominent ear");
Nose nose = new("flat nose");
Eyes eyes = new("green");
Head head = new(nose, ear,eyes);

Human human = new("Gökhan","Gök",head);
human.Write();
