using System;
using System.ComponentModel.DataAnnotations;

namespace NiceHairMVC.Models
{
    public class Services
    {
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public int ServicePrice { get; set; }
        public string ServiceType { get; set; }
    }
}
