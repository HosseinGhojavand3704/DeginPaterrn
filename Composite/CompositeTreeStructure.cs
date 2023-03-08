namespace DeginPaterrn.Composite
{
    public class CompositeTreeStructure : CompositeTree
    {
        private readonly CompositeTreeStructureDto _treeStructureDto;
        private readonly List<TreeStructure> _treeStructures;

        public CompositeTreeStructure
        (
            CompositeTreeStructureDto treeStructureDto
        ) : base(treeStructureDto) {
            _treeStructureDto = treeStructureDto;
            _treeStructures = new List<TreeStructure>();

            if (treeStructureDto.Children != null)
                AddChildrenTree(treeStructureDto.Children);
        }

        private void AddChildrenTree(IList<TreeStructure> trees)
        {
            foreach(var tree in trees)
                _treeStructures.Add(tree);
        }

        public override void AddTree(TreeStructure tree)
        {
            _treeStructures.Add(tree);
        }

        public override void DisplayTree(int deepNumber)
        {
            Console.WriteLine(new string('-', deepNumber) + _treeStructureDto.Name);
            foreach (TreeStructure treeStructure in _treeStructures)
            {
                treeStructure.DisplayTree(deepNumber + 2);
            }
        }

        public override void RemoveTree(TreeStructure tree)
        {
            _treeStructures.Remove(tree);
        }
    }
}
