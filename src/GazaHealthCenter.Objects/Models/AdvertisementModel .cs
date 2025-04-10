using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazaHealthCenter.Objects.Models
{
    public class AdvertisementModel : AModel
    {
        [StringLength(128)]
        public string Title { get; set; }

        public string Content { get; set; }

        public string? MediaUrl { get; set; }

        public DateTime DatePosted { get; set; }

        public int LikesCount { get; set; }
    }
}
