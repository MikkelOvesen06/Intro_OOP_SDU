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


//Opgave 7.15

Person person = new Person { name = "mikkel ", age = 19 , height = 1.86f } ;
Console.WriteLine("name = " + person.name + "age = " + person.age + "height = " + person.height);


//Opgave 7.16
// 
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

