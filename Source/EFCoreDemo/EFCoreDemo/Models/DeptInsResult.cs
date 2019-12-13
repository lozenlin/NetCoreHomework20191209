using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class DeptInsResult
    {
        public int DepartmentId { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
