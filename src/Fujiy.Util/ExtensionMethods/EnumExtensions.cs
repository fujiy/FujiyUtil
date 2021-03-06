﻿using System.ComponentModel;
using System.Reflection;
using System;

namespace Fujiy.Util.ExtensionMethods
{
    public static class EnumExtensions
    {
        public static string ToDescription(this Enum value)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}