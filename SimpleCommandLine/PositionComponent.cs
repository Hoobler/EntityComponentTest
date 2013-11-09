using EntityComponentSystem;

namespace SimpleCommandLine
{
    public class PositionComponent : IComponent
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}