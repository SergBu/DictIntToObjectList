using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DictIntToObjectList
{
    public class TerminalTimeslotVehicle
    {
        public TerminalTimeslotVehicle()
        {
            Version = 0;
        }

        public int Id { get; set; }
        [NotMapped]
        public int TerminalTimeslotVehicleId
        {
            get => Id;
            set => Id = value;
        }

        [JsonIgnore]
        public int TerminalTimeslotId { get; set; }

        [JsonProperty("ReservationId")]
        public int TerminalTimeslotReservationId { get; set; }

        public bool ShouldSerializeTerminalTimeslotReservationId() => TerminalTimeslotReservationId > 0;

        /// <summary>
        /// Версия
        /// </summary>
        [NotMapped]
        [JsonIgnore]
        public int Version { get; set; }

        public virtual ICollection<TerminalTimeslotVehicleMember> Members { get; set; }

    }
}