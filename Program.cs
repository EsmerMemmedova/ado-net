using Task_Ado_net.Services;

namespace Task_Ado_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe1 employe1 = new Employe1()
            {
                Name = "Esmer",
                Surname = "Memmdeova",
                Salary = 145

            };
            EmployeServices employeServices=new EmployeServices();
            employeServices.Create(employe1);


            foreach(var item in employeServices.GetAll())
            {
                Console.WriteLine(item);
            }


            employeServices.Delete(1);
            employeServices.Update(1,"hdbvdg");
        }


    }

}
