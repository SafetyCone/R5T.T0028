using System;


namespace R5T.T0028
{
    public class TokenSeparator
    {
        public const string Default = Strings.Space;


        public static TokenSeparator Instance { get; } = new();
    }
}
