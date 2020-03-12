namespace Implementation.Models
{
    public class Department
    {
        //auto-implemented or automatic properties (C# 3.0 -2007)
        public int DepartmentId { set; get; }
        public string DepartmentName { get; set; }
        public Department()
        {

        }
        public Department(int id, string name)
        {
            DepartmentId = id;
            DepartmentName = name;
        }
        public override string ToString()
        {
            return $"Id:{DepartmentId}, Name: {DepartmentName}";
        }
        public override int GetHashCode()
        {
            return DepartmentId.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Department)
                {
                    Department other = obj as Department;
                    
                    if (this == other)
                        return true;
                    
                    if (!this.DepartmentId.Equals(other.DepartmentId))
                        return false;
                    
                    if (!this.DepartmentName.Equals(other.DepartmentName))
                        return false;

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
