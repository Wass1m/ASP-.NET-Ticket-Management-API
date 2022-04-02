using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnomaliesApi.Entities;

namespace AnomaliesApi.Services
{
    public class InMemoryRepository : IRepository
    {

        private List<Ressource> _ressources;

        public InMemoryRepository()
        {

            _ressources = new List<Ressource>()
            {
                new Ressource()
                {
                    id = 1,
                    description = "desc1",
                    localisation = "loc1"
                },
                 new Ressource()
                {
                    id = 2,
                    description = "desc2",
                    localisation = "loc2"
                },

            };

        }

        public async Task<List<Ressource>> GetAllRessources()
        {
            // await Task.Delay(2000);
            return _ressources;
        }

        public Ressource GetRessourceById(int Id)
        {
            return _ressources.FirstOrDefault(ress => (int)ress.id == Id);
        }
    }
}
