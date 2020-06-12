﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNuke.Entities.Modules.Settings
{
    [Serializable]
    public class ParameterMapping
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterMapping"/> class.
        /// </summary>
        /// <param name="attribute">The attribute.</param>
        /// <param name="property">The property.</param>
        public ParameterMapping(ParameterAttributeBase attribute, PropertyInfo property)
        {
            this.Attribute = attribute;
            this.Property = property;

            var parameterName = attribute.ParameterName;
            if (string.IsNullOrWhiteSpace(parameterName))
            {
                parameterName = property.Name;
            }

            if (!string.IsNullOrWhiteSpace(attribute.Prefix))
            {
                parameterName = attribute.Prefix + parameterName;
            }

            this.FullParameterName = parameterName;
        }

        public ParameterAttributeBase Attribute { get; set; }

        public string FullParameterName { get; set; }

        public PropertyInfo Property { get; set; }
    }
}
