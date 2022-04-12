using System.ComponentModel.DataAnnotations; 


namespace ApiGlauciaEstagio.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Cidade { get; set; }

        public int Idade { get; set; }


    }


}