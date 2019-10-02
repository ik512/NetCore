using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels
{
    public class EmployeeView
    {
        public int Id { get; set; }
         [Required(AllowEmptyStrings =false,ErrorMessage ="имя обязательно к заполнению")] 
         [Display(Name ="Имя")]
         [StringLength(maximumLength:200,MinimumLength =2,ErrorMessage ="должно быть не менее 2-х символов и" +
            " не более 200")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия обязательно к заполнению")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст обязателен к заполнению")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }
    }
}
