using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<EmployeeView> _employeers;
        public EmployeeService()
        {
            _employeers = new List<EmployeeView>
            {
               new EmployeeView
               {
                   Id = 1,
                   FirstName = "Иван",
                   LastName = "Иванович",
                   Patronymic = "Иванов",
                   Age = 22

               },
               new EmployeeView
               {
                   Id = 2,
                   FirstName = "Иван1",
                   LastName = "Иванович1",
                   Patronymic = "Иванов1",
                   Age = 23

               },
               new EmployeeView
               {
                   Id = 3,
                   FirstName = "Иван2",
                   LastName = "Иванович2",
                   Patronymic = "Иванов2",
                   Age = 24

               }
             };
        }

       public IEnumerable<EmployeeView> GetAll()
        {
            return _employeers;
        }

      public  EmployeeView GetById(int id)
        {
            return _employeers.FirstOrDefault(x => x.Id == id);
        }

       public void Commit()
        {


        }

       public void AddNew(EmployeeView model)
        {
            model.Id = _employeers.Max(e => e.Id) + 1;
            _employeers.Add(model);
        }
      public  void Delete(int id)
        {
            var emp = GetById(id);
            if (emp == null) return;
            _employeers.Remove(emp);

        }
        

    }
}
