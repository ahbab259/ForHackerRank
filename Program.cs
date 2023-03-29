using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ForHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initiators
            //Console.WriteLine(16 + 7 % 16);
            //int[] c = { 0, 0, 1, 0, 0, 1, 1, 0 };
            //int k = 2;
            //int result = jumpingOnClouds(c, k);


            //int n = 1012;
            //int result = findDigits(n);


            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < 6; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //List<int> hourglassSum = new List<int>();

            //for (int p = 0; p <= 3; p++)
            //{     
            //    for (int q = 0; q <= 3; q++)
            //    {
            //        int sumOfOneHourglass = 0;
            //        sumOfOneHourglass += (arr[p][q] + arr[p][q + 1] + arr[p][q + 2] 
            //                                        + arr[p+1][q+1]
            //                            + arr[p + 2][q] + arr[p + 2][q + 1] + arr[p + 2][q + 2]);

            //        hourglassSum.Add(sumOfOneHourglass);
            //    }
            //}

            //Console.WriteLine(hourglassSum.Max().ToString());


            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            //string binaryRep = string.Empty;

            //while (n > 0)
            //{
            //    binaryRep += Convert.ToString(n % 2);
            //    n /= 2;
            //}
            //char[] s = binaryRep.ToCharArray();

            //Array.Reverse(s);
            //binaryRep = new string(s);
            //Console.WriteLine(binaryRep);

            //List<int> ones = new List<int>();
            //int oneCounter = 0;
            //if (binaryRep.Contains("1"))
            //{
            //    int numOfOne = 0;
            //    for(int i = 0; i<binaryRep.Length; i++)
            //    {
            //        if (binaryRep[i].ToString() == "1")
            //        {
            //            numOfOne++;
            //        }
            //        else
            //        {
            //            ones.Add(numOfOne);
            //            numOfOne = 0;
            //        }
            //    }
            //    ones.Add(numOfOne);
            //}

            //else
            //{
            //    Console.WriteLine("0");
            //}

            //Console.WriteLine(ones.Max());


            //Console.WriteLine("No. of inputs: ");
            //int numOfInputs = Convert.ToInt32(Console.ReadLine());
            //List<string> strings = new List<string>();
            ////Hacker Hce akr
            //for (int p = 0; p < numOfInputs; p++)
            //{
            //    strings.Add(Convert.ToString(Console.ReadLine()));
            //}

            //foreach(string c in strings)
            //{
            //    string a0 = "";
            //    string a1 = "";

            //    for(int i = 0; i < c.Length; i++)
            //    {
            //        if (i % 2 == 0) a0 = a0 + c[i];
            //        else a1 = a1 + c[i];
            //    }
            //    Console.WriteLine(a0 + " " + a1);
            //}

            //List<int> ar = new List<int>();
            //ar.AddRange(new int[] { 4,3,5,1,2 });
            //List<int> result = permutationEquation(ar);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(n + " * "+ i + " = "+ n * i);
            //}

            //List<int> ar = new List<int>();
            //ar.AddRange(new int[] { 5, 4, 4, 2, 2, 8 });
            //int n = ar.Count;
            //List<int> result = cutTheSticks(ar);


            //double meal_cost = 12;
            //int tip_percent = 20;
            //int tax_percent = 8;
            //int result = calculateTotalBill(meal_cost, tip_percent, tax_percent);


            //int n = 5;
            //int result = utopianTree(n);


            //List<int> h = new List<int>();
            //h.AddRange(new int[] { 1,3,1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 });
            //string word = "abzcf";
            ////int s = Convert.ToInt32('b') - Convert.ToInt32('a');
            //int result = designerPdfViewer(h, word);




            //int i = 4;
            //double d = 4.0;
            //string s = "HackerRank ";


            //// Declare second integer, double, and String variables.
            //int i2 = Convert.ToInt32(Console.ReadLine());
            //double d2 = Convert.ToDouble(Console.ReadLine());
            //string s2 = Console.ReadLine();

            //Console.WriteLine(i + i2);
            //Console.WriteLine(string.Format("{0:0.0}", d + d2));
            //Console.WriteLine(s + " " + s2);

            //List<int> arr = new List<int>();
            //arr.AddRange(new int[] {1,1,2,2,4,4,5,5,5 });
            ////int output = beautifulTriplets(3, arr);
            //int output = pickingNumbers(arr);
            //int output = pageCount(5, 2);
            //Console.WriteLine(output);

            //List<int> sub_arr_div = new List<int>();
            //sub_arr_div.AddRange(new int[] { 1,3,2,6,1,2 });
            //int result = divisibleSumPairs(sub_arr_div.Count, 3, sub_arr_div);

            //List<List<int>> magic_sq = new List<List<int>>{
            //            new List<int> { 5, 3, 4 },
            //            new List<int> { 1, 5, 8 },
            //            new List<int> { 6, 4, 2 }
            //        };
            //int result = formingMagicSquare(magic_sq);
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(Convert.ToString(magic_sq[i][j]) + " ");
            //    }
            //    Console.Write("\n");
            //}
            //string s = "ababaa";
            //int p = stringSimilarity(s);

            //int[] keyboards = { 3, 1 };
            //int[] drives = { 5, 2, 8 };
            //int budget = 10;

            ////int[] keyboards = { 4 };
            ////int[] drives = { 5 };
            ////int budget = 5;

            //int result = getMoneySpent(keyboards, drives, budget);


            //int x = 1;
            //int y = 2;
            //int z = 3;
            //string result = catAndMouse(x,y,z);

            //BigInteger[] numbers = { Int64.MaxValue * BigInteger.MinusOne,
            //                   BigInteger.MinusOne,
            //                   10359321239000,
            //                   BigInteger.Pow(103988, 2),
            //                   BigInteger.Multiply(Int32.MaxValue, Int16.MaxValue),
            //                   BigInteger.Add(BigInteger.Pow(Int64.MaxValue, 2),
            //                   BigInteger.Pow(Int32.MaxValue, 2)) };
            ////long fact = extraLongFactorials(25);

            //int n = 30;
            //BigInteger fact = 1;
            //for (int i = 2; i <= n; i++)
            //{
            //    if (i == 20)
            //    {

            //    }
            //    fact = fact * i;
            //}
            //Console.Write(fact);

            //int[] unsorted = { 5, 2, 8, 7, 3, 1, 4, 1 };
            //int[] result = bubbleSort(unsorted);

            //string s = "if man was meant to stay on the ground god would have given us roots";
            //string output = encryption(s);


            //string s = "abcd";
            //string result = biggerIsGreater(s);


            //int result = saveThePrisoner(4,6,2);
            //return (start + candies - 2) % (prisoners) + 1;


            //int h = 5;
            //int m = 35;
            ////string p = NumericToWords(Convert.ToDecimal(h));
            //string result = timeInWords(h,m);


            //int i = 20;
            //int j = 23;
            //int k = 6;

            //int result = beautifulDays(i, j, k);


            //List<int> a = new List<int>();
            //a.AddRange(new int[] { 3, 4, 5, 6 });

            //List<int> queries = new List<int>();
            //queries.AddRange(new int[] { 1, 2 });

            //int k = 2;
            //List<int> result = circularArrayRotation(a, k, queries);


            //List<int> bill = new List<int>();
            //bill.AddRange(new int[] { 3,10,2,9 });
            //int k = 1;
            //int charged = 12;
            //bonAppetit(bill, k, charged);


            //Dictionary<string, string> phonebook = new Dictionary<string, string>();

            //int numOfInput = Convert.ToInt32(Console.ReadLine());
            ////phonebook.Add("mnsd", "01711");
            //for (int i = 0; i < numOfInput; i++)
            //{
            //    string [] name_number = Console.ReadLine().Split(null);
            //    //string[] details = new List<string>();
            //    //details.AddRange(name_number.Split(null));
            //    ////phonebook.Add(details[0] == null ? "" : details[0], details[1] == null ? "" : details[1]);
            //    phonebook.Add(name_number[0], name_number[1] );
            //}

            //for(int j = 0; j < numOfInput; j++)
            //{
            //    string query_name = Console.ReadLine();
            //    List<string> output = new List<string>();

            //    if (phonebook.Keys.Contains(query_name))
            //    {
            //        //output.Add(phonebook.Where(x=> x.Key == query_name).FirstOrDefault().ToString());
            //        string name = phonebook.Keys.Where(x => x == query_name).FirstOrDefault().ToString();
            //        string value = phonebook[name];
            //        output.Add(name + "=" + value);

            //    }
            //    else
            //    {
            //        output.Add("Not found");
            //    }

            //    //foreach(string c in output)
            //    //{
            //    //    Console.WriteLine(c);
            //    //}

            //    output.ForEach(item => Console.Write(item));
            //}
            //string search = "";
            //while ((search = Console.ReadLine()) != null)
            //{
            //    if (phonebook.ContainsKey(search))
            //    {
            //        Console.WriteLine($"{search}={phonebook[search]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not found");
            //    }
            //}

            ////int d1 = 2, m1 = 7, y1 = 1014;
            ////int d2 = 1, m2 = 1, y2 = 1015;
            ////int result = libraryFine( d1,  m1,  y1,  d2,  m2,  y2);
            #endregion


            //int n = 5, k = 3;
            //int result = workbook(n, k, arr);
            //int[] nums = { -1, -2, -3, -4, -5 };
            //int target = -8;
            //int[] nums = { 4, 2, 6, 1, 10 };
            //int target = -323;
            //int[] result = TwoSum(nums, target);
            //int[] result = TwoSumHash(nums, target);
            //bool result = IsPalindrome(target);

            //List<int> ranked = new List<int>();
            //ranked.AddRange(new int[] { 100, 100, 50, 40, 40, 20, 10 });

            //List<int> player = new List<int>();
            //player.AddRange(new int[] { 5, 25, 50, 120 });

            //List<int> output = climbingLeaderboardHash(ranked, player);

            //foreach (var result in output)
            //{
            //    Console.WriteLine(result);
            //}
            //int result = chocolateFeast(15, 3, 2);
            List<int> arr = new List<int>();
            arr.AddRange(new int[] { 3, 3, 2, 1, 3 });
            int result = equalizeArray(arr);
            Console.WriteLine(result);
            Console.Read();
        }

        static int equalizeArray(List<int> arr)
        {
            Dictionary<int, int> memberAmount = new Dictionary<int, int>();
            List<int> distinct = arr.Distinct().ToList();
            for(int i = 0; i< distinct.Count(); i++)
            {
                int count = arr.Count(p => p == distinct[i]);
                memberAmount.Add(distinct[i], count);
            }
            return arr.Count() - memberAmount.Values.Max();
        }
        static int chocolateFeast(int n, int c, int m)
        {
            int totalMoney = n;
            int costOfEachChocolate = c;
            int wrapperForEachChocolate = m;

            //15/3 = 5 candies; 4 wrapper given 1 wrapper left, 2 chocolates eaten 5+2 = 7; 3 wrapper, 2 given 1 gotten 7+1 = 8, 2 given 8+1 = 9

            int totalChocolatesEaten = totalMoney / costOfEachChocolate;

            int wrappersLeft = totalChocolatesEaten;

            while(wrappersLeft >= wrapperForEachChocolate)
            {
                wrappersLeft = wrappersLeft - wrapperForEachChocolate;
                totalChocolatesEaten++;
                wrappersLeft++;
            }


            //if (totalChocolatesEaten < wrapperForEachChocolate) return totalChocolatesEaten;

            return totalChocolatesEaten;
        }
        static List<int> climbingLeaderboardHash(List<int> ranked, List<int> player)
        {
            List<int> finalRank = new List<int>();
            List<int> distinctRank = ranked.Distinct().ToList();
            Dictionary<int, int> RankTable = new Dictionary<int, int>();

            int i = 1;
            foreach (var c in distinctRank)
            {
                RankTable.Add(i, c);
                i++;
            }

            foreach (var c in player)
            {
                int current_rank = RankTable.Where(x => c >= x.Value).FirstOrDefault().Key;
                if (current_rank == 0) current_rank = RankTable.Keys.Max() + 1;
                finalRank.Add(current_rank);
                continue;
            }

            return finalRank;
        }
        static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {

            List<int> finalRank = new List<int>();
            List<int> distinctRank = ranked.Distinct().ToList();
            foreach (int score in player)
            {
                int rank = 1;
                for (int i = 0; i < distinctRank.Count; i++)
                {
                    if (score < distinctRank[i]) rank++;
                }
                finalRank.Add(rank);
            }

            return finalRank;
        }

        static public bool IsPalindrome(int x)
        {
            string numberAsString = Convert.ToString(x);
            string opposite = String.Concat(numberAsString.ToCharArray().Reverse());
            if (numberAsString == opposite) return true;
            else return false;
        }
        public static int[] TwoSumHash(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i = 0; i< nums.Count(); i++)
            {
                int num1 = nums[i];
                int num2 = target - num1;
                if (map.ContainsValue(num2))
                {
                    return new int[] { map.FirstOrDefault(x=> x.Value == num2).Key, i };
                }
                map.Add(i, nums[i]);
            }

            return null;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indices = new int[2];

            for(int i = 0; i< nums.Count(); i++)
            {
                //if (nums[i] > target) continue;
                indices[0] = i;
                for (int j = 0; j < nums.Count(); j++)
                {
                    if (j == i) continue;
                    if (nums[i] + nums[j] == target)
                    {
                        indices[1] = j;
                        return indices;
                    }
                }
                Array.Clear(indices, 0, indices.Length);
            }
            return indices;
        }

        public static int workbook(int n, int k, List<int> arr)
        {
            int totalPagesInWorkbook = 0;
            int problemPerPage = k;
            int numOfSpecialProblem = 0;

            //maybe unnecessary
            foreach (int c in arr)
            {
                totalPagesInWorkbook += Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(c) / Convert.ToDecimal(k)));
            }

            int currentPageNum = 0;

            for (int i = 0; i < n; i++)
            {
                currentPageNum++;
                int pageReqForCurrentChapter = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(arr[i]) / Convert.ToDecimal(k)));
                for (int currentProblemNumber = 1; currentProblemNumber <= arr[i]; currentProblemNumber++)
                {
                    if (currentPageNum == currentProblemNumber) numOfSpecialProblem++;
                    if (currentProblemNumber % k == 0 && currentProblemNumber != arr[i]) currentPageNum++;
                }
            }
            return numOfSpecialProblem;
        }

        //static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        //{
        //    //1 : returned date
        //    //2: due date

        //    if (y1 < y2) return 0;
        //    if (y1 == y2)
        //    {
        //        if (m1 < m2) return 0;
        //        if(m1 == m2)
        //        {
        //            if (d1 <= d2) return 0;
        //        }
        //    }

        //    if (y1 > y2)
        //    {
        //        return 10000;
        //    }
        //    else if (m1 > m2)
        //    {
        //        return (m1 - m2) * 500;
        //    }

        //    else return (d1 - d2) * 15;
        //}
        static int jumpingOnClouds(int[] c, int k)
        {
            //0->2 energy 100-1-2 = 97
            //2->4 energy 97 - 2 = 96
            //4->6 energy 96-1-2 = 93
            //6->1 energy 93 -1 = 92

            return 0;
        }
        static int findDigits(int n)
        {

            char[] s = n.ToString().ToCharArray();
            List<int> divisors = new List<int>();
            foreach (char c in s)
            {
                if (Convert.ToInt32(c.ToString()) != 0) divisors.Add(Convert.ToInt32(c.ToString()));
            }

            int totalDivisor = 0;

            foreach (int i in divisors)
            {
                if (n % i == 0) totalDivisor++;
            }

            return totalDivisor;
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            int charged = b;
            int notEatenItem = k;
            int totalBill = bill.Sum();

            //3+10+2+9 / 2 = 24  charged 12   not eaten bill[1] = 10  so, charge should be 3 + 2 + 9 / 2 = 7

            int actualBill = (totalBill - bill[k]) / 2;

            if (actualBill == charged) Console.WriteLine("Bon Appetit");

            else Console.WriteLine(charged - actualBill);

        }
        static List<int> permutationEquation(List<int> p)
        {
            //4,3,5,1,2  output should be 1,3,5,4,2
            //4,3,5,1,2  then we get  p[4] p[5] p[2] p[1] p[3]
            int from = p.Min();
            int to = p.Max();
            List<int> firstList = new List<int>();
            List<int> finalList = new List<int>();
            for (int i = from; i <= to; i++)
            {
                int q = p.Where(x => p[x - 1] == i).FirstOrDefault();
                firstList.Add(q);
            }

            foreach (int c in firstList)
            {
                int finalVal = p.Where(x => p[x - 1] == c).FirstOrDefault();
                finalList.Add(finalVal);
            }

            //p of what equals 4?

            return finalList;
        }
        static List<int> cutTheSticks(List<int> arr)
        {
            //5,4,4,2,2,8  6  3,2,2,6  4  1,4,  2  4  1  => ,6,4,2,1
            List<int> stick_numbers = new List<int>();
            int shortest_stick = new int();
            int cut_number = new int();//increases if we cut a stick
            for (int i = 0; i < arr.Count; i++)
            {
                if (i == 0)
                {
                    shortest_stick = arr.Min();
                    cut_number = 0;
                }

                arr[i] = arr[i] - shortest_stick;
                cut_number++;
                if (i == arr.Count - 1 && arr.Count > 0)
                {
                    stick_numbers.Add(cut_number);
                    i = -1;
                    arr = arr.Where(t => t != 0).ToList();
                }
            }
            return stick_numbers;
        }
        static int sockMerchant(int n, List<int> ar)
        {
            List<int> numOfDistinctColors = ar.Distinct().ToList();
            int numOfCompletePairs = 0;

            foreach (int color in numOfDistinctColors)
            {
                int count = ar.Where(x => x == color).Count();
                numOfCompletePairs += count / 2;
            }

            return numOfCompletePairs;
        }
        static int calculateTotalBill(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip_amount = Convert.ToDouble(meal_cost) * (Convert.ToDouble(tip_percent) / 100);
            double tax_amount = Convert.ToDouble(meal_cost) * (Convert.ToDouble(tax_percent) / 100);
            double finalBill = Convert.ToDouble(meal_cost) + tip_amount + tax_amount;

            return Convert.ToInt32(Math.Round(finalBill));
        }
        static int utopianTree(int n)
        {
            int Growth = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    //increases 1
                    Growth++;
                }

                else
                {
                    //doubles
                    Growth *= 2;
                }
            }

            return Growth;
        }
        static int designerPdfViewer(List<int> h, string word)
        {
            List<int> Lengths = new List<int>();
            int startIndex = Convert.ToInt32('a');
            foreach (char c in word)
            {
                int length = h[Convert.ToInt32(c) - startIndex];
                Lengths.Add(length);
            }
            return Lengths.Max() * word.Length;
        }
        static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            List<int> initialList = a;
            List<int> mainList = a;
            int numOfRotation = k;
            // 3,4,5,6   6,3,4,5   5,6,3,4

            //List<int> tempList = new List<int>();
            //List<int> finalList = new List<int>();

            for (int i = 0; i < numOfRotation; i++)
            {
                //finalList.Clear();
                //tempList.Clear();
                List<int> finalList = new List<int>();
                List<int> tempList = new List<int>();
                tempList = mainList.Take(mainList.Count - 1).ToList();
                finalList.Add(mainList[mainList.Count - 1]);
                finalList.AddRange(tempList);
                mainList = finalList;

            }

            List<int> ansList = new List<int>();
            foreach (int p in queries)
            {
                ansList.Add(mainList[p]);
            }
            return ansList;
        }
        static int beautifulDays(int i, int j, int k)
        {
            int startDay = i;
            int endDay = j;
            int divisor = k;
            List<int> beautifulDays = new List<int>();

            for (int p = startDay; p <= endDay; p++)
            {
                int mainDay = p;

                char[] myArr = Convert.ToString(mainDay).ToCharArray();
                Array.Reverse(myArr);
                string reverseMainDayString = new string(myArr);
                int reverseMainDayInt = Convert.ToInt32(reverseMainDayString);

                if (Math.Abs(mainDay - reverseMainDayInt) % divisor == 0) beautifulDays.Add(p);
            }

            return beautifulDays.Count;
        }
        static string timeInWords(int h, int m)
        {
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };

            string outputTime = "";

            if (m == 0) { outputTime = ones[h] + " o' clock"; }
            else if (m == 15) { outputTime = "quarter past " + ones[h]; }
            else if (m == 30) { outputTime = "half past " + ones[h]; }
            else if (m == 45) { outputTime = "quarter to " + ones[h + 1]; }

            else
            {
                if (m > 30)
                {
                    int m2 = 60 - m;
                    int remainder2 = m2 % 10;
                    int quotient2 = Convert.ToInt32(Math.Floor(Convert.ToDecimal(m2) / 10));

                    if (m2 > 20 && m2 < 30)
                    {
                        outputTime = ones[m2 - remainder2] + " " + ones[remainder2] + " minutes to " + ones[h + 1];
                    }
                    else outputTime = ones[m2] + " minutes to " + ones[h + 1];
                }
                else
                {
                    int remainder = m % 10;
                    int quotient = Convert.ToInt32(Math.Floor(Convert.ToDecimal(m) / 10));

                    if (m <= 20)
                    {
                        if (m == 1) { outputTime = "one minute past " + ones[h]; }
                        else outputTime = ones[m] + " minutes past " + ones[h];
                    }
                    if (m > 20 && m < 30)
                    {
                        outputTime = ones[m - remainder] + " " + ones[remainder] + " minutes past " + ones[h];
                    }
                }

            }
            return outputTime;
        }
        static int saveThePrisoner(int n, int m, int s)
        {
            int numOfPrisoners = n;
            int numOfCandy = m;
            int startPosOfChair = s;

            return ((startPosOfChair + numOfCandy - 2) % numOfPrisoners) + 1;

            //int[] chairs = new int[numOfCandy];
            //int j = startPosOfChair;

            //for (int i = 0; i < numOfCandy; i++)
            //{
            //    chairs[i] = j;
            //    j++;
            //    if (j > numOfPrisoners) j = 1;
            //}
            //int lastPerson = chairs[numOfCandy - 1];
            //return lastPerson;
        }
        static string biggerIsGreater(string w)
        {
            int i = w[0];

            return w;
        }
        static string encryption(string s)
        {
            s = s.Replace(" ", "");
            int lengthWithoutSpace = s.Length;
            int low = Convert.ToInt32(Math.Floor(Math.Sqrt(lengthWithoutSpace)));
            int high = Convert.ToInt32(Math.Ceiling(Math.Sqrt(lengthWithoutSpace)));

            string word = "";
            for (int i = 0; i < high; i++)
            {
                int j = i;
                while (j < lengthWithoutSpace)
                {
                    word = word + s[j];
                    j += high;
                }
                word += " ";
            }

            return word;
        }
        //not entirely bubblesort; a bit modified
        static int[] bubbleSort(int[] unsortedList)
        {
            int temp = 0;

            for (int i = 1; i < unsortedList.Count(); i++)
            {
                if (unsortedList[i - 1] > unsortedList[i])
                {
                    temp = unsortedList[i - 1];
                    unsortedList[i - 1] = unsortedList[i];
                    unsortedList[i] = temp;
                    i = 0;
                }
            }

            //int i = 1;
            //while (i < unsortedList.Count())
            //{
            //    if (unsortedList[i - 1] > unsortedList[i])
            //    {
            //        temp = unsortedList[i - 1];
            //        unsortedList[i - 1] = unsortedList[i];
            //        unsortedList[i] = temp;
            //        i = 1;
            //    }
            //    else i++;
            //}

            return unsortedList;
        }
        static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(x - z) < Math.Abs(y - z)) return "Cat A";
            else if (Math.Abs(y - z) < Math.Abs(x - z)) return "Cat B";
            else return "Mouse C";
        }
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            List<int> withinBudget = new List<int>();

            foreach (int kb in keyboards)
                foreach (int dr in drives)
                    if (kb + dr <= b) withinBudget.Add(kb + dr);

            if (withinBudget.Count == 0) return -1;
            else return withinBudget.Max();
        }
        public static int stringSimilarity(string s)
        {
            List<string> subs = new List<string>();
            List<int> scores = new List<int>();

            for (int i = 0; i < s.Length; i++)
                subs.Add(s.Substring(i));

            string main_word = subs[0];
            scores.Add(main_word.Length);

            for (int j = 1; j < subs.Count; j++)
            {
                int score = 0;

                for (int k = 0; k < subs[j].Length; k++)
                {
                    if (main_word[k] == subs[j][k]) score++;
                    else break;
                }
                scores.Add(score);
            }

            return scores.Sum();
        }        
        static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int numOfPair = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                if (i != ar.Count - 1)
                {
                    for (int j = i + 1; j < ar.Count; j++)
                    {
                        //if (ar[i] > ar[j]) continue;
                        if ((ar[i] + ar[j]) % k == 0) numOfPair++;
                    }
                }
            }
            return numOfPair;
        }
        static string angryProfessor(int k, List<int> a)
        {
            int total = 0;
            foreach (int time in a)
            {
                if (time >= 0)
                {
                    total++;
                }
            }

            if (total > k) return "true";
            else return "false";
        }
        static int beautifulTriplets(int d, List<int> arr)
        {
            int total = 0;

            List<int> triplets = new List<int>();

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] - arr[j] == d)
                    {
                        triplets.Add(arr[i]);
                        triplets.Add(arr[j]);

                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (arr[j] - arr[k] == d)
                            {
                                triplets.Add(arr[k]);
                                total++;
                                //break;
                            }
                        }
                        //break;
                    }
                }
            }
            return total;
        }
        static int pickingNumbers(List<int> a)
        {
            List<int> subarrayMember = new List<int>();
            List<int> total = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                subarrayMember.Add(a[i]);
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1)
                    {
                        subarrayMember.Add(a[j]);
                    }
                }

                for (int p = 0; p < subarrayMember.Count; p++)
                {
                    for (int q = p + 1; q < subarrayMember.Count; q++)
                    {
                        if (Math.Abs(subarrayMember[p] - subarrayMember[q]) > 1)
                        {
                            if (subarrayMember[p] > subarrayMember[q])
                                subarrayMember.Remove(subarrayMember[p]);
                            else subarrayMember.Remove(subarrayMember[q]);
                        }
                    }
                }
                total.Add(subarrayMember.Count);
                subarrayMember.Clear();
            }

            return total.Max();

        }
        static int pageCount(int n, int p)
        {
            //n = total page;  p = desired page
            int fromFirstPage = 0;
            int fromLastPage = 0;

            decimal firstPageFlip = (decimal)p / 2;
            decimal lastPageFlip = ((decimal)n - (decimal)p) / 2;

            fromFirstPage = Convert.ToInt32(Math.Floor(firstPageFlip));

            if (p % 2 == 0) fromLastPage = Convert.ToInt32(Math.Floor(lastPageFlip));
            else fromLastPage = Convert.ToInt32(Math.Ceiling(lastPageFlip));

            if (fromFirstPage < fromLastPage) return fromFirstPage;

            else return fromLastPage;
        }
    }
}