using System;

using R5T.T0028;


namespace System
{
    public static class IStringBuilderExtensions
    {
        public static string Build(this IStringBuilder stringBuilder)
        {
            var output = stringBuilder.ToString();
            return output;
        }
    }
}
