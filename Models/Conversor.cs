namespace TDE04.Models
{
    public class Conversor
    {
        public double Converter(int a)
        {
            double A = a;
            return a;
        }
        public int ConverterDois(double a)
        {
            int A = Convert.ToInt32(a);
            return A;
        }
        public int Converter(string a)
        {
            int A = Convert.ToInt32(a);
            return A;
        }
        public double ConverterDois(string a)
        {
            double A = Convert.ToDouble(a);
            return A;
        }
    }
}