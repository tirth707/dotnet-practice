using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Rupees:");
        double rupees=double.Parse(Console.ReadLine()+"\n");

        double dollar=rupees/90.44;
        Console.WriteLine("dollar is:"+dollar+"\n");

        double euro=rupees/106.58;
        Console.WriteLine("euro is :"+euro+"\n");

        double franc=rupees/108;
        Console.WriteLine("Franc is :"+franc+"\n");

        double diram=rupees/24.68;
        Console.WriteLine("Diram is :"+diram+"\n");
        double pak = rupees*0.32;
        Console.WriteLine("Pakistani Rupees is :"+pak+"\n");

        double yan = rupees *1.73;
        Console.WriteLine("Japanese Yan is :"+yan+"\n");

        double pound = rupees/0.0081;
        Console.WriteLine("Britrish Pound is :"+pound+"\n");

        double ruble = rupees*1.19;
        Console.WriteLine("Russian RUble is :"+ruble+"\n");

    }
}