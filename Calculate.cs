namespace Calculator_example
{
    public class Calculate : ICalculate
    {
        public int sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public int minus(int number1, int number2)
        {
            return number1 - number2;
        }
        public int multiple(int number1, int number2)
        {
            return number1 * number2;
        }
        public int divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}