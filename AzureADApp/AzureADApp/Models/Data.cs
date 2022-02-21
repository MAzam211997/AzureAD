using System.Collections.Generic;

namespace AzureADApp.Models
{
    public class Data
    {
        public static List<NamesModel> NamesList = new List<NamesModel>()
        {
            new NamesModel{FirstName="Rameez", LastName="Aslam"},
            new NamesModel{FirstName="Ali", LastName="Raza"}
        };
    }
}
