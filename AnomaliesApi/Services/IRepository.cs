using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnomaliesApi.Entities;

namespace AnomaliesApi.Services
{
    public interface IRepository
    {
        Task<List<Ressource>> GetAllRessources();
        Ressource GetRessourceById(int Id);
    }
}
