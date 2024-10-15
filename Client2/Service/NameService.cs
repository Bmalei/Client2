using Client2.Model;
using Client2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Client2.Service
{
    public class NameService
    {
        NameRepository nameRepository = new NameRepository();

        public NameModel GetNameById(int id)
        {
            return nameRepository.GetById(id);
        }

        public bool AddName(NameModel name)
        {
            return nameRepository.Add(name);
        }

        public bool UpdateName(NameModel name)
        {
            return nameRepository.Update(name);
        }

        public bool DeleteName(NameModel name)
        {
            return nameRepository.Delete(name);
        }
    }
}
