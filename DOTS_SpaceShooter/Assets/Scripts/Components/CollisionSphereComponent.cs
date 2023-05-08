using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct CollisionSphereComponent : IComponentData
{
    public float Radius;
    public float3 Position;
}
