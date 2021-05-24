using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Column("EmployeeID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Employee ID is required")]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "First Name must be less than 20 characters")]
        [Required(ErrorMessage = "Employee First Name is required")]
        public string FirstName { get; set; }

        [Column("LastName")]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Last Name must be less than 20 characters")]
        [Required(ErrorMessage = "Employee Last Name is required")]
        public string LastName { get; set; }

        [Column("Title")]
        [Display(Name = "Title")]
        [StringLength(30, ErrorMessage = "Title must be less than 30 characters")]
        [Required(ErrorMessage = "Employee Title is required")]
        public string Title { get; set; }

        [Column("BirthDate")]
        [Display(Name = "Birth Date")]
        [Required(ErrorMessage = "Employee Birth date is required")]
        public DateTime BirthDate { get; set; }

        [Column("HireDate")]
        [Display(Name = "Hire Date")]
        [Required(ErrorMessage = "Employee Hire date is required")]
        public DateTime HireDate { get; set; }

        [Column("Country")]
        [Display(Name = "Country")]
        [StringLength(30, ErrorMessage = "Country must be less than 30 characters")]
        [Required(ErrorMessage = "Employee Country is required")]
        public string Country { get; set; }

        [Column("Notes")]
        [Display(Name = "Notes")]
        [StringLength(30, ErrorMessage = "Notes must be less than 30 characters")]
        public string Notes { get; set; }
    }
}
