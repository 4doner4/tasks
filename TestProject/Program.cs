using System.Globalization;
using TestProject;

LinkedListHierarchy<Root> roots = new();

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    Root root = new();
    root.Name = "TestRoot" + i;
    if (random.Next(0, 10) > 2)
        root.ParentId = random.Next(0, 5);
    root.Id = random.Next(0, 5);
    roots.Add(root);
}


foreach (Root node in roots) {
    Console.WriteLine("name: " + node.Name + " id: " + node.Id + " parent: " + node.ParentId);
}