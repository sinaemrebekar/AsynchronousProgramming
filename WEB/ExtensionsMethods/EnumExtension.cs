﻿using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WEB.ExtensionsMethods
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum @enum)
        {
            var field = @enum.GetType().GetField(@enum.ToString());
            var attribute = field?.GetCustomAttribute<DisplayAttribute>();
            return attribute?.Name ?? @enum.ToString();
        }
    }
}
