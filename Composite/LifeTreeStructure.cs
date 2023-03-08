namespace DeginPaterrn.Composite
{
    public class LifeTreeStructure : LifeTree
    {
        private readonly LifeTreeStructureDto _treeStructureDto;

        public LifeTreeStructure
        (
            LifeTreeStructureDto treeStructureDto
        ) : base(treeStructureDto)
        {
            _treeStructureDto = treeStructureDto;
        }

        public override void DisplayTree(int deepNumber)
        {
            Console.WriteLine(new string('-', deepNumber) + _treeStructureDto.Name);
        }
    }
}
