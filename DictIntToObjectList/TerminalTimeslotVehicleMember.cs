using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DictIntToObjectList
{
    public class TerminalTimeslotVehicleMember
    {
        public int Id {  get; set; }

        [NotMapped]
        [JsonIgnore]
        public int TerminalTimeslotVehicleMemberId
        {
            get => Id;
            set => Id = value;
        }

        [JsonIgnore]
        public int TerminalTimeslotVehicleId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public MemberRole MemberRole { get; set; }

        public int MemberId { get; set; }

        [NotMapped]
        public int[] CargoOwnerIds { get; set; }

        [NotMapped]
        [JsonIgnore]
        public MemberType MemberTypeCode { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public MemberType MemberType
        {
            get => MemberTypeCode;
            set => MemberTypeCode = value;
        }
    }
}
