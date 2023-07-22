using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DictIntToObjectList
{
    public class TerminalRestrictionHelper
    {
        public static Dictionary<int, List<TerminalTimeslotVehicle>> GetQuotaMemberToVehiclesDictionary(List<TerminalTimeslotVehicle> vehiclesByQuotas)
        {
            var vehiclesQuotaDictionary = new Dictionary<int, List<TerminalTimeslotVehicle>>() { };

            foreach (var vehicleByQuota in vehiclesByQuotas)
            {
                var restrictionOwnerOfVehicle = 0;

                var vehicleOwner = vehicleByQuota.Members.Where(x => x.MemberRole == MemberRole.VehicleOwner).FirstOrDefault();

                var restrictionOwner = vehicleByQuota.Members.Where(x => x.MemberRole == MemberRole.RestrictionOwner).FirstOrDefault();

                if (vehicleOwner.MemberType == MemberType.Carrier || vehicleOwner.MemberType == MemberType.Driver)
                {
                    restrictionOwnerOfVehicle = restrictionOwner.MemberId;
                }

                if (vehicleOwner.MemberType == MemberType.CargoOwner)
                {
                    restrictionOwnerOfVehicle = vehicleOwner.MemberId;
                }

                if (vehiclesQuotaDictionary.ContainsKey(restrictionOwnerOfVehicle))
                {
                    vehiclesQuotaDictionary[restrictionOwnerOfVehicle].Add(vehicleByQuota);
                }

                else
                {
                    vehiclesQuotaDictionary.Add(restrictionOwnerOfVehicle, new List<TerminalTimeslotVehicle>() { vehicleByQuota });
                }
            }


            //var dict = (from a in vehiclesByQuotas
            //			from b in a.Members
            //			let vehicleOwner = a.Members.Where(x => x.MemberRole == MemberRole.VehicleOwner).FirstOrDefault()
            //			where (vehicleOwner.MemberType == MemberType.Carrier || vehicleOwner.MemberType == MemberType.Driver)
            //			? b.MemberRole == MemberRole.RestrictionOwner : b.MemberRole == MemberRole.VehicleOwner
            //			group a by b.MemberId into grouped
            //			select grouped).ToDictionary(x => x.Key, x => x.ToList());


            return vehiclesQuotaDictionary;
        }
    }
}
