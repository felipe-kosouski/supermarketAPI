﻿using System;
using System.ComponentModel;
using System.Reflection;

namespace SupermarketAPI.Extensions
{
    public static class EnumExtensions
    {
        public static string ToStringDescriptions<TEnum>(this TEnum @enum)
        {
            FieldInfo info = @enum.GetType().GetField(@enum.ToString());
            var attributes = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes?[0].Description ?? @enum.ToString();

        }
    }
}
