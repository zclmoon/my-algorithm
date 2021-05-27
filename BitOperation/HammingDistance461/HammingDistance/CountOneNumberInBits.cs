namespace HammingDistance
{
    public class CountOneNumberInBits
    {
        public int CountOneInBitsSet(int x)
        {
            int count = 0;

            while (x > 0)
            {
                count++;

                x &= (x - 1); 
            }

            return count;
        }
    }
}