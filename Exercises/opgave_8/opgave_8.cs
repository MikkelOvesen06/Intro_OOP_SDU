
//Opgave 8.3
void pretty_printing_array (int[][] array) {
        for (int x = 0 ; x<array.Length ; x++){
            Console.Write("[");
            for (int y = 0; y<array[x].Length ; y++){
                Console.Write((y==0 ? "" : ",") + array[x][y]);
            }
            Console.WriteLine("]");
        }
}

int[][] puzzle = {
new int[] {7, 3, 6, 4, 5, 2, 9, 8, 1},
new int[] {1, 9, 8, 6, 3, 7, 4, 5, 2},
new int[] {4, 2, 5, 9, 8, 1, 3, 7, 6},
new int[] {3, 6, 4, 5, 2, 8, 1, 9, 7},
new int[] {9, 5, 2, 7, 1, 4, 6, 3, 8},
new int[] {8, 1, 7, 3, 9, 6, 2, 4, 5},
new int[] {2, 8, 9, 1, 7, 3, 5, 6, 4},
new int[] {6, 7, 3, 2, 4, 5, 8, 1, 9},
new int[] {5, 4, 1, 8, 6, 9, 7, 2, 3},
};
pretty_printing_array(puzzle);

//Opgave 8.4
int sum ( int a, int b )
{
    return a + b;
}
Console.WriteLine(sum(3,5));

//Opgave 8.8
int fac (int n) {
  if (n==0) {
    return 1;
  } else {
   return n * fac (n - 1);
  }
}

for (int n = 0 ; n<10 ; n++)
Console.WriteLine(n + ": " + fac(n));

//Opgave 8.9
float [] array = [1, 3, 5];
float pie = 3.14f;
float [] area = new float[array.Length];

for ( int t = 0 ; t < array.Length ; t++)
{
    area[t] = pie * (array[t] * array[t]);
    Console.WriteLine("Arealet er: " + area[t] );
}
for ( int t = 0; t < array.Length ; t++)
{
    array[t] = (2 * pie * array[t]);
    Console.WriteLine("Circumference er: " + array[t]);
}
