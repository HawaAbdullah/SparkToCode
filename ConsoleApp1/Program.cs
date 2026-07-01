Console.WriteLine("Please Enter Your name");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}");

Console.Write("Enter mark: ");
int mark = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Mark: {mark}");

string grade; 

if (mark >= 90)
{
    grade = "A+";
}
else if (mark >= 80)
{
    grade = "A";
}
else if (mark >= 70)
{
    grade = "B";
}
else if (mark >= 60)
{
    grade = "C";
}
else
{
    grade = "F";
}

Console.WriteLine($"Grade: {grade}");
