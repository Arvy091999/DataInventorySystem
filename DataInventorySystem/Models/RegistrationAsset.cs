using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataInventorySystem.Models
{
    public class RegistrationAsset
    {
        [Key]
        public int AssetRegisterNo { get; set; }
        public string AssetName { get; set; }
        public string DeptServices { get; set; }
        public string Location { get; set; }
        public string Owner { get; set; }
        public string Administrator { get; set; }
        public string Classification { get; set; }

    }
}