using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var minMonth = 1;
            var minDay = 2;           
            
            var days = new string[30];
            for (var x = 0; x < days.Length; x++)          
                days[x] = (x + minDay).ToString();
                 
 
            var months = new string[12];
            for (var y = 0; y < months.Length; y++)
                months[y] = (y + minMonth).ToString();

            var heat = new double[30, 12];           
                
            foreach (var name in names)
                if (name.BirthDate.Day != 1)
                    heat[name.BirthDate.Day - minDay, name.BirthDate.Month - minMonth]++;

            return new HeatmapData("Карта интенсивности", heat, days, months);
        }
    }
}