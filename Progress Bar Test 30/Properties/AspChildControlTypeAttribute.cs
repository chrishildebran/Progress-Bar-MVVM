// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ AspChildControlTypeAttribute.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Properties
{
    using System;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class AspChildControlTypeAttribute : Attribute
    {
        #region Constructors (All)

        public AspChildControlTypeAttribute([NotNull] string tagName, [NotNull] Type controlType)
        {
            this.TagName     = tagName;
            this.ControlType = controlType;
        }

        #endregion

        #region Properties (Non-Private)

        [NotNull]
        public Type ControlType { get; }

        [NotNull]
        public string TagName { get; }

        #endregion
    }
}