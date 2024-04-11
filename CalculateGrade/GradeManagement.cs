namespace CalculateGradeBL
{
    public class GradeManagement
    {
        public static double CalculateGWA(double datastruc, double algo, double database, double prog, double network)
        {
            double average = (datastruc + algo + database + prog + network) / 5;
            return average;
        }
    }
}
