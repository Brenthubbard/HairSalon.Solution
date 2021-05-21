using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
   

    public string Name { get; set; }
    public int ClientId { get; set; }
    public string Description { get; set; }
    public string StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}