using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppBasic.Models
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }

        protected Entity() => Id = Guid.NewGuid();


    }
}
