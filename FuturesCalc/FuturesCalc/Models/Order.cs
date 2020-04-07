using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FuturesCalc.Models
{
    public class Order
    {
        [Display(Name="Entry Price")]
        public decimal EntryPrice { get; set; }
        [Display(Name="Exit Price")]
        public decimal ExitPrice { get; set; }
        [Display(Name = "Contracts")]
        public int Contract { get; set; }
        [Display(Name = "Profit And Lose")]
        public decimal ProfitAndLose { get; set; }
        [Display(Name = "Ticks")]
        public decimal Tick { get; set; }
        [Display(Name = "Points")]
        public decimal point { get; set; }


    }
}
