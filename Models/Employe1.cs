

namespace Task_Ado_net.Models
{
    public class Employe1
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }


        public override string ToString()
        {
            return $"Name:{Name},Surname:{Surname},Salary:{Salary}";
        }
    }
}
