using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityComponentSystem
{
    public class SystemsCollection : ISystemsCollection
    {
        private readonly List<ISystem> _systems;

        public SystemsCollection()
        {
            _systems = new List<ISystem>();
        }

        public void Update(World world, double deltaTime)
        {
            foreach (var system in _systems)
            {
                var worldEntities = world.GetEntities();
                var requiredComponents = system.RequiredComponents;

                var entitiesWithCorrectComponents = worldEntities
                    .Where(entity => EntityHasAllComponents(requiredComponents, entity))
                    .ToList();

                system.Update(entitiesWithCorrectComponents, deltaTime);
            }
        }

        private bool EntityHasAllComponents(List<Type> requiredComponents, IEntity entity)
        {
            return !requiredComponents
                .Except(entity.Components
                        .Select(entityComponent => entityComponent.GetType()))
                        .Any();
        }

        public void Add(ISystem system)
        {
            _systems.Add(system);
        }
    }
}