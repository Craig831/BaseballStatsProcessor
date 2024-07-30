using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Link { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryNumber { get; set; }
        public string BirthDate { get; set; }
        public int CurrentAge { get; set; }
        public string BirthCity { get; set; }
        public string BirthStateProvince { get; set; }
        public string BirthCountry { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public bool Active { get; set; }
        public Position PrimaryPosition { get; set; }
        public string UseName { get; set; }
        public string MiddleName { get; set; }
        public string BoxScoreName { get; set; }
        public string NickName { get; set; }
        public int DraftYear { get; set; }
        public string MlbDebutDate { get; set; }
        public string NameFirstLast { get; set; }
        public string NameSlug { get; set; }
        public string FirstLastName { get; set; }
        public string LastFirstName { get; set; }
        public string LastInitName { get; set; }
        public string InitLastName { get; set; }
        public string FullFMLName { get; set; }
        public string FullLFMName { get; set; }
    }
}
