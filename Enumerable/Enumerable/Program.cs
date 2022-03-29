using Enumerable;


var entitiesList = new List<Entity>
{
    new(1, 0, "Root entity"),
    new(2, 1, "Child of 1 entity"),
    new(3, 1, "Child of 1 entity"),
    new(4, 2, "Child of 2 entity"),
    new(5, 4, "Child of 4 entity")
};

var groupingByParentDictionary = entitiesList.GroupByParentId();

foreach (var (parentId, groupingEntities) in groupingByParentDictionary)
{
    Console.WriteLine($"Key = {parentId}\tValue = List {string.Join(' ', groupingEntities)}");
}