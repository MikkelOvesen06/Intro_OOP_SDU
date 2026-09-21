//Opgave 7.4 Largest in a array
int[] numbers = [10, 30, 40, 42, 12];
int max = numbers[0];

foreach(int number in numbers)
{
    if(number > max )
    {
    max = number;
    }
}
Console.WriteLine(max);

//Opgave 7.12
int[] monthsnormal = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
int[] monthsleap = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
int[] pointer;
for (int year=2000 ; year<=2020 ; year++) 
{
    int[] months = monthsnormal;
    if (year % 4 == 0) 
    {
        pointer = monthsleap;
    }
    pointer = months;
    Console.Write("Days in the months of " + year + ": ");
    foreach (int num in pointer)
    {
        Console.Write(num + " ");
    }
}


//Opgave 7.15 person discribtion

Person person = new Person { name = "mikkel ", age = 20 , height = 1.86f } ;
Console.WriteLine("name = " + person.name + "age = " + person.age + "height = " + person.height);


//Opgave 7.16 direction

direction direction = direction.south;

switch (direction) {
    case direction.north :
    Console.WriteLine("Direction is north");
    break;
    case direction.south:
    Console.WriteLine("Direction is south");
    break;
    case direction.west:
    Console.WriteLine("Direction is west");
    break;
    case direction.east:
    Console.WriteLine("Direction is east");
    break;
    default:
        Console.WriteLine("Not a Direction");
    break;
}

//Describtion of af foreach loop
int[] tal = { 1, 2, 3, 4, 5 };
int sum = 0;

foreach (int t in tal)
{
    sum = sum + t;
    Console.WriteLine("Tallet er " + t + ", summen er nu " + sum);
}

Console.WriteLine("Færdig! Samlet sum: " + sum);

//Opgve sudoku checker
int [][] arrayinarray = [
    [4, 3, 5, 2, 6, 9, 7, 8, 1],
    [6, 8, 2, 5, 7, 1, 4, 9, 3],
    [1, 9, 7, 8, 3, 4, 5, 6, 2],
    [8, 2, 6, 1, 9, 5, 3, 4, 7],
    [3, 7, 4, 6, 8, 2, 9, 1, 5],
    [9, 5, 1, 7, 4, 3, 6, 2, 8],
    [5, 1, 9, 3, 2, 6, 8, 7, 4],
    [2, 4, 8, 9, 5, 7, 1, 3, 6],
    [7, 6, 3, 4, 1, 8, 2, 5, 9]
];

//Class fra Opgave 7.16
enum direction {
    north,
    south,
    east,
    west,
}
//Class fra Opgave 7.15
class Person {
    public string name;
    public byte age;
    public float height;
}

