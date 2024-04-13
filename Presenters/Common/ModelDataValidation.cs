using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters.Common
{
    internal class ModelDataValidation
    {
        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay Mode Name is requiered")]
        [StringLength(50, MinimumLength =3,
            ErrorMessage = "Pay Mode Name must be between 3 and 50 characters")]
        
        public string Name { get; set; }
        public void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);
            if (isValid == false) 
            {
            foreach(var item in validationResults) 
                {
                errorMessage += item.ErrorMessage + "\n"; 
                }
            throw new Exception(errorMessage);
            }
        }
    }
}
