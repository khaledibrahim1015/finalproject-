using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("********* Menu OF Cars ************* " +
                    "\n 1- add Car TO M \n 2- add Car TO L \n 3- add Car TO H"
                               + "\n 4- show Car From M \n 5- show Car From L \n 6- show Car From H\n 7- search by id ");
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("enter Number of Choice From Menue  :");
                int ch = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                String name=" ",color=" ";
                int id=0;
                double price=0;
                if (ch == 1 || ch == 2 || ch == 3)
                {
                    Console.WriteLine("Enter Name OF Cars ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Color OF Cars ");
                    color = Console.ReadLine();
                    Console.WriteLine("Enter Id OF Cars ");
                    id = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Price OF Cars ");
                    price = Double.Parse(Console.ReadLine());
                }
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Blue;
                switch (ch)
                {
                    case 1:
                        M m = new M();
                        m.Name = name;
                        m.Id = id;
                        m.Price = price;
                        m.Color = color;
                        m.Add_data();
                        Console.WriteLine(" Done to M");
                        break;
                    case 2:
                        L l = new L();
                        l.Name = name;
                        l.Id = id;
                        l.Price = price;
                        l.Color = color;
                        l.Add_data();
                        Console.WriteLine(" Done to L");
                        break;
                    case 3:
                        H h = new H();
                        h.Name = name;
                        h.Id = id;
                        h.Price = price;
                        h.Color = color;
                        h.Add_data();
                        Console.WriteLine(" Done to H");
                        break;
                    case 4:
                        M mm = new M();
                        String[] arr = mm.Show_result();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            try
                            {
                                String[] ss = arr[i].Split(' ');
                                Console.WriteLine("id is : " + ss[0] + " " +
                                    "and name Cars is : " + ss[1] +
                                   " price is :" + ss[3] +
                                   "and color is " + ss[2]);
                            } catch (Exception e)
                            { 

                            }

                        }    
                        break;
                    case 5:
                        L ll = new L();
                        String[] arr1 = ll.Show_result();
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            String[] ss1 = arr1[i].Split(' ');
                            for (int j = 0; j < ss1.Length; j++)
                            {
                                Console.WriteLine(ss1[j] + " ");
                            }
                        }
                        break;
                    case 6:
                        H hh = new H();
                        String[] arr2 = hh.Show_result();
                        for (int i = 0; i < arr2.Length; i++)
                        {
                            String[] ss2 = arr2[i].Split(' ');
                            for (int j = 0; j < ss2.Length; j++)
                            {
                                Console.WriteLine(ss2[j] + " ");
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("enter id ");
                        int new_id =Int32.Parse( Console.ReadLine());
                        H hh1 = new H();
                        M hh2 = new M();
                        L hh3 = new L();
                        String[] l1 = hh1.Show_result();
                        String[] l2 = hh2.Show_result();
                        String[] l3 = hh3.Show_result();
                        for (int i=0;i<l1.Length; i++)
                        {
                            if(l1[i].Contains(new_id.ToString()))
                             Console.WriteLine(l1[i]);
                        }
                        for (int i = 0; i < l2.Length; i++)
                        {
                            if (l2[i].Contains(new_id.ToString()))
                                Console.WriteLine(l2[i]);
                        }
                        for (int i = 0; i < l3.Length; i++)
                        {
                            if (l3[i].Contains(new_id.ToString()))
                                Console.WriteLine(l3[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("to show menu enter yes ");
                s = Console.ReadLine();
            } while (s == "yes");
        }
    }
}
