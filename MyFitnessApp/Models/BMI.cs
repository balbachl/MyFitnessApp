using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFitnessApp.Models
{
    public class BMI
    {
        public int ID { get; set; }
        public DateTime statDate { get; set; } = DateTime.Now;
        public float weight { get; set; } = 150;
        public float height { get; set; } = 65;
        public float BMICalculation { get; set; } = 0;
    }
}