using System;
using task_4_1;
class Program
{
 static void Main()
    {
        OneDims<int> int_mass = new();
        int_mass.Print();
        int_mass.AddEl(1);
        int_mass.AddEl(16);
        int_mass.AddEl(346);
        int_mass.Print();
        int_mass.DelEl(1);
        int_mass.Print();
        int_mass.Sortt();
        int_mass.Print();
        Console.WriteLine(int_mass.Max());
        Console.WriteLine(int_mass.Min());

        OneDims<double> double_mass = new();
        double_mass.Print();
        double_mass.AddEl(13.786);
        double_mass.AddEl(701.25);
        double_mass.AddEl(567.7);
        double_mass.AddEl(0.654);
        double_mass.AddEl(17);
        double_mass.Print();
        double_mass.DelEl(3);
        double_mass.Print();
        double_mass.Sortt();
        double_mass.Print();
        Console.WriteLine(double_mass.Max());
        Console.WriteLine(double_mass.Min());
    }
}