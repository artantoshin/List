List<string> bus = new List<string>() { "Tom" };

bus.Add("Kola"); // добавление элемента

//car.AddRange(new[] { "Sam", "Alice" });   // добавляем массив
// people = { "Tom", "Bob", "Sam", "Alice" };
// также можно было бы добавить другой список
// people.AddRange(new List<string>(){ "Sam", "Alice" });

bus.Insert(0, "Audi"); // вставляем на первое место
                       // people = { "Eugene", "Tom", "Bob", "Sam", "Alice" };

//car.InsertRange(1, new string[] { "Mike", "Kate" }); // вставляем массив с индекса 1
// people = { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Alice" };

// также можно было бы добавить другой список
// people.InsertRange(1, new List<string>(){ "Mike", "Kate" });
//</ string ></ string >

foreach (var person in bus) Console.WriteLine(person);
/*
List<Person> car = new List<Person>()
{
    new Person("Lada"),
    new Person("Grana"),
    new Person("BMV")
};

foreach (var person in car) Console.WriteLine(person.Name);

var people = new List<string>() { "Tom", "Bob", "Sam" };

string firstPerson = people[0]; // получаем первый элемент
Console.WriteLine(firstPerson); // Tom
people[0] = "Mike";     // изменяем первый элемент
Console.WriteLine(people[0]); // Mike

var company = new LinkedList<Person>();

company.AddLast(new Person("Tom"));
company.AddLast(new Person("Sam"));
company.AddFirst(new Person("Bill"));

foreach (var person in company) Console.WriteLine(person.Name);

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}
*/