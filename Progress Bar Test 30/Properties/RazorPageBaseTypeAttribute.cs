// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ RazorPageBaseTypeAttribute.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Properties
{
    using System;

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class RazorPageBaseTypeAttribute : Attribute
    {
        #region Constructors (All)

        public RazorPageBaseTypeAttribute([NotNull] string baseType)
        {
            this.BaseType = baseType;
        }

        public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
        {
            this.BaseType = baseType;
            this.PageName = pageName;
        }

        #endregion

        #region Properties (Non-Private)

        [NotNull]
        public string BaseType { get; }

        [CanBeNull]
        public string PageName { get; }

        #endregion
    }
}