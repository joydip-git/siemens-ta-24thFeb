using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static DivideMethodException ConvertToCustomException(Exception ex,
            string message = null)
        {
            DivideMethodException divEx = null;

            if (message != null)
                divEx = new DivideMethodException(message, ex);
            else
                divEx = new DivideMethodException(ex.Message, ex);

            return divEx;
        }
        static int Divide()
        {
            //int x = 10;
            //int y = 0;
            //int res = 0;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(@"data.txt");
                writer.WriteLine("hello");
                return 1;
                //res = x / y;
                //return res;
            }
            catch (DivideByZeroException ex)
            {
                DivideMethodException divEx = ConvertToCustomException(ex, "Denominantor should not be zero...");
                throw divEx;
            }
            catch (IndexOutOfRangeException ex)
            {
                DivideMethodException divEx = ConvertToCustomException(ex);
                throw ex;
            }
            catch (Exception ex)
            {
                DivideMethodException divEx = ConvertToCustomException(ex);
                throw ex;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Flush();
                    writer.Close();
                }
            }
        }
        static void Main()
        {

            //stops execution
            //gather information about what went wrong
            //runtime creates object of Exception class
            //and assigns values, such as error message, name of the app where error happened, name of the method where error happened etc.
            int res = 0;
            try
            {
                res = Divide();
            }
            catch (DivideMethodException ex)
            {
                Console.WriteLine(ex.Message != null ? ex.Message : "NA");
                Console.WriteLine(ex.ActualException.Message);
            }
            catch (Exception ex)// ex = new DivideByZeroException();
            {
                Display(ex);
            }
            Console.WriteLine(res);
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length + 1; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

        }

        private static void OtherMethod()
        {
            throw new NotImplementedException();
        }

        private static void Display(Exception ex)
        {
            Console.WriteLine($"Message:{ex.Message}");
            Console.WriteLine($"Method:{ex.TargetSite}");
            Console.WriteLine($"Applicaton:{ex.Source}");
            Console.WriteLine($"Details:{ex.StackTrace}");
        }
    }
}
