using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    //list
    //constructor


    // - name, 
    // - gender, 
    // - date of admittance, and 
    // - breed. 
    // - type.

    public int AnimalId { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfAdmittance { get; set; }
    public string Type { get; set; }
    public string Breed { get; set; }
  }
}