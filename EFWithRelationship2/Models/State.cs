using System.ComponentModel.DataAnnotations;

namespace EFWithRelationship2.Models
{
    public class State
    {
        public int Id { get; set; }
        [Required(ErrorMessage="{0} Campo obrigatório!")]
        [Display(Name="Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage ="{0} Campo Obrigatório!")]
        [Display(Name ="UF")]
        [StringLength(2,ErrorMessage = "Obrigatório 2 caracteres!")]
        public string Uf { get; set; }
        public State() { }
        public State(int _id, string _name,string _uf)
        {
            Name = _name;
            Uf = _uf;
        }
    }
}