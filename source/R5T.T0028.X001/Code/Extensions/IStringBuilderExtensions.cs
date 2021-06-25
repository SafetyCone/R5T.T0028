using System;


namespace R5T.T0028.X001
{
    public static class IStringBuilderExtensions
    {
        public static TStringBuilder If<TStringBuilder>(this TStringBuilder stringBuilder, bool predicate, Action action)
            where TStringBuilder : IStringBuilder
        {
            if (predicate)
            {
                action();
            }

            return stringBuilder;
        }

        public static TStringBuilder With<TStringBuilder>(this TStringBuilder stringBuilder, Action<TStringBuilder> action)
        {
            action(stringBuilder);

            return stringBuilder;
        }

        public static TStringBuilder AppendToken<TStringBuilder>(this TStringBuilder stringBuilder,
            string token, string tokenSeparator = TokenSeparator.Default)
            where TStringBuilder : IStringBuilder
        {
            var suffixedToken = $"{token}{tokenSeparator}";

            stringBuilder.Append(suffixedToken);

            return stringBuilder;
        }

        public static TStringBuilder AppendTokenQuoted<TStringBuilder>(this TStringBuilder stringBuilder,
            string token, string tokenSeparator = TokenSeparator.Default)
            where TStringBuilder : IStringBuilder
        {
            var quotedToken = $"\"{token}\"";

            return stringBuilder.AppendToken(quotedToken, tokenSeparator);
        }

        public static TStringBuilder AppendFilePathToken<TStringBuilder>(this TStringBuilder stringBuilder,
            string filePath, string tokenSeparator = TokenSeparator.Default)
            where TStringBuilder : IStringBuilder
        {
            return stringBuilder.AppendTokenQuoted(filePath, tokenSeparator);
        }

        public static TStringBuilder AppendTokenIf<TStringBuilder>(this TStringBuilder stringBuilder, bool actuallyAppend,
            string token, string tokenSeparator = TokenSeparator.Default)
            where TStringBuilder : IStringBuilder
        {
            return stringBuilder.If(actuallyAppend, () => stringBuilder.AppendToken(token, tokenSeparator));
        }

        public static TStringBuilder AppendNameValuePair<TStringBuilder>(this TStringBuilder stringBuilder,
            string name, string value, string pairTokenSeparator = TokenSeparator.Default, string tokenSeparator = TokenSeparator.Default)
            where TStringBuilder : IStringBuilder
        {
            var token = $"{name}{pairTokenSeparator}{value}";

            return stringBuilder.AppendToken(token, tokenSeparator);
        }

        public static TStringBuilder AppendNameValuePairIf<TStringBuilder>(this TStringBuilder stringBuilder, bool actullayAppend,
            string name, string value, string pairTokenSeparator = TokenSeparator.Default, string tokenSeparator = TokenSeparator.Default)
            where TStringBuilder : IStringBuilder
        {
            return stringBuilder.If(actullayAppend, () => stringBuilder.AppendNameValuePair(name, value, pairTokenSeparator, tokenSeparator));
        }
    }
}
