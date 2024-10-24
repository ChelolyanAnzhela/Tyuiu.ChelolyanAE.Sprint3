using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChelolyanAE.Sprint3.Task0.V17.Lib
{
    public class DataService : ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = 1; i <= 10; i++)
            {
                sumSeries = sumSeries + Math.Cos(i) * 1 / 2;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
