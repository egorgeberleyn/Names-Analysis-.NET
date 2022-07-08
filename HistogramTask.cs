using System;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            Console.WriteLine("Статистика рождаемости по дням");
            var minDay = 1;                     
            var days = new string[31];
            for (var y = 0; y < days.Length; y++)
                days[y] = (y + minDay).ToString();
            var birthsCounts = new double[31];
            foreach (var a in names)
            {                
                if (a.Name == name && a.BirthDate.Day != 1)
                    birthsCounts[a.BirthDate.Day - minDay]++;
            }

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                days, birthsCounts);
        }
    }
}