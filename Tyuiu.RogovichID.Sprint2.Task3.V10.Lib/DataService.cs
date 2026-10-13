using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovichID.Sprint2.Task3.V10.Lib
{
    public class DataService : ISprint2Task3V10
    {
        public double Calculate(double x)
        {
            DataService ds = new DataService();
            double res;
            if (x > 0)
            {
                res = x - Math.Pow(((x + 15) / (x - 4)), x);
            }
            else
            {
                if (x == 0)
                {
                    res = (Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 2);
                }
                else
                {
                    if (x < -14)
                    {
                        res = x + 10 * x - 1 / x;
                    }
                    else
                    {
                        res = Math.Pow((5 + 1 / Math.Pow(x, 2)), x);
                    }
                }
                
            }
            
            return Math.Round(res,3);
        }
    }
}
