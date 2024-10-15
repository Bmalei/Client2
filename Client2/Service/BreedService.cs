using Client2.Model;
using Client2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2.Service
{
    public class BreedService
    {
        BreedRepository breedRepository = new BreedRepository();

        public BreedModel GetBreedById(int id)
        {
            return breedRepository.GetById(id);
        }

        public bool AddBreed(BreedModel breed)
        {
            return breedRepository.Add(breed);
        }

        public bool UpdateBreed(BreedModel breed)
        {
            return breedRepository.Update(breed);
        }

        public bool DeleteBreed(BreedModel breed)
        {
            return breedRepository.Delete(breed);
        }
    }
}
