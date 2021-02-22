using AutoMapper;
using Meta.Backend.Data;
using Meta.Backend.DTOs;
using Meta.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Meta.Backend.Controllers
{
    [Route("api/contatos")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly IContatoRepository _repository;
        private readonly IMapper _mapper;

        public ContatosController(IContatoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        
        /// <summary>
        /// Obter todos os contatos
        /// </summary>
        /// <param name="page">Número da página</param>
        /// <param name="size">Total de registros por página</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<ContatoReadDto>> GetAllContatos(int page = 0, int size = 10)
        {
            int skip = page * size;
            var contatoItems = _repository.GetAllContatos();
            int total = contatoItems.Count();
            int pageCount = total > 0 ? (int)Math.Ceiling(total / (double)size) : 0;
            if (pageCount <= page)
                return NotFound();

            contatoItems = _repository.GetAllContatos().Skip(skip).Take(size);
            Response.Headers.Add("X-Page-PageNo", page.ToString());
            Response.Headers.Add("X-Page-Size", size.ToString());
            Response.Headers.Add("X-Page-PageCount", pageCount.ToString());
            Response.Headers.Add("X-Page-TotalRecord", total.ToString());
            return Ok(_mapper.Map<IEnumerable<ContatoReadDto>>(contatoItems));
        }

        //GET api/contatos/{id}
        [HttpGet("{id}", Name="GetContatoById")]
        public ActionResult<ContatoRepository> GetContatoById(int id)
        {
            var contatoItem = _repository.GetContatoById(id);
            if (contatoItem != null)
            {
                return Ok(_mapper.Map<ContatoReadDto>(contatoItem));
            }

            return NotFound();
        }

        //POST api/contatos
        [HttpPost]
        public ActionResult<ContatoReadDto> CreateContato(ContatoCreateDto contato)
        {
            var contatoModel = _mapper.Map<Contato>(contato);
            _repository.CreateContato(contatoModel);
            _repository.SaveChanges();

            var contatoReadDto = _mapper.Map<ContatoReadDto>(contatoModel);

            return CreatedAtRoute(nameof(GetContatoById), new { Id = contatoReadDto.Id }, contatoReadDto);
        }

        //PUT api/contatos/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateContato(int id, ContatoUpdateDto contatoUpdateDto)
        {
            var contatoFromRepo = _repository.GetContatoById(id);
            if (contatoFromRepo == null)
                return NotFound();

            _mapper.Map(contatoUpdateDto, contatoFromRepo);

            _repository.UpdateContato(contatoFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/contatos/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteContato(int id)
        {
            var contatoFromRepo = _repository.GetContatoById(id);
            if (contatoFromRepo == null)
                return NotFound();

            _repository.DeleteContato(contatoFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
