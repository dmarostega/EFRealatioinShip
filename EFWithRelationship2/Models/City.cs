using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFWithRelationship2.Models
{
    public class City
    {
        public int Id { get; set; }
        [Required(ErrorMessage="{0} Campo obrigatório")]
        [Display(Name="Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} Campo obrigatório")]
        [Display(Name ="Estado")]
        public int StateId { get; set; }
        public State State { get; set; }

        public City() { }
        public City(int _id,string _name, State _state)
        {
            Name = _name;
            State = _state;
        }

    }
}
