using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SESSION_1_DEMO.entity
{
    // EF core support 4 ways for mapping classes in databases ( table , view , funcion )
    // 1-By (Convention) --> default
    // 2- By Annotation (Set of attributes used to data validation)
    // 3- fluent API (override onmodelcreating)
    // 4- class configrations
    [Table ("employee" , Schema = "dbo")]
    internal class employee
    {
        #region by convention
        //public int Id { get; set; } // public numeric property 'ID' || 'Employeeid' -> PK identity (1 ,1)
        //public string? Name { get; set; } // Refrence type : Allow Null (optional) -> nvarchar(max)
        //                                  //  public string Name { get; set; } // Refrence type : not allow Null (required) ->  nvarchar(max)

        //public double Salary { get; set; } // Value Type : Not Allow Null ->  float

        //public int? Age { get; set; } // Nullable <int> : Allow Null (optional)+
        #endregion
        #region by annotation
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int EmpId { get; set; }
        //[Required]
        //[Column (TypeName ="varchar")]
        //[MaxLength (50)]
        //[StringLength(50, MinimumLength = 10)]
        //public string? Name { get; set; }
        //[Column (TypeName = "money")]
        //public double Salary { get; set; }
        //[Required]
        //[Range (20,50)]
        //public int? Age { get; set; }
        //[StringLength(50, MinimumLength = 10)]
        //public string Address { get; set; }
        //[Phone]
        //public int phone { get; set; }
        //[EmailAddress]
        //public string email { get; set; }
        //[NotMapped]
        //public double Totalsalary { get; set; } //derrivied attribute
        //public int num { get; set; }
        #endregion
        #region by fluent api
        public int EmpId { get; set; }
       
        public string? Name { get; set; }
     
        public double Salary { get; set; }
  
        public int? Age { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public double Totalsalary { get; set; } 
        public int num2 { get; set; }
        #endregion

    }
}
