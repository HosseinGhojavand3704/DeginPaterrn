namespace DeginPaterrn.Composite
{
    public abstract class TreeStructure
    {

        protected int _id { get; set; }
        protected string _name { get; set; }
        protected string _description { get; set; }
        protected IList<TreeStructure> _childern { get; set; }

        public TreeStructure
        (
            TreeStructureDto treeStructureDto
        ) {
            _id = treeStructureDto.Id;
            _name = treeStructureDto.Name;
            _description = treeStructureDto.Description;
            
            if (treeStructureDto.Children != null)
                _childern = treeStructureDto.Children;
            else
                _childern = new List<TreeStructure>();
        }

        public abstract void DisplayTree(int deepNumber);
    }

    public abstract class CompositeTree : TreeStructure
    {
        protected CompositeTree
        (
            CompositeTreeStructureDto compositeTreeStructureDto
        ) : base(new TreeStructureDto()
        {
            Id = compositeTreeStructureDto.Id,
            Name = compositeTreeStructureDto.Name,
            Description = compositeTreeStructureDto.Description,
            Children = compositeTreeStructureDto.Children
        })
        {
            _id = compositeTreeStructureDto.Id;
            _name = compositeTreeStructureDto.Name;
            _description = compositeTreeStructureDto.Description;

            if (compositeTreeStructureDto.Children != null)
                _childern = compositeTreeStructureDto.Children;
            else
                _childern = new List<TreeStructure>();
        }

        public abstract void AddTree(TreeStructure tree);
        public abstract void RemoveTree(TreeStructure tree);
    }

    public abstract class LifeTree : TreeStructure
    {
        protected LifeTree
        (
            LifeTreeStructureDto lifeTreeStructureDto
        ) : base(new TreeStructureDto()
        {
            Id = lifeTreeStructureDto.Id,
            Name = lifeTreeStructureDto.Name,
            Description = lifeTreeStructureDto.Description
        })
        {
        }
    }
}
