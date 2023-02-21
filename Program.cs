namespace Day10EmpWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEmpWage builder = new EmpWageBuilder();
            builder.addCompanyEmpWage("Infosys",20,3,20);
            builder.addCompanyEmpWage("TCS", 10, 5, 25);
            builder.computeEmpWage();
        }
    }
}