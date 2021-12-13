using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class DepartmentModel
    {
        /// <summary>
        /// type "/" 3x to create this cool text box
        /// </summary>
        public String Department_Name { get; set; }

        public List<BulkModel> Inventory { get; set; }

        public List<EmployeeModel> Employees { get; set; }
    }
}
