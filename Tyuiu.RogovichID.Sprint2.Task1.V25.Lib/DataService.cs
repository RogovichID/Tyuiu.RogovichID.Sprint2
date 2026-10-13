using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovichID.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];

            res[0] = ((c - 170) == b) | (a != c);
            res[1] = (a < b) & (b > c);
            res[2] = (a >= b) || (b == c);
            res[3] = (d == c) && (a != b);
            res[4] = !(d == b);
            res[5] = (a != c) ^ (c < d);

            return res;
        }
    }
}
