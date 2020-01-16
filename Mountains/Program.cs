using System;
using System.Linq;

namespace MountainsOrValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { -1, -1, 0, -1, -1 }; 
            bool mountain = IsMountain(myArray);
            bool valley = IsValley(myArray);

            if (mountain == true)
            {
                Console.WriteLine($"The answer to Mountain is {mountain}");
            }
            if (valley == true)
            {
                Console.WriteLine($"The answer to Valley is {valley}");
            }
            else
            {
                Console.WriteLine($"The answer to Valley or Mountain is Neither");
            }
            

            
            
        }

        public static bool IsMountain(int[] array)
        {
            int max = array.Max();
            int indexPeak = Array.IndexOf(array, max);
            int[] numberPeaks = Array.FindAll(array, x => x == max);
            int peaks = numberPeaks.Count();
            if (peaks != 1)
            {
                return false;
            }
            else
            {

            

            //Console.WriteLine($"max number is {max} and index peak is {indexPeak}");

            // If peak is BOUNDARY return false
            if (indexPeak == 0 | indexPeak == (array.Length - 1))
            {
                return false;
            }

            else
            {
                for (int i = 0; i < indexPeak; i++)
                {
                    // Check if all items left of the peak are in ascending order
                    if (array[i + 1] < array[i])
                    {
                        return false;
                    }
                    else 
                    {
                        // Check if the items on the right are in descending order
                        for (int j = (indexPeak + 1); j < (array.Length - 1); j++)
                        {
                            if (array[j] <=array[j + 1])
                            {
                                return false;
                            }
                            // It's a mountains
                            return true;
                        }
                    }
                    
                }
               

            }
            return true;
            }


        }

        public static bool IsValley (int[] array)
        {
            int min = array.Min();
            int indexTrough = Array.IndexOf(array, min);
            int[] numberPeaks = Array.FindAll(array, x => x == min);
            int peaks = numberPeaks.Count();
            if (peaks != 1)
            {
                return false;
            }
            else
            {

                //Console.WriteLine($"Minimun number is {min} and index trough is {indexTrough}");

                // If peak is BOUNDARY return false
                if (indexTrough == 0 | indexTrough == (array.Length - 1))
                {
                    return false;
                }

                else
                {
                    for (int i = 0; i < indexTrough; i++)
                    {
                        // Check if all items left of the peak are in descending order
                        if (array[i + 1] >= array[i])
                        {
                            return false;
                        }
                        else
                        {
                            // Check if the items on the right are in ascending order
                            for (int j = (indexTrough + 1); j < (array.Length - 1); j++)
                            {
                                if (array[j] >= array[j + 1])
                                {
                                    return false;
                                }
                                // It's a valley
                                return true;
                            }
                        }

                    }


                }
                return true;
            }
        }
    }
}
