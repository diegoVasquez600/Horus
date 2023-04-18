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
        public int Porcentage => (int)Math.Round((double)CurrentPoints / TotalPoints * 100);
        public double Progress => (double)Porcentage / 100;
        public string BackgroundColor
        {
            get
            {
                if (Porcentage == 100)
                {
                    return "#F49390"; // return green if the percentage is 100
                }
                else
                {
                    return "#F7F5F6"; // return red if the percentage is less than 100
                }
            }
        }
        public string TitleColor
        {
            get
            {
                if (Porcentage == 100)
                {
                    return "White";
                }
                else
                {
                    return "#1A1A1A";
                }
            }
        }
        public string DescriptionColor
        {
            get
            {
                if (Porcentage == 100)
                {
                    return "White";
                }
                else
                {
                    return "#828282";
                }
            }
        }

        public string PorcentageColor 
        {
            get
            {
                if (Porcentage == 100)
                {
                    return "White";
                }
                else
                {
                    return "#F49390";
                }
            }
        }

        public string Image
        {
            get
            {
                if (Porcentage == 100)
                {
                    return "arrow_right_w.png";
                }
                else
                {
                    return "arrow_right_g.png";
                }
            }
        }


    }
}
