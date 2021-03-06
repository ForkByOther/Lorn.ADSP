//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorn.ADSP.AM.DataModels
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// ThirdMonitorCode
    /// </summary>
    public partial class ThirdMonitorCode
    {
        public ThirdMonitorCode()
        {
            this.AdSpotPlanThirdMonitorCodes = new HashSet<AdSpotPlanThirdMonitorCode>();
        }
    
        /// <summary>
        /// ThirdMonitorCodeId
        /// </summary>
        public System.Guid ThirdMonitorCodeId { get; set; }
        /// <summary>
        /// MediaId
        /// </summary>
        public System.Guid MediaId { get; set; }
        /// <summary>
        /// AdMasterPlanId
        /// </summary>
        public Nullable<System.Guid> AdMasterPlanId { get; set; }
        /// <summary>
        /// MonitorCode
        /// </summary>
        public string MonitorCode { get; set; }
        /// <summary>
        /// Remark
        /// </summary>
        public string Remark { get; set; }
    
         /// <summary>
        /// MonitorType
        /// </summary>
        public virtual MonitorType MonitorType { get; set; }
         /// <summary>
        /// AdSpotPlanThirdMonitorCodes
        /// </summary>
        public virtual ICollection<AdSpotPlanThirdMonitorCode> AdSpotPlanThirdMonitorCodes { get; set; }
         /// <summary>
        /// ThirdMonitorMode
        /// </summary>
        public virtual ThirdMonitorMode ThirdMonitorMode { get; set; }
         /// <summary>
        /// ThirdMonitorCompany
        /// </summary>
        public virtual ThirdMonitorCompany ThirdMonitorCompany { get; set; }
    }
}
