using System.Collections;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
#region T1Revision
Console.Write("Enter number of employees: ");
int loo = Convert.ToInt32(Console.ReadLine());
int[] empHr = new int[loo];
int[] tot = new int[loo];
int sal = 10, lmao = 0; //wage

Console.WriteLine("\n");
for (int i = 0; i < loo; i++)
{
    Console.Write($"Emplyee's {i + 1} working hours: ");
    empHr[i] = Convert.ToInt32(Console.ReadLine());
    tot[i] = empHr[i] * sal;
    lmao += tot[i];
}

Console.WriteLine("\n");
for (int i = 0; i < loo; i++)
{
    Console.WriteLine($"Employee's {i + 1} total wage: " + tot[i]);
}

Console.WriteLine($"\nEmployees's total salary: " + lmao);
#endregion
Console.WriteLine("\n_______________________\n");
#region T2
void signUp()
{
    Console.WriteLine("ERROR 404 :p");
}
int attem = 0;
string usrIn, usrN, usrPWD = "123456";

Console.Write("1- Sign up\n2- Sign in\n\nYour choice: ");
string input = Console.ReadLine();

if (input == "1")
{
    signUp();
}
else if (input == "2")
{
    Console.Write("Username: ");
    usrN = Console.ReadLine();

    while (attem < 3)
    {
        Console.Write("Password: ");
        usrIn = Console.ReadLine();
        if (usrIn == usrPWD)
        {
            Console.WriteLine($"\n\nAccess granted!\n... Welcome {usrN}");
            return;
        }
        attem++;
    }
    Console.WriteLine("Access denied!... too many attempts!");
}
#endregion
Console.WriteLine("\n_______________________\n");
#region T3ArrList
ArrayList arr = new ArrayList();

arr.Add(55);

foreach (var element in arr)
{
    Console.WriteLine(element);
}
#endregion
Console.WriteLine("\n_______________________\n");
#region T4
void PrintList(int loop, ArrayList lis)
{
    foreach (var element in lis)
    {
        Console.WriteLine(element);
    }
}

ArrayList lis = new ArrayList();
Console.WriteLine("To add to the list: ");
int loop = Convert.ToInt32(Console.ReadLine());

//add
for (int i = 0; i < loop; i++)
{
    Console.Write($"Index {i}: ");
    lis.Add(Console.ReadLine());
}

PrintList(loop, lis);

//Insert
Console.Write("Index you want to add to (Not rewrite only shiftting): ");
int index = Convert.ToInt32(Console.ReadLine());
Console.Write("Write what to add: ");

lis.Insert(index, Console.ReadLine());
PrintList(loop, lis);

//Remove
Console.WriteLine("Index you want to remove: ");

lis.RemoveAt(Convert.ToInt32(Console.ReadLine()));
PrintList(loop, lis);
#endregion
Console.WriteLine("\n_______________________\n");
#region T5
ArrayList arrayList = ["c#"
                     , "asp"
                     , ".net"
                     , "html"
                     , "css"
                     , "js"
                     , "sql"];

string usrInp;

while (true)
{

    Console.Write("Enter course: ");
    usrInp = Console.ReadLine();

    if (arrayList.Contains(usrInp.ToLower()))
    {
        Console.WriteLine($"Index of '{usrInp}': " + arrayList.IndexOf(usrInp));
        Console.Write("Continue or exit [C,e]: ");
        string choice = Console.ReadLine();
        if (choice == "e" || choice == "E")
        {
            break;
        }
    }
    else Console.WriteLine($"'{usrInp}' is not exist in the list!...");
}
#endregion

