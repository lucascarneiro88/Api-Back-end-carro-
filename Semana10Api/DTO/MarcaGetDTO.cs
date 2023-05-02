﻿namespace Semana10Api.DTO
{
    
        public class MarcaGetDTO
        {
        public int Id { get; set; }
        
        public string Nome { get; set; }
        public List<CarroGetDTO> ListaCarroGetDTO { get; set; }

        }

        public class CarroGetDTO
        {
        public int Id { get; set; }
        public string DescricaoCarro { get; set; }
        public int IdMarca { get; set; }
        public DateTime DataLocacao { get; set; }
        public List<MarcaDTO> ListaMarcaDTO { get; set; }

        }
    
}
