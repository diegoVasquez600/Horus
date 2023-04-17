using System;
using System.Collections.Generic;
using System.Text;

namespace Horus.Models
{
    public class Challenge
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CurrentPoints { get; set; }
        public int TotalPoints { get; set; }
    }
}
