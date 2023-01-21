using System;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1

            //- Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)

            //string str = "Hello World";
            //Console.WriteLine(FindFirstWord(str));
            #endregion

            #region task2

            // - Verilmiş string dəyərindəki sözlərin sayını tapan metod (boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın)

            //string str = "Hello World";
            //Console.WriteLine(FindCountOfWords(str));

            #endregion

            #region task3

            // - Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod.
            // Misalçün verilmiş arraydə {4, -3, 10, -24}  dəyərləridirsə methoddan geriyə {4, 10} dəyərli array qayıdır.

            //int[] array = { 4, -3, 10, -24 };

            //PositiveElements(array);
            #endregion

            #region task4

            //- Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod

            //string[] strWords = { "hello", "world", "1234" };
            //Console.WriteLine(FindDigits(strWords));
            #endregion

            #region task5

            //- Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod. Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.

            //string word = " Salam";
            //Console.WriteLine(FindWantedIndex(word));

            #endregion

            #region task6

            //- Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod

            //string word = "    Salam";
            //Console.WriteLine(DeleteSpace(word));

            #endregion

            #region - Dərsdə etdiklərimiz

            //Layihe ise dusdukdue console-dan email deyeri daxil etmeyimizi istesin
            //Eger email @ simvolu yoxdursa yeniden daxil etmeyimizi istesin

            //string email = "";
            //bool hasWantedChar = false;

            //do
            //{
            //    Console.Write("Enter E-mail: ");
            //    email = Console.ReadLine();

            //    for (int i = 0; i < email.Length; i++)
            //    {
            //        if (email[i] == '@')
            //        {
            //            hasWantedChar = true;
            //            break;
            //        }
            //    }
            //} while (hasWantedChar == false);


            //string email = "";

            //do
            //{
            //    Console.Write("Enter e-mail: ");
            //    email = Console.ReadLine();

            //} while (FindIndex(email,'@') == -1);

            //Verilmis adlar siyahisinda verilmis adin olub olmadigini tapan metod

            //string[] names = { "salvi", "nazila", "nigar", "gular", "aydan" };
            //string name = "salvi";

            //Console.WriteLine(HasWantedElement(names,name));

            //Verilmis ededler siyahisinda verilmis ededin oldub olmadigini tapan metod

            //int[] numbers = { 1, 2, 3, 4 };
            //int number = 4;

            //Console.WriteLine(HasWantedNumber(numbers,number));  

            //Verilmis ededler siyahisinda verilmis diger ededler siyahisindan hansisa
            //ededin olub olmadigini tapan metod

            //int[] numbers1 = { 1, 2, 3, 4 };
            //int[] numbers2 = { 5, 6, 7 };

            //Console.WriteLine(HasWantedNumber(numbers1,numbers2));

            //Verilmis charin reqem olub olmadigini tapan bir metod

            //char cr = '4';
            //Console.WriteLine(IsDigit(cr));

            //Verilmis yazida reqem olub olmadigini tapan bir metod

            //string str = "Hello 123";
            //Console.WriteLine(HasDigit(str));

            //Verilmis yazinin icerisinde verilmis charin indexini tapan metod

            //string word = "salvi";
            //char letter = 'l';

            //Console.WriteLine(FindIndex(word,letter));

            //Verimis yazini verilmis indexe qeder kesib qaytaran metod

            //string word = "hello world";
            //int index = 4;

            //Console.WriteLine(Substring(word,index));

            //18.01
            //-Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod
            //- Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod


            //int[] numbers = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(MinNumber(numbers));

            //string word = "hello world";
            //char letter = 'l';

            //Console.WriteLine(CountWantedChar(word,letter));


            #endregion

        }
        static string FindFirstWord(string str)
        {
            string strNew = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    strNew += str[i];
                else
                    break;
            }
            return strNew;
        }

        static int FindCountOfWords(string str)
        {
            int count = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    count++;
            }

            return count;
        }

        static void PositiveElements(int[] arr)
        {
            int size = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    size++;
                }
            }
            int[] newArr = new int[size];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }

        static bool IsDigit(char cr)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == cr)
                    return true;
            }

            return false;
        }

        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (IsDigit(str[i]))
                    return true;
            }
            return false;
        }

        static int FindDigits(string[] str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (HasDigit(str[i]))
                    count++;
            }
            return count;
        }

        static int FindWantedIndex(string str)
        {
            int wantedIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    wantedIndex = i;
                    break;
                }
            }
            return wantedIndex;
        }

        static string DeleteSpace(string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    newStr += str[i];
                }
            }

            return newStr;
        }


        // - Dərsdə etdiklərimiz

        static int FindIndex(string str, char cr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                    return i;
            }
            return -1;
        }

        static bool HasWantedElement(string[] str1, string str2)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == str2)
                {
                    return true;
                }
            }
            return false;
        }

        static bool HasWantedNumber(int[] nums, int num)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        static bool HasWantedNumber(int[] nums1, int[] nums2)
        {
            for (int i = 0; i < nums2.Length; i++)
            {
                if (HasWantedNumber(nums1, nums2[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static string Substring(string str, int index)
        {
            string newStr = "";

            for (int i = 0; i < index; i++)
            {
                newStr += str[i];
            }
            return newStr;
        }

        static int MinNumber(int[] num)
        {
            int min = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }

            return min;

        }

        static int CountWantedChar(string str, char cr)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
