using Unity.Entities;

[GenerateAuthoringComponent]
public struct ProjectilePoolPropertiesComponent : IComponentData
{
    public int PoolAmount;
    public Entity projectilePrefab;
}
