using System.Collections.Generic;
using System;

namespace TennisCourt.Models
{

  public class Player
  {

    public Player()
    {
      this.JoinEntities = new HashSet<CourtPlayer>();
    }

    public int PlayerId { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
  
    public virtual ICollection<CourtPlayer> JoinEntities { get; }
  }
}