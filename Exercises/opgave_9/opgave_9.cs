//Opgave 9.1
int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};
// increment
for (int i = 0; i < iterationer; i++)
{
    try
    {
        array[i]++;
    }
    catch (IndexOutOfRangeException)
    {
        // spring denne iteration over
    }
}
// print
for (int i=0 ; i<array.Length ; i++) {
Console.WriteLine(array[i]);
}

//Opgave 9.2
int[] accounts = {903, 716, 67};
int GetAccountNumber ()
{
Console.WriteLine("Enter an account number: ");
return Convert.ToInt32(Console.ReadLine());
}
void PrintAccountState (int accountId)
{
Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}
while (true) 
{
    try
    {
        int accountId = GetAccountNumber();
        PrintAccountState(accountId);
    }
    catch(IndexOutOfRangeException)
    {
    }
    catch(FormatException)
    {
    }
}

//Opgave 9.3
iwnt[] grades = [4, 7, 02, 00, 10, 4, 12];
int sums = 0;
float count = 0f;
int get_grade(int course_id){
    int grade = grades[course_id];
    if (grade<2){
        throw new Exception("You have failed");
    }
    return grade;
}
    for (int x = 0 ; x<grades.Length ; x++)
    {
        try{
            sums += get_grade(x);
            count++;
        }
        catch(Exception){
        }
    }
Console.WriteLine(sums/count);

