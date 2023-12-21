Console.WriteLine("How many students are in your class: ");

int students = Convert.ToInt32(Console.ReadLine());
string[] people = new string[students];

Console.WriteLine("What are their names?: ");

for (int i = 0; i < people.Length; i++)
{
    people[i] = Console.ReadLine();
}

Console.WriteLine("------------------------");
Array.Sort(people);

for (int i = 0; i < people.Length; i++)
{
    Console.WriteLine(people[i]);
}

Console.ReadKey();