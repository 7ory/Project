using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CubeX.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public string BookingType { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }


    }
}