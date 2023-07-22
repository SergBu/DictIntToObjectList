// See https://aka.ms/new-console-template for more information

using DictIntToObjectList;

var vehiclesByQuotas = new List<TerminalTimeslotVehicle>();

var vehiclesQuotaDictionary = TerminalRestrictionHelper.GetQuotaMemberToVehiclesDictionary(vehiclesByQuotas);

var restrictionOwner = new TerminalTimeslotVehicleMember();

//foreach (var restrictionOwner in item.RestrictionOwners.Where(x => x.MemberId == requestMemberId).ToList())
//{
//представление для restrictionOwner
var vehiclesByRestrictionOwner = vehiclesQuotaDictionary.ContainsKey(restrictionOwner.MemberId)
        ? vehiclesQuotaDictionary[restrictionOwner.MemberId]
        : new List<TerminalTimeslotVehicle>();
//}