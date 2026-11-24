using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovichID.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool rightArea = (x >= 0) && (y >= 0) && (y <= x * x) && (y <= 2 - x);
            bool leftArea = (x < 0) && (y >= x * x) && (y <= 2 - x);


            return rightArea || leftArea;
        }
    }
}
