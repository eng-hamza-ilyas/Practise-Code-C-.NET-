using System;

class program
{
    static void Main() {
        //Console.WriteLine("Hello, World!");
        //program obh = new program(); 
        //    obh.Main1();
        //program.user();
        //mins();
        //condition();
        ////ternry();
        //conversion();
        //lop();
        //arys();
        forch();
    }

    public void Main1()
    {
        Console.WriteLine("Hello, Stallions!");

    }

    public static void user()
    {
        Console.WriteLine("Enter your Name");
        string naam = Console.ReadLine();
        Console.WriteLine("Hello" + " " + naam);
        string fname = Console.ReadLine();
        Console.WriteLine("Hello {0} {1}", naam, fname);
    }

    public static void mins()
    {
        int i = 0;
        Console.WriteLine("Min {0} ", int.MinValue);
        Console.WriteLine("Max {0} ", int.MaxValue);

        /*  double a = 123.97897;
          Console.WriteLine(a);*/

    }

    public static void strng()
    {
        string s = "\"Haider\"";
        Console.WriteLine(s);

    }

    public static void condition()
    {
       
            int number = 10;
            int anothernumber = 21;
            Console.WriteLine("Enter try number");
            Console.ReadLine();
            if (number == 10 && anothernumber == 21)
            {
                Console.WriteLine("Hiee");
            }

            else if(number != 10 && anothernumber != 21)
            {
                Console.WriteLine("wrong");
            }

            else
        {
            Console.WriteLine("Sorry");
        }
        
       
    }

    public static void ternry()
    {
        int Number = 11;
        bool Isnumber = Number == 10 ? true : false;
        //if(Number == 10)
        //{
        //    Isnumber = true;
        //}
        //else
        //{
        //    Isnumber = false;
        //}
        Console.WriteLine("Number is {0}", Isnumber);
    }

    static void conversion()
    {
        float f = 123.80F;
        int i = Convert.ToInt32(f);
        Console.WriteLine(i);
    }

    static void arys()
    {
        string[] marks = new string[2] {"Hi", "Ali"};
        Console.WriteLine(marks[1]);
    }
    static void swtch(){

        Console.WriteLine("Enter the number");
        int a = int.Parse(Console.ReadLine());

        switch (a)
        {
            case 12:
                Console.WriteLine("Good");
                break;
                case 13:
                Console.WriteLine("Excellent");
                 break ;
            default:
                Console.WriteLine("No any");
                break;
        }
        }
    public static void forch()
    {
        try
        {
            int[] ort = new int[3];
            ort[0] = 122;
            ort[1] = 133;
            ort[2] = 155;


            foreach (int i in ort)
            {
                if (i == 133)
                {

                    Console.WriteLine(i.ToString());
                }
            }
            for (int i = 0; i < ort.Length; i++)
            {
                if (ort[i] == 155)
                {
                    Console.WriteLine(ort[i]);
                }
            }
        }
        catch (Exception ex)
        {

            throw;
        }
    }

    public static void lop()
    {
        for(int i=1; i<=20; i++)
        {
            Console.WriteLine(i.ToString());
        }
    }

}
