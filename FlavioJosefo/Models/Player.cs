using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavioJosefo.Models
{
    public class Player
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        

        public Player(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}