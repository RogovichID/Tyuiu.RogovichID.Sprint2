using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovichID.Sprint2.Task6.V1.Lib
{
    public class DataService
    {
        public int FindMonthDaysCount(int value)
        {
            int res = value switch
            {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31
            };
            return res;
        }
    }
}
