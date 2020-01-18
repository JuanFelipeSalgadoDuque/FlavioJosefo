using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavioJosefo.Models
{
    public class Player
    {

        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        

        public Player(Guid id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}