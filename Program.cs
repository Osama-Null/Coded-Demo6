#region T1
Console.Write("Enter number of employees: ");
int loo = Convert.ToInt32(Console.ReadLine());
int[] empHr = new int[loo];
int[] tot = new int[loo];
int sal = 10, lmao= 0; //wage

Console.WriteLine("\n");
for (int i = 0; i < loo; i++)
{
    Console.Write($"Emplyee {i + 1} work hours: ");
    empHr[i] = Convert.ToInt32(Console.ReadLine());
    tot[i] = empHr[i] * sal;
    lmao += tot[i];

}

Console.WriteLine("\n");
for (int i = 0; i < loo; i++)
{
    Console.WriteLine($"Total wage of employee {i + 1}: " + tot[i]);
}

Console.WriteLine($"\nTotal salary of employees : " + lmao);
#endregion
Console.WriteLine("\n_______________________\n");
