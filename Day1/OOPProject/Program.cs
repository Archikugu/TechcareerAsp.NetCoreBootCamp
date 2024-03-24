// See https://aka.ms/new-console-template for more information
using OOPProject.Classes;

Console.WriteLine("Hello, World!");

Person person = new();
person.firstName = "Gokhan";
person.lastName = "Gok";
person.age = 25;
person.salary = 24;
person.gender = true;
person.Sleep(person.firstName, person.lastName);



Car car = new Car();
car.CarID = 1;
car.Brand = "Audi";
car.CarDescription = "Beyaz 2024";
car.CarGo(car.Brand, car.CarDescription);


Mom mom = new Mom();
mom.firstName = "Hatice";
mom.lastName = "Gök";
mom.age = 60;
mom.salary = 0;
mom.gender = false;
mom.Description(mom.firstName, mom.lastName);
mom.Read(mom.firstName);
mom.Write(mom.firstName);


Father father = new Father();
father.firstName = "İbrahim";
father.lastName = "Gök";
father.age = 61;
father.salary = 0;
father.gender = true;
father.Description(father.firstName, father.lastName);
father.FatherRead(father.firstName);
father.Listen(father.firstName);


Children smartChild = new Children();
smartChild.firstName = "Hakan";
smartChild.lastName = "Yılmaz";
smartChild.adjective = " is a smart child.";
smartChild.DisplayChildInfo(smartChild.firstName, smartChild.lastName, smartChild.adjective);

Children obedientChild = new Children();
obedientChild.firstName = "Mehmet";
obedientChild.lastName = "Yıldız";
obedientChild.adjective = " is a obedient child.";
obedientChild.DisplayChildInfo(obedientChild.firstName, obedientChild.lastName, obedientChild.adjective);