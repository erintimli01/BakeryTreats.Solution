using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BakeryTreats.Models
{
  public class Treat
  {

    public int TreatId { get; set; }
    [Required(ErrorMessage = "A treat must be added")]
    public string Name { get; set; }
    
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}