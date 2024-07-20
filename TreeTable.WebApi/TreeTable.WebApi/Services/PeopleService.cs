namespace TreeTable.WebApi.Services
{
    public interface INodeTypes
    {
        public const string NodeTag = "Tag";
        public const string NodeTagLabel = "Label";
        public const string Data = "Data";

    }

    public class Stats
    {
        public double Value { get; set; }
    }

    public class Tree
    {
        public List<Node> Roots { get; set; } = new List<Node>();
    }

    public class Node
    {
        public string NodeType { get; set; } // Tag, Tag:Label,Tag, Tag:Label , Data (component)

        public string Description { get; set; }

        public List<Stats> Stats { get; set; } = new List<Stats>();

        public List<Node> Children { get; set; } = new List<Node>();    
    }

    public interface IPeopleService
    {
        Task<Tree> CreateFakePeopleTree();

    }

    public class PeopleService : IPeopleService
    {
        public PeopleService()
        {

        }

        public async Task<Tree> CreateFakePeopleTree()
        {
            var regionTag = GetRegionTag();
            var color = GetColorTag();

            var tree = new Tree();
            tree.Roots.Add(regionTag);
            tree.Roots.Add(color);



            return tree;
        }



        private Node GetColorTag()
        {
            var tag = new Node { NodeType = INodeTypes.NodeTag };
            var tagLabel = new Node { NodeType = INodeTypes.NodeTagLabel };
            var nahariyaData = new Node { NodeType = INodeTypes.Data };
            //var akkoData = new Node { NodeType = INodeTypes.Data };


            tag.Description = "color";
            tag.Children.Add(tagLabel);

            tagLabel.Description = "red";
            tagLabel.Children.Add(nahariyaData);
            //tagLabel.Children.Add(akkoData);

            nahariyaData.Description = "Nahariya";
            nahariyaData.Stats.Add(new Stats { Value = 1 });
            nahariyaData.Stats.Add(new Stats { Value = 2 });
            nahariyaData.Stats.Add(new Stats { Value = 3 });


            //akkoData.Description = "Akko";
            //akkoData.Stats.Add(new Stats { Value = 3 });
            //akkoData.Stats.Add(new Stats { Value = 4 });
            //akkoData.Stats.Add(new Stats { Value = 5 });


            return tag;
        }

        private Node GetRegionTag()
        {
            var tag = new Node { NodeType = INodeTypes.NodeTag };
            var tagLabel = new Node { NodeType = INodeTypes.NodeTagLabel };
            var nahariyaData = new Node { NodeType = INodeTypes.Data };
            var akkoData = new Node { NodeType = INodeTypes.Data };


            tag.Description = "region";
            tag.Children.Add(tagLabel);

            tagLabel.Description = "North";
            tagLabel.Children.Add(nahariyaData);
            tagLabel.Children.Add(akkoData);

            nahariyaData.Description = "Nahariya";
            nahariyaData.Stats.Add(new Stats { Value = 1 });
            nahariyaData.Stats.Add(new Stats { Value = 2 });
            nahariyaData.Stats.Add(new Stats { Value = 3 });


            akkoData.Description = "Akko";
            akkoData.Stats.Add(new Stats { Value = 3 });
            akkoData.Stats.Add(new Stats { Value = 4 });
            akkoData.Stats.Add(new Stats { Value = 5 });


            return tag;
        }
    }
}