﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CLEM
{
    /// <summary>
    /// Crop data reader interface
    /// </summary>
    public interface IFileCrop
    {
        /// <summary>
        /// Searches the DataTable created from the Forage File using the specified parameters.
        /// <returns></returns>
        /// </summary>
        /// <param name="soilID"></param>
        /// <param name="cropName"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>A struct called CropDataType containing the crop data for this month.
        /// This struct can be null. 
        /// </returns>
        List<CropDataType> GetCropDataForEntireRun(string soilID, string cropName,
                                        DateTime startDate, DateTime endDate);

    }
}
