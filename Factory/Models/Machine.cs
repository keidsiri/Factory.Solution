using System.Collections.Generic;
using System;

namespace Factory.Models
{

  public class Machine
  {

    public Machine()
    {
      this.JoinEntities = new HashSet<CourtMachine>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
  
    public virtual ICollection<CourtMachine> JoinEntities { get; }
  }
}