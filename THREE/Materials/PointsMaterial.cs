﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisLib
{
    /// <summary>
    /// Analogous to https://github.com/mrdoob/three.js/blob/master/src/materials/PointsMaterial.js
    /// </summary>
    public class PointsMaterial : Material
    {

        /// <summary>
        /// Material color.
        /// </summary>
        [JsonProperty("color")]
        public int Color { get; set; }

        /// <summary>
        /// Point size.
        /// </summary>
        [JsonProperty("size")]
        public double Size { get; set; }

        /// <summary>
        /// Size attenuation flag.
        /// </summary>
        [JsonProperty("sizeAttenuation", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SizeAttenuation { get; set; }

        [JsonIgnore]
        public Texture Map { get; set; }

        /// <summary>
        /// Material diffuse color map.
        /// </summary>
        [JsonProperty("map")]
        public Guid? MapUuid
        {
            get
            {
                if (Map != null)
                    return Map.Uuid;
                else return null;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PointsMaterial()
        {
            Type = "PointsMaterial";
        }
    }
}