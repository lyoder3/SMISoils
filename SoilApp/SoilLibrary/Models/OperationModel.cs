﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoilLibrary.Models
{
    public class OperationModel : ITimeboundObject
    {
        /// <summary>
        /// Unique id from database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Unique field id from database associated with this record
        /// </summary>
        public int FieldId { get; set; }
        /// <summary>
        /// Unique analysis id from database for the product applied in this record
        /// </summary>
        public int AnalysisId { get; set; }
        /// <summary>
        /// Timestamp from intentions sheet when product was applied
        /// </summary>
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Amount of product applied
        /// </summary>
        public decimal AppliedAmount { get; set; }
    }
}
