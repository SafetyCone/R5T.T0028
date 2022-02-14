using System;

using R5T.Magyar;


namespace R5T.T0028
{
    public class TokenSeparator
    {
        public const string Default = Strings.Space_Const;


        public static TokenSeparator Instance { get; } = new();
    }
}
