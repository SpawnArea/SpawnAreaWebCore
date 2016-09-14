using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpawnAreaWebCore.Models
{
    public class MediaFile
    {
        public string VideoId { get; set; }
        [Url]
        public Uri SourceUrl { get; set; }

    }
}
