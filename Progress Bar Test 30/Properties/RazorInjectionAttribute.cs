// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ RazorInjectionAttribute.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Properties
{
    using System;

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class RazorInjectionAttribute : Attribute
    {
        #region Constructors (All)

        public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
        {
            this.Type      = type;
            this.FieldName = fieldName;
        }

        #endregion

        #region Properties (Non-Private)

        [NotNull]
        public string FieldName { get; }

        [NotNull]
        public string Type { get; }

        #endregion
    }
}