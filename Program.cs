namespace Day10EmpWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilder builder = new EmpWageBuilder();
            builder.addCompanyEmpWage("Infosys",20,2,20);
            builder.addCompanyEmpWage("TCS", 10, 4, 25);
            builder.computeEmpWage();
        }
    }
}