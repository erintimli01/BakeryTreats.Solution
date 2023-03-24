using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BakeryTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "A flavor must be added")]
    public string FlavorName { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
  }
}