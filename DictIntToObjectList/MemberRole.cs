using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DictIntToObjectList
{
    /// <summary>
    /// Роль Контрагента
    /// </summary>
    [Serializable]
    [DataContract]
    public enum MemberRole
    {
        /// <summary>
        /// Неопределенная
        /// </summary>
        [DataMember]
        None = 0,

        /// <summary>
        /// API SmartSeeds
        /// </summary>
        [DataMember]
        SmartSeedsApi = 1,

        /// <summary>
        /// Покупатель
        /// </summary>
        [DataMember]
        Buyer = 10,

        /// <summary>
        /// Продавец
        /// </summary>
        [DataMember]
        Seller = 11,

        /// <summary>
        /// Владелец Груза
        /// </summary>
        [DataMember]
        CargoOwner = 100,

        /// <summary>
        /// Владелец Машины
        /// </summary>
        [DataMember]
        VehicleOwner = 200,

        /// <summary>
        /// Владелец Машины (Менеджер ГВ)
        /// </summary>
        [DataMember]
        ManagerVehicleOwner = 201,

        /// <summary>
        /// Пользователь, который удалил машину
        /// </summary>
        UserWhoDeletedVehicle = 202,

        /// <summary>
        /// Владелец Резерва
        /// </summary>
        [DataMember]
        ReservationOwner = 300,

        /// <summary>
        /// Создатель Резерва
        /// </summary>
        [DataMember]
        ReservationCreater = 302,

        /// <summary>
        /// Владелец Ограничения
        /// </summary>
        [DataMember]
        RestrictionOwner = 400,

        /// <summary>
        /// Создатель Ограничения
        /// </summary>
        [DataMember]
        RestrictionCreater = 402,

        /// <summary>
        /// Грузоотправитель
        /// </summary>
        [DataMember]
        Consignor = 800,

        /// <summary>
        /// Трейдер (Экспортер)
        /// </summary>
        [DataMember]
        Trader = 801,

        /// <summary>
        /// Организация
        /// </summary>
        [DataMember]
        Organization = 802,

        /// <summary>
        /// Пользователь
        /// </summary>
        [DataMember]
        User = 2

    }
}