using Unity.Transforms;
using Unity.Entities;
using Unity.Mathematics;
public partial class MoveSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities
            .WithAll<MoveTag>()
            .ForEach((ref Translation position, in VelocityPropertiesComponent velocity) =>
            {
                float3 displacement = velocity.Direction * velocity.Speed * deltaTime;
                position.Value += displacement;

            }).ScheduleParallel();
    }
}
