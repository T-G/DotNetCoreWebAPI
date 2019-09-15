using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrgDAL
{
    public class Department
    {

        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DId { get; set; }
        [Required]
        public string DName { get; set; }
        public string Description { get; set; }
    }
}
