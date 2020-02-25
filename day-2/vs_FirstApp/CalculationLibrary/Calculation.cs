namespace CalculationLibrary
{
    /// <summary>
    /// class containing methods for addition, subtraction, multiplication and division of two integer numbers
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// method to add two integer numbers
        /// </summary>
        /// <param name="firstValue">first number</param>
        /// <param name="secondValue">second number</param>
        /// <returns>returns the addition result (an integer value)</returns>
        public static int Add(int firstValue, int secondValue)
        {
            return (firstValue + secondValue);
        }

        /// <summary>
        /// method to subtract two integer numbers
        /// </summary>
        /// <param name="firstValue">first number</param>
        /// <param name="secondValue">second number</param>
        /// <returns>returns the subtraction result (an integer value)</returns>
        public static int Subtract(int firstValue, int secondValue)
        {
            return (firstValue - secondValue);
        }

        /// <summary>
        /// method to multiply two integer numbers
        /// </summary>
        /// <param name="firstValue">first number</param>
        /// <param name="secondValue">second number</param>
        /// <returns>returns the multiplication result (an integer value)</returns>
        public static int Multiply(int firstValue, int secondValue)
        {
            return (firstValue * secondValue);
        }

        /// <summary>
        /// method to divide two integer numbers
        /// </summary>
        /// <param name="firstValue">first number</param>
        /// <param name="secondValue">second number</param>
        /// <returns>returns the division result (an integer value)</returns>
        public static int Divide(int firstValue, int secondValue)
        {
            return (firstValue / secondValue);
        }
    }
}
