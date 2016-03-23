namespace WebAppDemo.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {
        private class EmployeeMetaData
        {
            public string LastName { get; set; }

            public bool IsSky()
            {
                if(LastName == "Sky")
                {
                    return true;
                }
                return false;
            }
        }

    }
}