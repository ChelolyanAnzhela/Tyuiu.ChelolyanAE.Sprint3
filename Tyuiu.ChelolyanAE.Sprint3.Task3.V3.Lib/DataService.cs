using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChelolyanAE.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int minCount = int.MaxValue;
            int count = 0;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    { 
                        minCount = Math.Min(minCount, count);
                        count = 0;
                    }
                }
            }
            if (count > 0)
            {
                minCount = Math.Min(minCount, count);
            }
            return (minCount == int.MaxValue) ? 0 : minCount; ;
        }
    }
}
