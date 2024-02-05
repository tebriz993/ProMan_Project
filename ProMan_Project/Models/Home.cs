using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProMan_Project.Models
{
    public class Home
    {
        //----------Home------------
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="FullName must be maximum 50 symbol...")]
        public string FullName { get; set; }

        [Required]
        public string Skills { get; set; }


        //----------About----------
        [Required]
        public int YearsCount { get; set; } = 1;

        [Required]
        public string OfWorkingExperienceAs_Skills { get; set; }

        [Required]
        [MaxLength(250,ErrorMessage ="AboutUpTitle must be maximum 250 symbol...")]
        public string AboutUpTitle { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Feature1 must be maximum 50 symbol...")]
        public string Feature1 { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Feature2 must be maximum 50 symbol...")]
        public string Feature2 { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Feature3 must be maximum 50 symbol...")]
        public string Feature3 { get; set; }

        [Required]
        public string Image1 { get; set; }

        [Required]
        public string Image2 { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "Image1Title must be maximum 40 symbol...")]
        public string Image1Title { get; set; }

        [Required]
        public string Image1Number { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "Image1UpTitle must be maximum 250 symbol...")]
        public string Image1UpTitle { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "Image1Title must be maximum 40 symbol...")]
        public string Image2Title { get; set; }

        [Required]
        public string Image2Number { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "Image1UpTitle must be maximum 250 symbol...")]
        public string Image2UpTitle { get; set; }

        //Skills
        [Required]
        [MaxLength(25)]
        public string Skill1 { get; set; }

        [Required]
        [MaxLength(25)]
        public string Skill2 { get; set; }

        [Required]
        [MaxLength(25)]
        public string Skill3 { get; set; }

        [Required]
        [MaxLength(25)]
        public string Skill4 { get; set; }

        [Required]
        [MaxLength(25)]
        public string Skill5 { get; set; }

        [Required]
        [MaxLength(25)]
        public string Skill6 { get; set; }

        //Services
        public string service1Name {  get; set; }
        public string service1Title {  get; set; }
        public string service1UpTitle { set; get; }

        public string service2Name { get; set; }
        public string service2Title { get; set; }
        public string service2UpTitle { set; get; }

        public string service3Name { get; set; }
        public string service3Title { get; set; }
        public string service3UpTitle { set; get; }

        public string service4Name { get; set; }
        public string service4Title { get; set; }
        public string service4UpTitle { set; get; }

        public string service5Name { get; set; }
        public string service5Title { get; set; }
        public string service5UpTitle { set; get; }

        public string service6Name { get; set; }
        public string service6Title { get; set; }
        public string service6UpTitle { set; get; }




    }
}
