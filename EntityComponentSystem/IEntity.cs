using System.Collections;

namespace EntityComponentSystem
{
    public interface IEntity
    {
        IEnumerable Components { get; set; }

        void AddComponent(IComponent component);
        void RemoveComponent(IComponent component);
    }
}