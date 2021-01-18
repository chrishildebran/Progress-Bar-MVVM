// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ MeansImplicitUseAttribute.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Properties
{
    using System;

    /// <summary>
    ///     Can be applied to attributes, type parameters, and parameters of a type assignable from <see cref="System.Type" />
    ///     .
    ///     When applied to an attribute, the decorated attribute behaves the same as <see cref="UsedImplicitlyAttribute" />.
    ///     When applied to a type parameter or to a parameter of type <see cref="System.Type" />,  indicates that the
    ///     corresponding type
    ///     is used implicitly.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter | AttributeTargets.Parameter)]
    public sealed class MeansImplicitUseAttribute : Attribute
    {
        #region Constructors (All)

        public MeansImplicitUseAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
        {
        }

        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags) : this(useKindFlags, ImplicitUseTargetFlags.Default)
        {
        }

        public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags) : this(ImplicitUseKindFlags.Default, targetFlags)
        {
        }

        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
        {
            this.UseKindFlags = useKindFlags;
            this.TargetFlags  = targetFlags;
        }

        #endregion

        #region Properties (Non-Private)

        [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags { get; }

        [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags { get; }

        #endregion
    }
}