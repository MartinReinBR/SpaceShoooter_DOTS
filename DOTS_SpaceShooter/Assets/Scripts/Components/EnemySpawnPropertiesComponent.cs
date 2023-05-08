using Unity.Entities;

[GenerateAuthoringComponent]
public struct EnemySpawnPropertiesComponent : IComponentData
{
    public Entity EnemyPrefab;
    public int NumberOfEnemies;
    public float spawnRadiusXY;
    public float spawnRadiusZMin;
    public float spawnRadiusZMax;
    public float minSpeed;
    public float maxSpeed;
}
