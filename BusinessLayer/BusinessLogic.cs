using DataLayer;

namespace BusinessLayer
{
    public class BusinessLogic : IBusinessClass
    {
        readonly IData data1;

        public BusinessLogic(IData data)
        {
            data1 = data;
        }

        public int sumoftwo(int i, int j)
        {
            var data = data1.sum(i, j);
            return data;
        }

    }
}
