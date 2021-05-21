using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int Name { get; set; }
    public int StylistId { get; set; }
    public virtual Client Clients { get; set; }
  }
}