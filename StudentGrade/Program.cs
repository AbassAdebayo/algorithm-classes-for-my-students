// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// double [] marks = new double [5];
// double [] percentages = new double [5];
// string [] grades = new string [5];

// int overallMark = 200;

// for (int i = 0; i < 5; i++) 
// {
//     Console.Write($"Enter mark for Student {i + 1}: ");
//     marks[i] = Convert.ToDouble(Console.ReadLine());
//     percentages[i] = (marks[i] / overallMark) * 100;
//     grades[i] = GetStudentsGrades(percentages[i]);
// }

// for (int i = 0; i < percentages.Length; i++)
// {

//     Console.WriteLine($"Student {i + 1}'s % =  {percentages[i]}, and Grade = {grades[i]}");
// }

// static string GetStudentsGrades(double percentage)
// {
//     switch (percentage)
//     {
//         case >= 90: return "Excellent";
//         case >= 75: return "Very Good";
//         case >= 50: return "Good";
//         default: return "Poor";
//     }

    
// }


Console.Write("Enter the value for N: ");
int n = Convert.ToInt32(Console.ReadLine());

List<int> numbersNotDivisibleBy3And7 = new List<int>();



for(int i = 0; i <= n; i++)
{
    if(i % 3 != 0 && i % 7 != 0)
    {
        numbersNotDivisibleBy3And7.Add(i);
        
    }
}

Console.WriteLine("Numbers not divisible by 3 and 7 are: ");
foreach (var number in numbersNotDivisibleBy3And7)
{
    Console.WriteLine(number);
}