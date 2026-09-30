//Find the largest negative number, i have interpreted this quistion as the "Largest" is farthest away from 0, in the following example this will be -1002
int[] numbers = [5, 16, -7, -1002, 0, 10007, -16];
int max = numbers[0];
//It will look trough each number and see if is less than the previous
foreach(int number in numbers)
{
    if(number < max )
    { //If the number is less than the previous number, then the number will be set to max
    max = number;
    }
} //When the foreach loop has went trough the array, is will print the max (largest negative)
Console.WriteLine("The largest negative number is: " + max);
