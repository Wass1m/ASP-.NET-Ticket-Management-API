using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnomaliesApi.Data;
using AnomaliesApi.DTOs;
using AnomaliesApi.Entities;
using AnomaliesApi.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnomaliesApi.Controllers
{


    [Route("/api/ressources")]
    [ApiController]
    public class RessourceController : ControllerBase
    {
        private readonly MyDbContext context;
        private readonly IMapper mapper;

        public RessourceController(MyDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<List<RessourceDTO>>> Get()
        {

            var genres = await context.Ressources.ToListAsync();
            return mapper.Map<List<RessourceDTO>>(genres);


        }

        [HttpGet("{Id:int}")]
        public ActionResult<Ressource> GetRessource(int Id)
        {
            var genre = new Ressource() { id = 1, description = "desc1", localisation = "loc1" };

            if (genre == null)
            {
                return NotFound();
            }

            return genre;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateRessourceDTO ressourceCreationDTO)
        {
            var genre = mapper.Map<Ressource>(ressourceCreationDTO);
            context.Ressources.Add(genre);
            await context.SaveChangesAsync();

            return NoContent();
        }

        //[HttpDelete]
        //public List<Ressource> Delete()
        //{
        //    //return repository.GetAllRessources();
        //}

    }
}
