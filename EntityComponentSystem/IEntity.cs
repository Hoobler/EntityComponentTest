using System.Collections;
using System.Collections.Generic;

namespace EntityComponentSystem
{
    public interface IEntity
    {
        List<IComponent> Components { get; set; }

        void AddComponent(IComponent component);
        void RemoveComponent(IComponent component);
    }
}