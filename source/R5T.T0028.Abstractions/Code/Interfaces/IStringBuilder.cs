using System;


namespace R5T.T0028
{
    public interface IStringBuilder
    {
        // Useful for inserting/removing at positions relative to the *end* of the string, without needing to build the string just to do so.
        int Length { get; }

        IStringBuilder Append(string value);
        IStringBuilder Insert(int index, string value);
        IStringBuilder Remove(int index, int length);
        IStringBuilder Replace(string oldValue, string newValue);
    }
}
