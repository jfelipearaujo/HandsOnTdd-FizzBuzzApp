using System.Text;

namespace HandsOnTdd_FizzBuzzApp
{
    public class FizzBuzz
    {
        public bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        public bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        public bool IsFizzBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }

        public string PrintFizzBuzz()
        {
            const int min = 1;
            const int max = 100;

            var result = new StringBuilder();

            for (int i = min; i <= max; i++)
            {
                if (IsFizzBuzz(i))
                {
                    result.Append("FizzBuzz").Append(" ");
                }
                else if (IsBuzz(i))
                {
                    result.Append("Buzz").Append(" ");
                }
                else if (IsFizz(i))
                {
                    result.Append("Fizz").Append(" ");
                }
                else
                {
                    result.Append(i).Append(" ");
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
