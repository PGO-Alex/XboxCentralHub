using System;

namespace Models.Class
{
    public class Rent
    {
        private int id;
        private int consolaId;
        private double timeStart;
        private double timeFinish;
        private double timeWorked;
        private int costPH;

        public int CostPH { get => costPH; set => costPH = value; }
        public int Id { get => id; set => id = value; } 
        public int ConsolaId { get => consolaId; set => consolaId = value; }
        public double TimeStart { get => timeStart; set => timeStart = value; }
        public double TimeFinish { get => timeFinish; set => timeFinish = value; }
        public double TimeWorked { get => timeWorked; set => timeWorked = value; }

        public double GetTime(DateTime dateTime)
        {
            double TimeOnly;
            TimeOnly = int.Parse(dateTime.ToString("hh:mm").Replace(':', '.'));
            return TimeOnly;
        }
    }
}
