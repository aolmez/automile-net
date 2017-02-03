﻿using System.ComponentModel.DataAnnotations;


namespace Automile.Net
{
    public class Contact2CreateModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Description { get; set; }
        [Required]
        public int? CreateRelationshipToCompanyId { get; set; }
        public string CultureName { get; set; }
        public string CountryCodeIso1366 { get; set; }
        public int? DefaultVehicleId { get; set; }
        public ApiUnitType UnitType { get; set; }
        public bool SubscribeToNewsLetter { get; set; }
        public string MobilePhoneNumber { get; set; }
        public ApiMapType? MapType { get; set; }

        /// <summary>
        /// ISO 4217 Currency code
        /// </summary>
        public string CurrencyCode { get; set; }
    }
}
