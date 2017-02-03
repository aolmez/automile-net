﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Automile.Net
{
    public class Contact2DetailModel
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Description { get; set; }      
        public string CultureName { get; set; }
        public string CountryCodeIso1366 { get; set; }
        public int? DefaultVehicleId { get; set; }
        public ApiUnitType UnitType { get; set; }
        public bool SubscribeToNewsLetter { get; set; }
        public string MobilePhoneNumber { get; set; }

        public ApiMapType? MapType { get; set; }
        public int? CheckedIntoVehicleId { get; set; }
        public DateTime? CheckedInDateTimeUtc { get; set; }
        public DateTime? CheckOutDateTimeUtc { get; set; }

        public ApiTripType? CheckedInTripType { get; set; }
        
        public List<ApiRoleTypeInCompany> CompanyRoles { get; set; }
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// ISO 4217 Currency code
        /// </summary>
        public string CurrencyCode { get; set; }

        public List<CompanyScopesModel> CompaniesScopes { get; set; }
        public bool IsLocked { get; set; }        

        public List<CustomCategoryModel> CustomCategories { get; set; }
    }
}
