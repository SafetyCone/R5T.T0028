using System;

using SystemStringBuilder = System.Text.StringBuilder;


namespace R5T.T0028
{
    public class StringBuilder : IStringBuilder
    {
        #region Static

        public static StringBuilder New()
        {
            return new StringBuilder();
        }

        #endregion


        public int Length => this.StringBuilder_Internal.Length;

        protected SystemStringBuilder StringBuilder_Internal { get; }


        public StringBuilder()
        {
            this.StringBuilder_Internal = new SystemStringBuilder();
        }

        public IStringBuilder Append(string value)
        {
            this.StringBuilder_Internal.Append(value);

            return this;
        }

        public IStringBuilder Insert(int index, string value)
        {
            this.StringBuilder_Internal.Insert(index, value);

            return this;
        }

        public IStringBuilder Remove(int index, int length)
        {
            this.StringBuilder_Internal.Remove(index, length);

            return this;
        }

        public IStringBuilder Replace(string oldValue, string newValue)
        {
            this.StringBuilder_Internal.Replace(oldValue, newValue);

            return this;
        }

        public override string ToString()
        {
            return this.StringBuilder_Internal.ToString();
        }
    }
}
