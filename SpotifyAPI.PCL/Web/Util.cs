namespace SpotifyAPI.PCL.Web
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    public static class Util
    {
        public static string GetStringAttribute<T>(this T en, string separator) where T : struct
        {
            Enum e = (Enum)(object)en;
            IEnumerable<StringAttribute> attributes =
            Enum.GetValues(typeof(T))
            .Cast<T>()
            .Where(v => e.HasFlag((Enum)(object)v))
            .Select(v => typeof(T).GetTypeInfo().GetDeclaredField(Convert.ToString(v, CultureInfo.InvariantCulture)))
            .Select(f => f.GetCustomAttributes(typeof(StringAttribute), false).FirstOrDefault())
            .Cast<StringAttribute>();

            List<string> list = new List<string>();
            attributes.ToList();


            foreach (var element in attributes)
            {
                list.Add(element.Text);
            }

            return string.Join(separator, list);
        }
    }

    public sealed class StringAttribute : Attribute
    {
        public string Text { get; set; }

        public StringAttribute(string text)
        {
            this.Text = text;
        }
    }
}
