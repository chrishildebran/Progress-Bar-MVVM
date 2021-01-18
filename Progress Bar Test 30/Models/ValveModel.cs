// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ ValveModel.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Models
{
    internal class ValveModel
    {
        #region Constructors (All)

        public ValveModel(string model)
        {
            this.Model = model;
        }

        #endregion

        #region Properties (Non-Private)

        public string Model { get; set; }

        #endregion
    }
}