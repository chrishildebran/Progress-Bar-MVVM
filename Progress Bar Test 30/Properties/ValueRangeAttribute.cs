// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ ValueRangeAttribute.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Properties
{
    using System;

    /// <summary>
    ///     Indicates that the integral value falls into the specified interval.
    ///     It's allowed to specify multiple non-intersecting intervals.
    ///     Values of interval boundaries are inclusive.
    /// </summary>
    /// <example>
    ///     <code>
    /// void Foo([ValueRange(0, 100)] int value) {
    ///   if (value == -1) { // Warning: Expression is always 'false'
    ///     ...
    ///   }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Delegate, AllowMultiple = true)]
    public sealed class ValueRangeAttribute : Attribute
    {
        #region Constructors (All)

        public ValueRangeAttribute(long from, long to)
        {
            this.From = from;
            this.To   = to;
        }

        public ValueRangeAttribute(ulong from, ulong to)
        {
            this.From = from;
            this.To   = to;
        }

        public ValueRangeAttribute(long value)
        {
            this.From = this.To = value;
        }

        public ValueRangeAttribute(ulong value)
        {
            this.From = this.To = value;
        }

        #endregion

        #region Properties (Non-Private)

        public object From { get; }

        public object To { get; }

        #endregion
    }
}