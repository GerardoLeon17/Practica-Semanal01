using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eventos.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }
        public string TypeEvent { get; set; }
        public DateTime? DayEvent { get; set; }
        public string Capacity { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }


    }
}