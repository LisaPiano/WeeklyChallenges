namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05Base
    {


        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])

                {
                    return false;
                }
            }
            return true;
        }
    }
}