using UpSchoolHW_01.Entities;
using UpSchoolHW_01.Enums;



string upperLet = "";
string lowerLet = "";
string special = "";
string number = "";
string password = "";


Dictionary<int, string> selectionList = new Dictionary<int, string>();
Dictionary<int, string> okeyList = new Dictionary<int, string>();

Console.WriteLine("*************  Welcome  Simple Password Generator *************");

Console.WriteLine("Lütfen şifre uzunluğunu giriniz: ");
int passwordLength = Convert.ToInt32(Console.ReadLine());
if (passwordLength > 0)
{
    Console.WriteLine("Şifreniz büyük harf içersin mi?");
    upperLet = Console.ReadLine();
    if (upperLet != ConsoleKey.Y.ToString() && upperLet != ConsoleKey.N.ToString())
    {
        Console.WriteLine("Y veya N tercihi yapınız");
        upperLet = Console.ReadLine();
    }
    else selectionList.Add((int)Combination.UppercaseCharacters, upperLet); 


    Console.WriteLine("Şifreniz kücük harf içersin mi?");
    lowerLet = Console.ReadLine();
    if (lowerLet != ConsoleKey.Y.ToString() && lowerLet != ConsoleKey.N.ToString())
    {
        Console.WriteLine("Y veya N tercihi yapınız");
        lowerLet = Console.ReadLine();
    }
    else selectionList.Add((int)Combination.LowercaseCharacters, lowerLet);


    Console.WriteLine("Şifreniz özel karakter içersin mi?");
    special = Console.ReadLine();
    if (special != ConsoleKey.Y.ToString() && special != ConsoleKey.N.ToString())
    {
        Console.WriteLine("Y veya N tercihi yapınız");
        special = Console.ReadLine();
    }
    else selectionList.Add((int)Combination.SpecialCharacters, special);


    Console.WriteLine("Şifreniz rakam içersin mi?");
    number = Console.ReadLine();
    if (number != ConsoleKey.Y.ToString() && number != ConsoleKey.N.ToString())
    {
        Console.WriteLine("Y veya N tercihi yapınız");
        number = Console.ReadLine();
    }
    else selectionList.Add((int)Combination.Numbers, number); 
}

else
{
    Console.WriteLine("Şifre uzunluğu 0'dan büyük bir değer olmalıdır.");
}




foreach (var item in selectionList)
{
    if (item.Value == "Y")
    {
        okeyList.Add(item.Key, item.Value);
    }
}
password = PasswordGenerator.Generate(passwordLength, okeyList);

Console.WriteLine("************************");
Console.WriteLine($"ŞİFRE: {password}");
