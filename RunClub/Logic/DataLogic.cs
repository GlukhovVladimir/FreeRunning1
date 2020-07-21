using RunClub.Storage;
using System;
using System.Linq;

namespace RunClub.Logic
{
    public class DataLogic
    {
        private readonly DataSingleton source;

        public DataLogic()
        {
            source = DataSingleton.GetInstance();
        }

        public void AddRunData(DateTime date, double distance)
        {
            if (source.RunData.ContainsKey(date))
            {
                throw new Exception("Уже есть значение для этой даты");
            }
            source.RunData.Add(date, distance);
        }

        public double GetTotalDistance()
        {
            if (source.RunData.Count == 0)
            {
                throw new Exception("Нет элементов в списке");
            }
            return source.RunData.Sum(rec => rec.Value);
        }

        public double GetMin()
        {
            if (source.RunData.Count == 0)
            {
                throw new Exception("Нет элементов в списке");
            }
            return source.RunData.Min(rec => rec.Value);
        }

        public double GetMax()
        {
            if (source.RunData.Count == 0)
            {
                throw new Exception("Нет элементов в списке");
            }
            return source.RunData.Max(rec => rec.Value);
        }

        public double GetAverage()
        {
            if (source.RunData.Count == 0)
            {
                throw new Exception("Нет элементов в списке");
            }
            return source.RunData.Average(rec => rec.Value);
        }
    }
}
