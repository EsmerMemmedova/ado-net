

using System.Data;

namespace Task_Ado_net.Services
{
    public  class EmployeServices
    {
        AddDbContext dbContext;
        public EmployeServices()
        {
            this.dbContext = new AddDbContext();
        }
        public void Create(Employe1 employe1)
        {
            string createCommand = $"insert into Employes values('{employe1.Name}','{employe1.Surname}',{employe1.Salary})";
            int result=dbContext.Nonquery(createCommand);
           
        }

        public void Update (int id,string name)
        {
            string command =$"Update Employe1s SET name='{name}' where Id={id}";
            dbContext.Nonquery(command);

        }

        public void Delete(int id)
        {
            string command = $"delete from Employe1s where Id={id}";
            dbContext.Nonquery(command);
        }
        public List<Employe1> GetAll()
        {
            string query = "select *from Employe1s";
            DataTable table=dbContext.Query(query);
            List<Employe1>list=new List<Employe1>();
            foreach(DataRow item in table.Rows)
            {
               
                list.Add(new Employe1()
                {
                    Id = int.Parse(item["Id"].ToString()),
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Salary = double.Parse(item["Salary"].ToString())

                });
            }
            return list;
        }

    }
}
