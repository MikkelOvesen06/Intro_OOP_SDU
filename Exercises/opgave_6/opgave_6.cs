//Opgave 6.3
float price = 599.95f;
int since_newyear =  31104000;
int month1 = since_newyear / 24 / 60 / 60 / 30;
Console.WriteLine(month1);
if (month1 == 12) {
    float sale = price * 0.7f;
    Console.WriteLine(sale);
} 
else {
    Console.WriteLine(price);
}

//Opgave 6.5
int month2 = 10;
switch (month2) {
    case 10:
        Console.WriteLine("Autumn");
        break;
    case 12:
        Console.WriteLine("Christmas");
        break;
    case 4:
        Console.WriteLine("Spring Holiday");
        break;
    case 7 or 8:
        Console.WriteLine("Summer");
        break;
    default:
        Console.WriteLine("Hard Work");
        break;
}
//Opgave 6.6
for (double c=-5 ; c<=40 ; c+=0.5) {
double f = c*9/5 + 32;
Console.WriteLine("{0,5:F1}°C {1,5:F1}°F", c, f);
}

//Opgave 6.9
float pie1 = 3.14f;
byte radius1 = 5;
float area1 = pie1 * (radius1 * radius1);
Console.WriteLine(area1);


