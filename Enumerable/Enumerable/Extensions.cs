namespace Enumerable;

public static class Extensions
{
    public static Dictionary<int, List<Entity>> GroupByParentId(this List<Entity> entitiesList)
    {
        return entitiesList
            .GroupBy(entity => entity.ParentId)
            .ToDictionary(x => x.Key, x => x.ToList());
    }
}