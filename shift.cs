using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Sıfırdan_Shift
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int computer_score = 0;
            int player_score = 0;
            int round_number = 1;
            int turn = 1;


            
            Console.WriteLine("Please choose the 1st number");
            int a11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the 2nd number");
            int a12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the 3rd number");
            int a13 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the 4th number");
            int a21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the 5th number");
            int a22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the 6th number");
            int a23 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the 7th number");
            int a31 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the 8th number");
            int a32 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the 9th number");
            int a33 = Convert.ToInt32(Console.ReadLine());
            


            int board_score = 0;

            while (round_number <= 5)
            {



                if (board_score > 0)
                {

                    if (round_number > 1)
                    {

                        Random rnd = new Random();

                        turn = 1;

                        do
                        {
                            a11 = rnd.Next(1, 10);
                            a12 = rnd.Next(1, 10);
                            a13 = rnd.Next(1, 10);
                            a21 = rnd.Next(1, 10);
                            a22 = rnd.Next(1, 10);
                            a23 = rnd.Next(1, 10);
                            a31 = rnd.Next(1, 10);
                            a32 = rnd.Next(1, 10);
                            a33 = rnd.Next(1, 10);
                        } while (a11 == a12 || a11 == a13 || a11 == a21 || a11 == a22 || a11 == a23 || a11 == a31 || a11 == a32 || a11 == a33 ||
                     a12 == a13 || a12 == a21 || a12 == a22 || a12 == a23 || a12 == a31 || a12 == a32 || a12 == a33 ||
                     a13 == a21 || a13 == a22 || a13 == a23 || a13 == a31 || a13 == a32 || a13 == a33 ||
                     a21 == a22 || a21 == a23 || a21 == a31 || a21 == a32 || a21 == a33 ||
                     a22 == a23 || a22 == a31 || a22 == a32 || a22 == a33 ||
                     a23 == a31 || a23 == a32 || a23 == a33 ||
                     a31 == a32 || a31 == a33 ||
                     a32 == a33);


                    }
                }

                board_score = 0;




                int fark1 = Math.Abs(a11 - a12); int fark2 = Math.Abs(a12 - a13); int fark3 = Math.Abs(a11 - a22); int fark4 = Math.Abs(a22 - a33);
                int fark5 = Math.Abs(a13 - a22); int fark6 = Math.Abs(a22 - a31); int fark7 = Math.Abs(a11 - a21); int fark8 = Math.Abs(a21 - a31);
                int fark9 = Math.Abs(a12 - a22); int fark10 = Math.Abs(a22 - a32); int fark11 = Math.Abs(a13 - a23); int fark12 = Math.Abs(a23 - a33);
                int fark13 = Math.Abs(a21 - a22); int fark14 = Math.Abs(a22 - a23); int fark15 = Math.Abs(a31 - a32); int fark16 = Math.Abs(a32 - a33);

                if (fark1 == 1 && fark2 == 1)
                {

                    board_score++;
                }
                if (fark3 == 1 && fark4 == 1)
                {
                    board_score++;

                }
                if (fark5 == 1 && fark6 == 1)
                {
                    board_score++;
                }
                if (fark7 == 1 && fark8 == 1)
                {
                    board_score++;
                }
                if (fark9 == 1 && fark10 == 1)
                {
                    board_score++;

                }
                if (fark11 == 1 && fark12 == 1)
                {
                    board_score++;
                }
                if (fark13 == 1 && fark14 == 1)
                {
                    board_score++;

                }
                if (fark15 == 1 && fark16 == 1)
                {
                    board_score++;
                }

                board_score = board_score * board_score;

                Console.WriteLine("--------------- Round  " + round_number + "---------------");
                Console.WriteLine("");
                Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                string hiza;

                while (board_score > 0)
                {

                    Console.WriteLine("Choose the line you want to operate on : ");
                    Console.WriteLine("1 - 2 - 3 - 4 - 5 - 6");
                    hiza = Console.ReadLine();

                    if (hiza == "1")
                    {


                        int yedek;
                        yedek = a13;
                        a13 = a12;
                        a12 = a11;
                        a11 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;





                        Console.WriteLine("--------------- Round  " + round_number + "---------------");
                        Console.WriteLine("");
                        Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                        Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                        Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                        Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                        Console.WriteLine("Command: " + hiza);




                    }

                    else if (hiza == "2")
                    {
                        int yedek;
                        yedek = a23;
                        a23 = a22;
                        a22 = a21;
                        a21 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;




                        Console.WriteLine("--------------- Round  " + round_number + "---------------");
                        Console.WriteLine("");
                        Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                        Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                        Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                        Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                        Console.WriteLine("Command: " + hiza);






                    }
                    else if (hiza == "3")
                    {
                        int yedek;
                        yedek = a33;
                        a33 = a32;
                        a32 = a31;
                        a31 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);


                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;




                        Console.WriteLine("--------------- Round  " + round_number + "---------------");
                        Console.WriteLine("");
                        Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                        Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                        Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                        Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                        Console.WriteLine("Command: " + hiza);



                    }
                    else if (hiza == "4")
                    {
                        int yedek;
                        yedek = a31;
                        a31 = a21;
                        a21 = a11;
                        a11 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;




                        Console.WriteLine("--------------- Round  " + round_number + "---------------");
                        Console.WriteLine("");
                        Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                        Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                        Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                        Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                        Console.WriteLine("Command: " + hiza);



                    }
                    else if (hiza == "5")
                    {
                        int yedek;
                        yedek = a32;
                        a32 = a22;
                        a22 = a12;
                        a12 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;




                        Console.WriteLine("--------------- Round  " + round_number + "---------------");
                        Console.WriteLine("");
                        Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                        Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                        Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                        Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                        Console.WriteLine("Command: " + hiza);



                    }
                    else if (hiza == "6")
                    {
                        int yedek;
                        yedek = a33;
                        a33 = a23;
                        a23 = a13;
                        a13 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;
                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;




                        Console.WriteLine("--------------- Round  " + round_number + "---------------");
                        Console.WriteLine("");
                        Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                        Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                        Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                        Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                        Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                        Console.WriteLine("Command: " + hiza);

                    }

                    turn++;

                    int last_board_score;

                    last_board_score = board_score;





                    ///////
                    ///     COMPUTER
                    ///     TURN
                    ///



                    String hiza_of_artificial_board_score1 = "1";
                    int max1_artificial_board_score = 0;

                    int max1_artificial_a11 = a13;
                    int max1_artificial_a12 = a11;
                    int max1_artificial_a13 = a12;
                    int max1_artificial_a21 = a21;
                    int max1_artificial_a22 = a22;
                    int max1_artificial_a23 = a23;
                    int max1_artificial_a31 = a31;
                    int max1_artificial_a32 = a32;
                    int max1_artificial_a33 = a33;



                    for (int i = 1; i <= 6; i++)
                    {

                        String artificial_hiza = Convert.ToString(i);
                        int artificial_board_score = 0;

                        int artificial_a11 = a11;
                        int artificial_a12 = a12;
                        int artificial_a13 = a13;
                        int artificial_a21 = a21;
                        int artificial_a22 = a22;
                        int artificial_a23 = a23;
                        int artificial_a31 = a31;
                        int artificial_a32 = a32;
                        int artificial_a33 = a33;

                        ////
                        //// Board Score Calculation Based on Hiza
                        ///                 Start
                        ///


                        if (artificial_hiza == "1")
                        {


                            int yedek;
                            yedek = artificial_a13;
                            artificial_a13 = artificial_a12;
                            artificial_a12 = artificial_a11;
                            artificial_a11 = yedek;

                            fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                            fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                            fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                            fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);

                            

                            if (fark1 == 1 && fark2 == 1)
                            {

                                artificial_board_score++;
                            }
                            if (fark3 == 1 && fark4 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark5 == 1 && fark6 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark7 == 1 && fark8 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark9 == 1 && fark10 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark11 == 1 && fark12 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark13 == 1 && fark14 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark15 == 1 && fark16 == 1)
                            {
                                artificial_board_score++;
                            }

                            artificial_board_score = artificial_board_score * artificial_board_score;
                        }

                        else if (artificial_hiza == "2")
                        {
                            int yedek;
                            yedek = artificial_a23;
                            artificial_a23 = artificial_a22;
                            artificial_a22 = artificial_a21;
                            artificial_a21 = yedek;

                            fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                            fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                            fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                            fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);

                            

                            if (fark1 == 1 && fark2 == 1)
                            {

                                artificial_board_score++;
                            }
                            if (fark3 == 1 && fark4 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark5 == 1 && fark6 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark7 == 1 && fark8 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark9 == 1 && fark10 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark11 == 1 && fark12 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark13 == 1 && fark14 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark15 == 1 && fark16 == 1)
                            {
                                artificial_board_score++;
                            }

                            artificial_board_score = artificial_board_score * artificial_board_score;

                        }
                        else if (artificial_hiza == "3")
                        {
                            int yedek;
                            yedek = artificial_a33;
                            artificial_a33 = artificial_a32;
                            artificial_a32 = artificial_a31;
                            artificial_a31 = yedek;

                            fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                            fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                            fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                            fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);

                            

                            if (fark1 == 1 && fark2 == 1)
                            {

                                artificial_board_score++;
                            }
                            if (fark3 == 1 && fark4 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark5 == 1 && fark6 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark7 == 1 && fark8 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark9 == 1 && fark10 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark11 == 1 && fark12 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark13 == 1 && fark14 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark15 == 1 && fark16 == 1)
                            {
                                artificial_board_score++;
                            }

                            artificial_board_score = artificial_board_score * artificial_board_score;


                        }
                        else if (artificial_hiza == "4")
                        {
                            int yedek;
                            yedek = artificial_a31;
                            artificial_a31 = artificial_a21;
                            artificial_a21 = artificial_a11;
                            artificial_a11 = yedek;

                            fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                            fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                            fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                            fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);

                            

                            if (fark1 == 1 && fark2 == 1)
                            {

                                artificial_board_score++;
                            }
                            if (fark3 == 1 && fark4 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark5 == 1 && fark6 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark7 == 1 && fark8 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark9 == 1 && fark10 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark11 == 1 && fark12 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark13 == 1 && fark14 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark15 == 1 && fark16 == 1)
                            {
                                artificial_board_score++;
                            }

                            artificial_board_score = artificial_board_score * artificial_board_score;

                        }
                        else if (artificial_hiza == "5")
                        {
                            int yedek;
                            yedek = artificial_a32;
                            artificial_a32 = artificial_a22;
                            artificial_a22 = artificial_a12;
                            artificial_a12 = yedek;

                            fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                            fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                            fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                            fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);

                            

                            if (fark1 == 1 && fark2 == 1)
                            {

                                artificial_board_score++;
                            }
                            if (fark3 == 1 && fark4 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark5 == 1 && fark6 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark7 == 1 && fark8 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark9 == 1 && fark10 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark11 == 1 && fark12 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark13 == 1 && fark14 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark15 == 1 && fark16 == 1)
                            {
                                artificial_board_score++;
                            }

                            artificial_board_score = artificial_board_score * artificial_board_score;


                        }
                        else if (artificial_hiza == "6")
                        {
                            int yedek;
                            yedek = artificial_a33;
                            artificial_a33 = artificial_a23;
                            artificial_a23 = artificial_a13;
                            artificial_a13 = yedek;

                            fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                            fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                            fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                            fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);

                            

                            if (fark1 == 1 && fark2 == 1)
                            {

                                artificial_board_score++;
                            }
                            if (fark3 == 1 && fark4 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark5 == 1 && fark6 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark7 == 1 && fark8 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark9 == 1 && fark10 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark11 == 1 && fark12 == 1)
                            {
                                artificial_board_score++;
                            }
                            if (fark13 == 1 && fark14 == 1)
                            {
                                artificial_board_score++;

                            }
                            if (fark15 == 1 && fark16 == 1)
                            {
                                artificial_board_score++;
                            }

                            artificial_board_score = artificial_board_score * artificial_board_score;
                        }


                        //Cons4ole.WriteLine("For Hiza " + artificial_hiza + " Artificial Board Score is : " + artificial_board_score);


                        if (artificial_board_score > max1_artificial_board_score)
                        {
                            max1_artificial_board_score = artificial_board_score;
                            hiza_of_artificial_board_score1 = artificial_hiza;


                            max1_artificial_a11 = artificial_a11;
                            max1_artificial_a12 = artificial_a12;
                            max1_artificial_a13 = artificial_a13;
                            max1_artificial_a21 = artificial_a21;
                            max1_artificial_a22 = artificial_a22;
                            max1_artificial_a23 = artificial_a23;
                            max1_artificial_a31 = artificial_a31;
                            max1_artificial_a32 = artificial_a32;
                            max1_artificial_a33 = artificial_a33;

                            board_score = artificial_board_score;
                        }


                        ////
                        //// Board Score Calculation Based on Hiza
                        ///                 End
                        ///                 

                    }




                    /// Make the move for real
                    a11 = max1_artificial_a11;
                    a12 = max1_artificial_a12;
                    a13 = max1_artificial_a13;
                    a21 = max1_artificial_a21;
                    a22 = max1_artificial_a22;
                    a23 = max1_artificial_a23;
                    a31 = max1_artificial_a31;
                    a32 = max1_artificial_a32;
                    a33 = max1_artificial_a33;

                    

                    if (last_board_score != 0)
                    {
                        


                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Computer");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza_of_artificial_board_score1);
                        

                        turn++;
                    }



                    if (last_board_score == 0)
                    {
                        if (board_score > 0)
                        {
                            computer_score += board_score;

                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Computer");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza_of_artificial_board_score1);
                            Console.WriteLine("End of Round");

                        }
                        else
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Computer");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza_of_artificial_board_score1);
                        }

                        break;

                    }

                    //////
                    ///     End Of Computer Turn
                    /// 


                }
                turn++;
                

                if (board_score == 0)
                {

                    Console.WriteLine("Choose the line you want to operate on : ");
                    Console.WriteLine("1 - 2 - 3 - 4 - 5 - 6");
                    hiza = Console.ReadLine();

                    if (hiza == "1")
                    {
                        int yedek;
                        yedek = a13;
                        a13 = a12;
                        a12 = a11;
                        a11 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;

                        player_score = board_score + player_score;

                        if (board_score > 0)
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                            Console.WriteLine("End of the round");



                        }
                        else
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                        }
                    }

                    else if (hiza == "2")
                    {
                        int yedek;
                        yedek = a23;
                        a23 = a22;
                        a22 = a21;
                        a21 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;

                        player_score = board_score + player_score;

                        if (board_score > 0)
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                            Console.WriteLine("End of the round");



                        }
                        else
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                        }
                    }
                    else if (hiza == "3")
                    {
                        int yedek;
                        yedek = a33;
                        a33 = a32;
                        a32 = a31;
                        a31 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);


                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;

                        player_score = board_score + player_score;

                        if (board_score > 0)
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                            Console.WriteLine("End of the round");



                        }
                        else
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                        }
                    }
                    else if (hiza == "4")
                    {
                        int yedek;
                        yedek = a31;
                        a31 = a21;
                        a21 = a11;
                        a11 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;

                        player_score = board_score + player_score;

                        if (board_score > 0)
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                            Console.WriteLine("End of the round");

                            

                        }
                        else
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                        }
                    }
                    else if (hiza == "5")
                    {
                        int yedek;
                        yedek = a32;
                        a32 = a22;
                        a22 = a12;
                        a12 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;

                        player_score = board_score + player_score;

                        if (board_score > 0)
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                            Console.WriteLine("End of the round");



                        }
                        else
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                        }
                    }
                    else if (hiza == "6")
                    {
                        int yedek;
                        yedek = a33;
                        a33 = a23;
                        a23 = a13;
                        a13 = yedek;

                        fark1 = Math.Abs(a11 - a12); fark2 = Math.Abs(a12 - a13); fark3 = Math.Abs(a11 - a22); fark4 = Math.Abs(a22 - a33);
                        fark5 = Math.Abs(a13 - a22); fark6 = Math.Abs(a22 - a31); fark7 = Math.Abs(a11 - a21); fark8 = Math.Abs(a21 - a31);
                        fark9 = Math.Abs(a12 - a22); fark10 = Math.Abs(a22 - a32); fark11 = Math.Abs(a13 - a23); fark12 = Math.Abs(a23 - a33);
                        fark13 = Math.Abs(a21 - a22); fark14 = Math.Abs(a22 - a23); fark15 = Math.Abs(a31 - a32); fark16 = Math.Abs(a32 - a33);

                        board_score = 0;

                        if (fark1 == 1 && fark2 == 1)
                        {

                            board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            board_score++;
                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            board_score++;
                        }

                        board_score = board_score * board_score;

                        player_score = board_score + player_score;

                        if (board_score > 0)
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);
                            Console.WriteLine("Command: " + hiza);

                            Console.WriteLine("End of the round");



                        }
                        else
                        {
                            Console.WriteLine("--------------- Round  " + round_number + "---------------");
                            Console.WriteLine("");
                            Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Player");
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                            Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                            Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                            Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                            Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                            Console.WriteLine("Command: " + hiza);

                        }

                    }

                }



                // Decide if the round is over or not


                if (board_score > 0)
                {


                    round_number++;
                    continue;
                }




                turn++;





                ///////
                ///     COMPUTER
                ///     TURN
                ///


                String hiza_of_artificial_board_score = "1";
                int max_artificial_board_score = 0;

                int max_artificial_a11 = a13;
                int max_artificial_a12 = a11;
                int max_artificial_a13 = a12;
                int max_artificial_a21 = a21;
                int max_artificial_a22 = a22;
                int max_artificial_a23 = a23;
                int max_artificial_a31 = a31;
                int max_artificial_a32 = a32;
                int max_artificial_a33 = a33;



                for (int i = 1; i <= 6; i++)
                {

                    String artificial_hiza = Convert.ToString(i);
                    int artificial_board_score = 0;

                    int artificial_a11 = a11;
                    int artificial_a12 = a12;
                    int artificial_a13 = a13;
                    int artificial_a21 = a21;
                    int artificial_a22 = a22;
                    int artificial_a23 = a23;
                    int artificial_a31 = a31;
                    int artificial_a32 = a32;
                    int artificial_a33 = a33;

                    ////
                    //// Board Score Calculation Based on Hiza
                    ///                 Start
                    ///


                    if (artificial_hiza == "1")
                    {


                        int yedek;
                        yedek = artificial_a13;
                        artificial_a13 = artificial_a12;
                        artificial_a12 = artificial_a11;
                        artificial_a11 = yedek;

                        fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                        fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                        fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                        fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);


                        if (fark1 == 1 && fark2 == 1)
                        {

                            artificial_board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            artificial_board_score++;
                        }

                        artificial_board_score = artificial_board_score * artificial_board_score;
                    }

                    else if (artificial_hiza == "2")
                    {
                        int yedek;
                        yedek = artificial_a23;
                        artificial_a23 = artificial_a22;
                        artificial_a22 = artificial_a21;
                        artificial_a21 = yedek;

                        fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                        fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                        fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                        fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);


                        if (fark1 == 1 && fark2 == 1)
                        {

                            artificial_board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            artificial_board_score++;
                        }

                        artificial_board_score = artificial_board_score * artificial_board_score;

                    }
                    else if (artificial_hiza == "3")
                    {
                        int yedek;
                        yedek = artificial_a33;
                        artificial_a33 = artificial_a32;
                        artificial_a32 = artificial_a31;
                        artificial_a31 = yedek;

                        fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                        fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                        fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                        fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);



                        if (fark1 == 1 && fark2 == 1)
                        {

                            artificial_board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            artificial_board_score++;
                        }

                        artificial_board_score = artificial_board_score * artificial_board_score;


                    }
                    else if (artificial_hiza == "4")
                    {
                        int yedek;
                        yedek = artificial_a31;
                        artificial_a31 = artificial_a21;
                        artificial_a21 = artificial_a11;
                        artificial_a11 = yedek;

                        fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                        fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                        fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                        fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);


                        if (fark1 == 1 && fark2 == 1)
                        {

                            artificial_board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            artificial_board_score++;
                        }

                        artificial_board_score = artificial_board_score * artificial_board_score;

                    }
                    else if (artificial_hiza == "5")
                    {
                        int yedek;
                        yedek = artificial_a32;
                        artificial_a32 = artificial_a22;
                        artificial_a22 = artificial_a12;
                        artificial_a12 = yedek;

                        fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                        fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                        fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                        fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);


                        if (fark1 == 1 && fark2 == 1)
                        {

                            artificial_board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            artificial_board_score++;
                        }

                        artificial_board_score = artificial_board_score * artificial_board_score;


                    }
                    else if (artificial_hiza == "6")
                    {
                        int yedek;
                        yedek = artificial_a33;
                        artificial_a33 = artificial_a23;
                        artificial_a23 = artificial_a13;
                        artificial_a13 = yedek;

                        fark1 = Math.Abs(artificial_a11 - artificial_a12); fark2 = Math.Abs(artificial_a12 - artificial_a13); fark3 = Math.Abs(artificial_a11 - artificial_a22); fark4 = Math.Abs(artificial_a22 - artificial_a33);
                        fark5 = Math.Abs(artificial_a13 - artificial_a22); fark6 = Math.Abs(artificial_a22 - artificial_a31); fark7 = Math.Abs(artificial_a11 - artificial_a21); fark8 = Math.Abs(artificial_a21 - artificial_a31);
                        fark9 = Math.Abs(artificial_a12 - artificial_a22); fark10 = Math.Abs(artificial_a22 - artificial_a32); fark11 = Math.Abs(artificial_a13 - artificial_a23); fark12 = Math.Abs(artificial_a23 - artificial_a33);
                        fark13 = Math.Abs(artificial_a21 - artificial_a22); fark14 = Math.Abs(artificial_a22 - artificial_a23); fark15 = Math.Abs(artificial_a31 - artificial_a32); fark16 = Math.Abs(artificial_a32 - artificial_a33);


                        if (fark1 == 1 && fark2 == 1)
                        {

                            artificial_board_score++;
                        }
                        if (fark3 == 1 && fark4 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark5 == 1 && fark6 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark7 == 1 && fark8 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark9 == 1 && fark10 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark11 == 1 && fark12 == 1)
                        {
                            artificial_board_score++;
                        }
                        if (fark13 == 1 && fark14 == 1)
                        {
                            artificial_board_score++;

                        }
                        if (fark15 == 1 && fark16 == 1)
                        {
                            artificial_board_score++;
                        }

                        artificial_board_score = artificial_board_score * artificial_board_score;


                    }


                    //Cons4ole.WriteLine("For Hiza " + artificial_hiza + " Artificial Board Score is : " + artificial_board_score);


                    if (artificial_board_score > max_artificial_board_score)
                    {
                        max_artificial_board_score = artificial_board_score;
                        hiza_of_artificial_board_score = artificial_hiza;


                        max_artificial_a11 = artificial_a11;
                        max_artificial_a12 = artificial_a12;
                        max_artificial_a13 = artificial_a13;
                        max_artificial_a21 = artificial_a21;
                        max_artificial_a22 = artificial_a22;
                        max_artificial_a23 = artificial_a23;
                        max_artificial_a31 = artificial_a31;
                        max_artificial_a32 = artificial_a32;
                        max_artificial_a33 = artificial_a33;

                        board_score = artificial_board_score;

                        computer_score += artificial_board_score;
                    }


                    ////
                    //// Board Score Calculation Based on Hiza
                    ///                 End
                    ///                 

                }




                /// Make the move for real
                a11 = max_artificial_a11;
                a12 = max_artificial_a12;
                a13 = max_artificial_a13;
                a21 = max_artificial_a21;
                a22 = max_artificial_a22;
                a23 = max_artificial_a23;
                a31 = max_artificial_a31;
                a32 = max_artificial_a32;
                a33 = max_artificial_a33;




                if (board_score > 0)
                {
                    Console.WriteLine("--------------- Round  " + round_number + "---------------");
                    Console.WriteLine("");
                    Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Computer");
                    Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                    Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                    Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                    Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                    Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                    Console.WriteLine("Command: " + hiza_of_artificial_board_score);

                    Console.WriteLine("End of Round");
                }

                else
                {
                    Console.WriteLine("--------------- Round  " + round_number + "---------------");
                    Console.WriteLine("");
                    Console.WriteLine("    4" + " 5" + " 6" + "       " + " Turn :  " + turn + "/  Computer");
                    Console.WriteLine("  +" + " -" + " -" + " -" + " +");
                    Console.WriteLine("1" + " | " + a11 + " " + a12 + " " + a13 + " | " + "     Board Score    :   " + board_score);
                    Console.WriteLine("2" + " | " + a21 + " " + a22 + " " + a23 + " | ");
                    Console.WriteLine("3" + " | " + a31 + " " + a32 + " " + a33 + " | " + "     Player Score   :   " + player_score);
                    Console.WriteLine("  +" + " -" + " -" + " -" + " +" + "      Computer Score :   " + computer_score);

                    Console.WriteLine("Command: " + hiza_of_artificial_board_score);
                }




                turn++;



                //////
                ///     End Of Computer Turn
                /// 




                if (board_score > 0)
                {
                    round_number++;
                }
            }
            Console.ReadLine();

        }
    }
}

