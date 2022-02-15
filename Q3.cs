static void Main(string[] args)
{
int num1 = 10;
int num2 = 20;
 
Console.WriteLine("num1 ={0}",num1);
Console.WriteLine("num2 ={0}", num2);
 
 
num1 = num1 + num2;
num2 = num1 - num2;
num1 = num1 - num2;
Console.WriteLine("_____________");
Console.WriteLine("num1={0}", num1);
Console.WriteLine("num2={0}", num2);
 
Console.ReadKey();
 
}
