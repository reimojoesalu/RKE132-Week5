﻿//math >= 90; Biology >=90, Chemistry >=90;

int math, biology, chemistry;

Console.WriteLine("Enter your Math resualy:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology resualt:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry resualt:");
chemistry = Int32.Parse(Console.ReadLine());


if(math >= 90 && biology >= 90 && chemistry >= 90)
 {
    Console.WriteLine("Congratulation you got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}