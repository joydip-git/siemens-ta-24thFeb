using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Applicant applicant = null;

            try
            {
                applicant = new Applicant { Name = "anil", Age = 14 };
            }
            catch(AgeBelowEligibiltyLevelException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
