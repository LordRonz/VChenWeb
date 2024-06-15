﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VChenWeb.Models
{
    public class Patient(string klinik, DateTime tanggal, string noFaktur, string namaTreatment, int quantity, string doctor)
    {
        public string Klinik { get; set; } = klinik;
        public DateTime Tanggal { get; set; } = tanggal;
        public string NoFaktur { get; set; } = noFaktur;
        public string NamaTreatment { get; set; } = namaTreatment;

        public int Quantity { get; set; } = quantity;

        public string Doctor { get; set; } = doctor;

        /// <summary>
        /// Overriding Equals is essential for use with Select and Table because they use HashSets internally
        /// </summary>
        public override bool Equals(object obj) => Equals(GetHashCode(), obj?.GetHashCode());
    }
}