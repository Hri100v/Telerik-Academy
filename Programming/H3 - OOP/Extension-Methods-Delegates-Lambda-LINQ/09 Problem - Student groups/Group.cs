
/*Problem 16.* Groups

Create a class Group with properties GroupNumber and DepartmentName.
Introduce a property GroupNumber in the Student class.
Extract all students from "Mathematics" department.
Use the Join operator.
 */

namespace _09_Problem___Student_groups
{
    using System;
    class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set 
            {
                if (value <= 0 )
                {
                    throw new ArgumentNullException("This is imposible group.");
                }
                this.groupNumber = value; 
            }
        }
        
        public string DepartmentName
        {
            get { return departmentName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Department! Can not be null or empty !");
                }
                departmentName = value; 
            }
        }

    }
}
