using System;

namespace PetsControl 
{
    public class Pet
    {
     private String _petName;
     public String PetName
     {
        get { return _petName; }
        set { _petName = value; }
     }

     private String _petType;
     public String PetType
     {
        get { return _petType; }
        // Predefined values
        set { 
            if (value.ToLower() == "dog" || value.ToLower() == "cat" || value.ToLower() == "fish")
            {
                _petType = value;
            }
        }
     }

     public Pet()
     {
        _petType = "";
     }     
    }
}

