using System.Threading.Tasks;
using ApiGlauciaEstagio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiGlauciaEstagio.Models;





namespace ApiGlauciaEstagio.Controllers
{

    [Controller]
    [Route("[controller]")]


    public class ClienteController : ControllerBase
    {

        private DataContext dc;

        public ClienteController(DataContext context)
        {

            this.dc = context;

        }


        [HttpPost("api")] //cadastra informacoes


        public async Task<ActionResult> cadastrar([FromBody] Cliente c)  //o p abriga essas informações: nome, cidade, idade
        {
            dc.cliente.Add(c);
            await dc.SaveChangesAsync();

            return Created("objeto cliente", c);
        
        }


        
        [HttpGet("api")] //lista informacoes
        public async Task<ActionResult> listar()
        {
            var dados = await dc.cliente.ToListAsync();

            return Ok(dados);

        }



        [HttpGet("api/{codigo}")] //retornar informacao especifica ou objeto pelo codigo (id)
        public Cliente filtrar(int codigo)
        {
            Cliente c = dc.cliente.Find(codigo);
            
            return c;
        }


        [HttpPut("api")] //alterar informacoes
        public async Task<ActionResult> editar([FromBody] Cliente c)
        {

            dc.cliente.Update(c);
            await dc.SaveChangesAsync();

            return Ok(c);

        }

        [HttpDelete("api/{id}")] //remover um dado / objeto / registro
        public async Task<ActionResult> remover(int id)
        {

            Cliente c = filtrar(id);
            
                if(c == null){
                    
                    return NotFound();
                
                }else{

                    dc.cliente.Remove(c);
                    await dc.SaveChangesAsync();
                    return Ok();
                }


        }


        
        [HttpGet("cad")] // titulo
        public string cad()
        {
            return "Cadastro de Clientes";

        }




    }
}