//1.Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır.

//namespace ThwLowestNum
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 4, 5, 6, 3, 1, 7, 8, };
//            Console.WriteLine(Min(arr));

//        }

//        static int Min(int[] Array)
//        {
//            int Lowest = Array[0];
//            for (int i = 0; i < Array.Length; i++)
//            {
//                if (Lowest > Array[i])
//                {
//                    Lowest = Array[i];
//                }
//            }
//            return Lowest;
//        }
//    }
//}


/////////////////////////////////////////////////////////////////////////////


//2.İstənilən verilən cümlədə sözlərin baş hərflərini ekrana yazdıran method yazın  məs .("Hello World --> "H" "W" )


namespace ThwLowestNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is xendam.";
            Console.WriteLine(GetInitialLetters(sentence));

        }

        static string GetInitialLetters(string sentence)
        {
            char[] initials =new char[sentence.Length];
            int index = 0;
            bool NewWord = true;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    NewWord = true;
                }
                else if(NewWord)
                {
                    initials[index] = sentence[i];
                    index++;
                    NewWord = false;
                }
            }

            string result = "";
            for(int i = 0;i < index;i++) {
                result += initials[i];
                if (i<index-1) {
                    result += ' ';
                }
            }
            return result;
        }


    }

}


//////////////////////////////////////////////////////////////////////////////////////////////////



//3.Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
//Misal olaraq, name = " Yusif    Osmanov   " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "YusifOsmanov" olmalıdır.




//namespace ThwLowestNum
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string name = "Tusif Osmanov";
//            Console.WriteLine(RemoveSpaces(name));

//        }

//        static string RemoveSpaces(string input)
//        {
//            string result = "";

//            for (int i = 0; i < input.Length; i++)
//            {
//                if (input[i] != ' ') 
//                {
//                    result += input[i];
//                }


//            }
//            return result;


//        }

//    }

//}
