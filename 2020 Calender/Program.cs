using System;

namespace _2020_Calender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2020 Calander");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=========Janury==========");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("            ");

            for (int num = 1; num <= 31; num = num + 1)
            {
                if (num <= 4)
                {
                    Console.Write(num + "   ");

                }

                if (num == 4)
                {
                    Console.WriteLine();

                }

                if (num >= 5 && num <= 11)
                {
                    if (num >= 10)
                    {
                        Console.Write(num + "  ");
                    }
                    else
                    {
                        Console.Write(num + "   ");
                    }
                }
               
                if (num == 11)
                {
                    Console.WriteLine();
                }

                if (num >= 12 && num <= 18)
                {
                    Console.Write(num + "  ");

                }
                if ( num == 18)
                {
                    Console.WriteLine();

                }

                if ( num >= 19 && num <= 25)
                {
                    Console.Write(num + "  ");

                }

                if (num == 25)
                {
                    Console.WriteLine();

                }

                if (num >= 26 && num <= 31)
                {
                    Console.Write(num + "  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            int february = 1;
            Console.WriteLine("=========February=========");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("                        ");

            while(february <= 31)
            {
                if (february <= 1)
                {
                    Console.Write(february + "   ");
                }

                if (february == 1)
                {
                    Console.WriteLine();
                }

                if (february >= 2 && february <= 8)
                {
                    Console.Write(february + "   ");
                }

                if (february == 8)
                {
                    Console.WriteLine();
                }

                if (february >= 9 && february <= 15)
                {
                    if (february >= 10)
                    {
                        Console.Write(february + "  ");
                    }
                    else
                    {
                        Console.Write(february + "   ");
                    }
                }

                if (february == 15)
                {
                    Console.WriteLine();
                }

                if (february >= 16 &&  february <= 22)
                {
                    Console.Write(february + "  ");

                }

                if (february == 22)
                {
                    Console.WriteLine();

                }

                if (february >= 23 && february <= 29)
                {
                    Console.Write(february + "  ");
                }
                february++;
            }
            Console.WriteLine();
            Console.WriteLine();

            int March = 1;

            Console.WriteLine("=========March===========");
            Console.WriteLine("S   M   T   W   T   F   S");

            while (March <= 31)
            {
                if (March <= 7)
                {
                    Console.Write(March + "   ");

                }
                if (March == 7)
                {
                    Console.WriteLine();

                }

                if (March >= 8 && March <= 14)
                {
                    if (March >= 10)
                    {
                        Console.Write(March + "  ");

                    }
                    else
                    {
                        Console.Write(March + "   ");
                    }
                }

                if (March == 14)
                {
                    Console.WriteLine();
                }

                if (March >= 15 && March <= 21)
                {
                    Console.Write(March + "  ");
                }

                if (March == 21)
                {
                    Console.WriteLine();
                }

                if (March >= 22 && March <= 28)
                {
                    Console.Write(March + "  ");

                }

                if (March == 28)
                {
                    Console.WriteLine();
                }

                if (March >= 29 && March <= 31)
                {
                    Console.Write(March + "  ");
                }
                March = March + 1;
            }
            Console.WriteLine();
            Console.WriteLine();

            int April = 1;

            Console.WriteLine("=========April===========");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("            ");
            while(April <= 31)
            {
                if (April <= 4)
                {
                    Console.Write(April + "   ");

                }

                if (April == 4)
                {
                    Console.WriteLine();

                }

                if (April >= 5 && April <= 11)
                {
                    if (April >= 10)
                    {
                        Console.Write(April + "  ");

                    }
                    else
                    {
                        Console.Write(April + "   ");
                    }
                }
                if (April == 11)
                {
                    Console.WriteLine();

                }

                if (April >= 12 && April <= 18)
                {
                    Console.Write(April + "  ");
                }

                if (April == 18)
                {
                    Console.WriteLine();
                }

                if (April >= 19 && April <= 25)
                {
                    Console.Write(April + "  ");
                }

                if (April == 25)
                {
                    Console.WriteLine();
                }

                if (April >= 26 && April <= 30)
                {
                    Console.Write(April + "  ");
                }
                April++;
            }
            Console.WriteLine();
            Console.WriteLine();

            int May = 1;

            Console.WriteLine("============May===========");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("                    ");
            while(May <= 31)
            {
                if (May <= 2)
                {
                    Console.Write(May + "   ");

                }

                if (May == 2)
                {
                    Console.WriteLine();
                }

                if (May >= 3 && May <= 9)
                {
                    if (May >= 10)
                    {
                        Console.Write(May + "  ");
                    }
                    else
                    {
                        Console.Write(May + "   ");
                    }
                }

                if (May == 9)
                {
                    Console.WriteLine();
                }


                if (May >= 10 && May <= 16)
                {
                    Console.Write(May + "  ");
                }

                if (May == 16)
                {
                    Console.WriteLine();
                }

                if (May >= 17 && May <= 23)
                {
                    Console.Write(May + "  ");
                }

                if (May == 23)
                {
                    Console.WriteLine();
                }

                if (May >= 24 && May <= 30)
                {
                    Console.Write(May + "  ");
                }
                if (May == 30)
                {
                    Console.WriteLine();
                }

                if (May == 31)
                {
                    Console.Write(May + "  ");
                }
                May = May + 1;
            }

            Console.WriteLine();
            Console.WriteLine();

            int June = 1;

            Console.WriteLine("============June===========");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("    ");
            while(June <= 31)
            {
                if (June <= 6)
                {
                    Console.Write(June + "   ");
                }
                
                if (June == 6)
                {
                    Console.WriteLine();
                }
                
                if (June >= 7 && June <= 13)
                {
                    if (June >= 10)
                    {
                        Console.Write(June + "  ");
                    }
                    else
                    {
                        Console.Write(June + "   ");
                    }
                }
                
                if (June == 13)
                {
                    Console.WriteLine();
                }

                if (June >= 14 && June <= 20)
                {
                    Console.Write(June + "  ");
                }
                
                if (June == 20)
                {
                    Console.WriteLine();
                }

                if (June >= 21 && June <= 27)
                {
                    Console.Write(June + "  ");
                }
                
                if (June == 27)
                {
                    Console.WriteLine();
                }

                if (June >= 28 && June <= 30)
                {
                    Console.Write(June + "  ");
                }
                June = June + 1;
            }
            Console.WriteLine();
            Console.WriteLine();

            int July = 1;
            Console.WriteLine("===========July===========");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("            ");
            while(July <= 31)
            {
                if (July <= 4)
                {
                    Console.Write(July + "   ");
                }

                if (July == 4)
                {
                    Console.WriteLine();
                }

                if (July >= 5 && July <= 11)
                {
                    if (July >= 10)
                    {
                        Console.Write(July + "  ");
                    }
                    else
                    {
                        Console.Write(July + "   ");
                    }
                }

                if (July == 11)
                {
                    Console.WriteLine();
                } 

                if (July >= 12 && July <= 18)
                {
                    Console.Write(July + "  ");
                }

                if (July == 18)
                {
                    Console.WriteLine();
                }

                if (July >= 19 && July <= 25)
                {
                    Console.Write(July + "  ");
                }

                if (July == 25)
                {
                    Console.WriteLine();
                }

                if (July >= 26 && July <= 31)
                {
                    Console.Write(July + "  ");
                }
                July++;
            }
            Console.WriteLine();
            Console.WriteLine();

            int August = 1;

            Console.WriteLine("=========August==========");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("                        ");
            while (August <= 31)
            {
                if (August <= 1)
                {
                    Console.Write(August + "   ");
                }

                if (August == 1)
                {
                    Console.WriteLine();
                }

                if (August >= 2 && August <= 8)
                {
                    Console.Write(August + "   ");
                }

                if (August == 8)
                {
                    Console.WriteLine();
                }

                if (August >= 9 && August <= 15)
                {
                    if (August >= 10)
                    {
                        Console.Write(August + "  ");
                    }
                    else
                    {
                        Console.Write(August + "   ");
                    }
                }

                if(August == 15)
                {
                    Console.WriteLine();
                }

                if (August >= 16 && August <= 22)
                {
                    Console.Write(August + "  ");
                }

                if (August == 22)
                {
                    Console.WriteLine();
                }

                if (August >= 23 && August <= 29)
                {
                    Console.Write(August + "  ");
                }

                if (August == 29)
                {
                    Console.WriteLine();
                }

                if (August >= 30 && August <= 31)
                {
                    Console.Write(August + "  ");
                }
                August++;
            }
            Console.WriteLine();
            Console.WriteLine();

            int September = 1;
            Console.WriteLine("=========September=========");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("        ");
            while(September <= 31)
            {
                if (September <= 5)
                {
                    Console.Write(September + "   ");

                }

                if (September == 5)
                {
                    Console.WriteLine();
                }

                if (September >= 6 && September <= 12)
                {
                    if (September >= 10)
                    {
                        Console.Write(September + "  ");
                    }
                    else
                    {
                        Console.Write(September + "   ");
                    }
                }
                if (September == 12)
                {
                    Console.WriteLine();
                }

                if (September >= 13 && September <= 19)
                {
                    Console.Write(September + "  ");
                }

                if (September == 19)
                {
                    Console.WriteLine();
                }

                if (September >= 20 && September <= 26)
                {
                    Console.Write(September + "  ");
                }

                if (September == 27)
                {
                    Console.WriteLine();
                }

                if (September >= 28 && September <= 31)
                {
                    Console.Write(September + "  ");
                }
                September = September + 1;
            }

            Console.WriteLine();
            Console.WriteLine();

            int October = 1;
            Console.WriteLine("==========October=========");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("                ");

            while(October <= 31)
            {
                if (October <= 3)
                {
                    Console.Write(October + "   ");
                }

                if (October == 3)
                {
                    Console.WriteLine();
                }

                if (October >= 4 && October <= 10)
                {
                    if (October >= 10)
                    {
                        Console.Write(October + "  ");
                    }

                    else
                    {
                        Console.Write(October + "   ");
                    }
                }
                if (October == 10)
                {
                    Console.WriteLine();
                }

                if (October >= 11 && October <= 17)
                {
                    Console.Write(October + "  ");
                }

                if (October == 17)
                {
                    Console.WriteLine();
                }

                if (October >= 18 && October <= 24)
                {
                    Console.Write(October + "  ");
                }

                if ( October == 24)
                {
                    Console.WriteLine();
                }

                if (October >= 25 && October <= 31)
                {
                    Console.Write(October + "  ");
                }

                October = October + 1;   
            }

            Console.WriteLine();
            Console.WriteLine();

            int November = 1;
            Console.WriteLine("========November=========");
            Console.WriteLine("S   M   T   W   T   F   S");
           // Console.Write("                ");

            while(November <= 31)
            {
                if (November <= 7)
                {
                    Console.Write(November + "   ");
                }

                if (November == 7)
                {
                    Console.WriteLine();
                }

                if (November >= 8 && November <= 14)
                {
                    if (November >= 10)
                    {
                        Console.Write(November + "  ");
                    }
                  else
                    {
                        Console.Write(November + "   ");
                    }
                }

                if (November == 14)
                {
                    Console.WriteLine();
                }

                if (November >= 15 && November <= 21)
                {
                    Console.Write(November + "  ");
                }

                if (November == 21)
                {
                    Console.WriteLine();
                }

                if (November >= 22 && November <= 28)
                {
                    Console.Write(November + "  ");
                }

                if (November == 28)
                {
                    Console.WriteLine();
                }

                if (November >= 29 && November <= 30)
                {
                    Console.Write(November + "  ");
                }November++;
            }

            Console.WriteLine();
            Console.WriteLine();

            int December = 1;

            Console.WriteLine("==========December=============");
            Console.WriteLine("S   M   T   W   T   F   S");
            Console.Write("        ");

            while (December <= 31)
            {
                if (December <= 5)
                {
                    Console.Write(December + "   ");
                }

                if (December == 5)
                {
                    Console.WriteLine();
                }

                if (December >= 6 && December <= 12)
                {
                    if (December >= 10)
                    {
                        Console.Write(December + "  ");
                    }
                    else
                    {
                        Console.Write(December + "   ");
                    }
                  
                }

                if (December == 12)
                {
                    Console.WriteLine();
                }

                if (December >= 13 && December <= 19)
                {
                    Console.Write(December + "  ");

                }
                if (December == 20)
                {
                    Console.WriteLine();
                }

                if (December >= 21 && December <= 27)
                {
                    Console.Write(December + "  ");
                }

                if (December == 27)
                {
                    Console.WriteLine();
                }

                if (December >= 27 && December <= 31)
                {
                    Console.Write(December + "  ");
                }

                /*if (December == 29)
                {
                    Console.WriteLine();
                }

                if (December >= 30 && December <= 31)
                {
                    Console.Write(December + "  ");
                }*/
                December = December + 1;
            }
            Console.ReadKey();
        }
    }
}
