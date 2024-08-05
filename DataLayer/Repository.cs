namespace DataLayer
{
    public class Repository : IData
    {
        public int sum(int i, int j)
        {
            int a = i;
            int b = j;
            int sum = a + b;
            return sum;
        }
    }
}
