using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eagle_hometeach.src.Models
{
    public class TeacherDetail
    {
        [Column("TeacherID")] 
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [Required(ErrorMessage = "Employee ID is required")] 
        [Display(Name = "Employee ID")] 
        public int TeacherID { get; set; }

        [Column("FullName")]
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        //[StringLength(20, ErrorMessage = "Full Name must be less than 20 characters")]
        public string FullName { get; set; }

        [Column("Subjects")]
        [Display(Name = "Subjects Taught")]
        [Required(ErrorMessage = "Subject is required")]
        [StringLength(500, ErrorMessage = "Subject must be less than 50 characters")]
        public string Subjects { get; set; }

        [Column("YearsOfExperience")]
        [Display(Name = "Years of Experience")]
        [Required(ErrorMessage = "Years of Experience is required")]
        [StringLength(3, ErrorMessage = "Years of Experience must be less than 3 characters")]
        public string YearsOfExperience { get; set; }

        [Column("PictureLink")]
        [Display(Name = "Picture Link")]
        [Required(ErrorMessage = "Picture Link is required")]
        [StringLength(200, ErrorMessage = "Picture Link must be less than 200 characters")]
        public string PictureLink { get; set; }

        [Column("State")]
        [Display(Name = "State of Residence")]
        [Required(ErrorMessage = "State is required")]
        [StringLength(20, ErrorMessage = "State must be less than 20 characters")]
        public string State { get; set; }

        [Column("Phone")]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(14, ErrorMessage = "Phone Number must be less than 14 characters")]
        public string Phone { get; set; }

        [Column("Description")]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description must be less than 500 characters")]
        public string Description { get; set; }
    }
}
