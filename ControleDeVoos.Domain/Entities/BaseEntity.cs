using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeVoos.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
