//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace wlhx.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Experiment
    {
        public Experiment()
        {
            this.Chooses = new HashSet<Choos>();
            this.ExperimentTimes = new HashSet<ExperimentTime>();
        }
    
        public long experiment_id { get; set; }
        public string experiment_title { get; set; }
        public int experiment_class { get; set; }
        public int experiment_peopleNum { get; set; }
        public bool experiment_isDel { get; set; }
        public string experiment_allowGrades { get; set; }
        public string experiment_week { get; set; }
    
        public virtual ICollection<Choos> Chooses { get; set; }
        public virtual ICollection<ExperimentTime> ExperimentTimes { get; set; }
    }
}
