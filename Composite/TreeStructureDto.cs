namespace DeginPaterrn.Composite
{
    public class TreeStructureDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IList<TreeStructure>? Children { get; set; } = new List<TreeStructure>();
    }

    public class CompositeTreeStructureDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IList<TreeStructure>? Children { get; set; }
    }

    public class LifeTreeStructureDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
