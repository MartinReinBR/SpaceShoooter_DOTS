using Unity.Entities;
using UnityEngine;

[GenerateAuthoringComponent]
public struct VelocityPropertiesComponent : IComponentData
{
    public Vector3 Direction;
    public float Speed;
}
