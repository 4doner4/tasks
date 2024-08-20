using TestProject;

for (int i = 1; i < 6; i++)
{
    new BusyMethod(i);
    Console.WriteLine();
}

List<Root> roots = new();
List<Hierarchy> hierarchy = new();

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
roots.ForEach(root =>
{
    Console.WriteLine("name: " + root.Name + " id: " + root.Id + " parent: " + root.ParentId);
});

int?[] parents_ids = roots.Select(root =>
{
    if (root.ParentId != null)
        return root.ParentId;
    return null;
}).Where(root => root != null).ToArray();

Console.WriteLine(String.Join(", ", parents_ids));

foreach (int item in parents_ids)
{
    Hierarchy tmp = new();
    tmp.ShowHierarchy(item, roots);
    hierarchy.Add(tmp);
}

hierarchy.ForEach(root =>
{
    Console.WriteLine("root.Id: " + root.Id + " childrens: " + String.Join("\n", root.Childrens.Select(x => x.Id + x.Name)));
});
