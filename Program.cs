using Helper;

namespace ConsoleApp1
{
    #region Namespace
    // What U Can Write Inside Namespace ?
    // 1) Class , 2) Struct , 3) Enum , 4) Interface
    // Access Modifiers Allowed Inside Namespace => public , internal
    // Default Access Modifiers Inside Namespace -> internal

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region UDF - Passing By Value - Value Types

            //int Pages = 500;
            //Console.WriteLine(Pages); // 500
            //AddPages(Pages);
            //Console.WriteLine(Pages); // 500

            #endregion

            #region UDF - Passing By Value - Reference Types

            //int[] Prices = { 50, 60, 70 };
            ////Console.WriteLine(Prices[0]); // 50
            //ApplyDiscount(Prices);
            ////Console.WriteLine(Prices[0]); // 40
            //for(int i=0;  i < Prices.Length; i++)
            //    Console.WriteLine(Prices[i]);


            #endregion

            #region UDF - Passing By Ref - Value Types

            //int pages = 500;
            //Console.WriteLine(pages);
            //AddPages(ref pages);
            //Console.WriteLine(pages);

            #endregion

            #region UDF - Passing By Ref - Reference Types

            //int[] Prices = { 50, 60, 70 };
            ////Console.WriteLine(Prices[0]); // 50
            //ApplyDiscount(ref Prices);
            ////Console.WriteLine(Prices[0]); // 40
            //for (int i = 0; i < Prices.Length; i++)
            //    Console.WriteLine(Prices[i]);


            #endregion

            #region UDF - Passing By Out

            //GetPrice("C#", out int BookPrice);
            //Console.WriteLine(BookPrice);

            //int.TryParse(Console.ReadLine(), out int age);  

            #endregion

            #region Class Library

            //int num = 10;
            //NumberHelper.IsEven(num);

            #endregion

            #region Access Modifiers

            //AccessModifiers AM = new AccessModifiers();

            //AM.Age = 10; // Private
            //AM.Name = "";
            //AM.Salary = 10;

            #endregion

            #region User Defined Datatypes



            #endregion

        }

        #region Function Parameters

        #region UDF - Passing By Value - Value Types

        public static void AddPages(int pages)
        {
            pages += 50;
        }

        #endregion

        #region UDF - Passing By Value - Reference Types

        public static void ApplyDiscount(int[] prices)
        {
            prices[0] -= 10;
        }



        #endregion

        #region UDF - Passing By Ref - Value Types

        public static void AddPages(ref int pages)
        {
            pages += 50;
        }


        #endregion

        #region UDF - Passing By Ref - Reference Types

        public static void ApplyDiscount(ref int[] prices)
        {
            prices[0] -= 10;
        }

        #endregion

        #region UDF - Passing By Out

        public static bool GetPrice(string title , out int price )
        {
            if (title == "C#")
            {
                price = 500;
                return true;
            }

            price = 0;
            return false;
        }

        #endregion

        #endregion

        public static int Divide(int a , int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}
