using System.Collections.Generic;
using EntityComponentSystem;

namespace SimpleCommandLine
{
    public class Entity : IEntity
    {
        public List<IComponent> Components { get; set; }

        public void AddComponent(IComponent component)
        {
            Components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            Components.Remove(component);
        }
    }
}