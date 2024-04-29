namespace CalculationLibrary
{
    public class Calculation
    {
        public List<MyApplication> Applications { get; set; }
        public double AverageTime { get; set; }

        public Calculation(List<MyApplication> applications)
        {
            Applications = applications;
            AverageTime = 0;
        }

        public int GetAverageTime()
        {
            if (Applications.Count == 0) return 0;
            TimeSpan sum = new TimeSpan();
            int count = 0;
            foreach (var app in Applications)
            {
                if (app.Status == "Выполнено")
                {
                    sum += app.DateEnd.Subtract(app.DateStart);
                    count++;
                }
            }
            if (count == 0) return 0;
            AverageTime = sum.TotalDays / count;
            return Convert.ToInt32(Math.Floor(AverageTime));
        }

        public int GetApplicationsCount()
        {
            return Applications.Count;
        }

        public string GetDefectsStatistics()
        {
            if (Applications.Count == 0) return null;
            string result = "", cur;
            int i, maxI = 0;
            foreach (var app in Applications)
            {
                i = 0;
                foreach (var app2 in Applications)
                {
                    if (app2.Defect == app.Defect) i++;
                }
                if (i > maxI)
                {
                    maxI = i;
                    result = app.Defect;
                }
            }
            return result;
        }
    }
}