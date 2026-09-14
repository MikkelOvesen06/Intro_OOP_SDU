
//Opgave 5.1
float temp = 37.4f;

Console.WriteLine(temp);

//Opgave 5.2
byte month = 9;
Console.WriteLine(month);

//Opgave 5.3, introduces the concept of overflow, where if you go higher then the maximum, if becomes the minimal value. (Loop)
sbyte output = -128;
output--;
Console.WriteLine(output);


//Opgave 5.15
int ada_lovelace = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
int dennis_ritchie = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
int grace_hopper = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
int hedy_lamarr = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
int edsger_dijkstra = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart
float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
float avg = (male_avg + female_avg) / 2;
float diff = male_avg - female_avg;
Console.Write("Average lifespan of a male computer scientist: ");
Console.WriteLine(male_avg);
Console.Write("Average lifespan of a female computer scientist: ");
Console.WriteLine(female_avg);
Console.Write("Average lifespan of a computer scientist: ");
Console.WriteLine(avg);
Console.Write("Males live this much longer than females: ");
Console.WriteLine(diff);

//Opgave 5.8
float pie = 3.14f;
byte radius = 5;
float area = pie * (radius * radius);
Console.WriteLine(area);

// OpGAVE 5.10
float temp_celcius = 38.4f;
float temp_fahrenheit = 32 + (9/5*temp_celcius);

Console.WriteLine("Temperaturen bliver " + temp_fahrenheit);

//Opgave 5.14
float monday = 21.5f;
float tuesday = 23.7f;
float wednesday = 19.6f;
float thursday = 22.5f;
float friday = 25.3f;
float saturday = 21.7f;
float sunday = 18.9f;

float result1 = tuesday - monday;
Console.WriteLine(result1);
float result2 = wednesday - tuesday;
Console.WriteLine(result2);
float result3 = thursday - wednesday;
Console.WriteLine(result3);
float result4 = friday - thursday;
Console.WriteLine(result4);
float result5 = saturday - friday;
Console.WriteLine(result5);
float result6 = sunday - saturday;
Console.WriteLine(result6);

//Opgave 5.20
byte dice = 1;
bool dice_tjek = (dice >= 3);
Console.WriteLine(dice_tjek);















