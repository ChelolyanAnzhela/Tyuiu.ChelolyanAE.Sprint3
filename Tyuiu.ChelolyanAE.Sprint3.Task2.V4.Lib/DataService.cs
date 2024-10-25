using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChelolyanAE.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            do
            {
                multSeries = multSeries * Math.Pow((1/(Math.Pow(Math.Sin(1),7))/startValue),2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multSeries, 3);

        }
    }
}
