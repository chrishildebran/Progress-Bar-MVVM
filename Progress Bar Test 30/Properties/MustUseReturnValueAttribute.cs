﻿// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ MustUseReturnValueAttribute.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Properties
{
    using System;

    /// <summary>
    ///     Indicates that the return value of the method invocation must be used.
    /// </summary>
    /// <remarks>
    ///     Methods decorated with this attribute (in contrast to pure methods) might change state,
    ///     but make no sense without using their return value. <br />
    ///     Similarly to <see cref="PureAttribute" />, this attribute
    ///     will help detecting usages of the method when the return value in not used.
    ///     Additionally, you can optionally specify a custom message, which will be used when showing warnings, e.g.
    ///     <code>[MustUseReturnValue("Use the return value to...")]</code>.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class MustUseReturnValueAttribute : Attribute
    {
        #region Constructors (All)

        public MustUseReturnValueAttribute()
        {
        }

        public MustUseReturnValueAttribute([NotNull] string justification)
        {
            this.Justification = justification;
        }

        #endregion

        #region Properties (Non-Private)

        [CanBeNull]
        public string Justification { get; }

        #endregion
    }
}