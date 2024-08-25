// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

// Console.Write("Enter number between \"0 and 999\": ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number < 0 || number > 999)
// {
//     Console.WriteLine("Pls enter number between \"0 and 999\"!");

//     return;
// }


// Console.WriteLine($"the conversion of '{number}' to words is {ConvertToWords(number)}");

// static string ConvertToWords(int number)
// {
//     if(number == 0) return "zero";

//     string words = "";

//     if((number / 100) > 0)
//     {
//         words += GetUnitNumber(number / 100) + " " + "hundred";
//         number %= 100;

//     }
//     if(number > 0 )
//         {
//             words += " and ";

//             if(number < 20)
//             {
//                 words += GetUnitNumber(number);

//             }
//             else
//             {
//                 words += GetTensNumber(number / 10);
//                 if((number % 10) > 0)
//                 {
//                     words += "-" + GetUnitNumber(number % 10);
//                 }
//             }
//         }
//     return words;
// }

// static string GetUnitNumber(int num)
// {

//     switch (num)
//     {
//         case 1: return "one";
//         case 2: return "two";
//         case 3: return "three";
//         case 4: return "four";
//         case 5: return "five";
//         case 6: return "six";
//         case 7: return "seven";
//         case 8: return "eight";
//         case 9: return "nine";
//         default: return "";

//     }
// }

// static string GetTensNumber(int num)
// {
//     switch (num)
//     {
//         case 1: return "ten";
//         case 2:return "twenty";
//         case 3: return "thirty";
//         case 4: return "fourty";
//         case 5: return "fifty";
//         case 6: return "sixty";
//         case 7: return "seventy";
//         case 8: return "eighty";
//         case 9: return "ninety";
//         default: return "";
//     }
// }

// const double overallMark =  200;;

// static double GetGradeForDavid()
// {    
//     double david = 155.9;

//     return david / overallMark * 100;
// }

// static double GetGradeForJulius()
// {
//     double julius = 168;
//     return julius / overallMark * 100;
// }

// static double GetGradeForNike()
// {
//     double nike = 190;
//     return nike / overallMark * 100;
// }

// switch (GetGradeForDavid())
// {
//     case double grade when grade >= 0 && grade <= 49:
//     Console.WriteLine("Poor");
//     break;
//     case double grade when grade >= 50 && grade <= 74:
//     Console.WriteLine("Good");
//     break;
//     case double grade when grade >= 75 && grade <= 89:
//     Console.WriteLine("Very Good");
//     break;
//     case double grade when grade >= 90 && grade <=100:
//     Console.WriteLine("Excellent");
//     break;
//     default:
//     Console.WriteLine("Invalid Score");
//     break;
// }

var str = "I love C#, C++, and JavaScript";
var output = str.Concat(
    str.AsSpan(0, 9),
    str.AsSpan(14, 15)
);

Console.WriteLine(output);