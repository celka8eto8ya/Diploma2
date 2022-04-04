using System;

namespace Onion.AppCore.Entities
{
    public class DepartmentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Functions { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
