using System;
using System.Collections.Generic;
using EntityComponentSystem;

namespace SimpleCommandLine
{
    public class MoveSystem : ISystem
    {
        public List<Type> RequiredComponents { get; set; }

        public void Update(IEnumerable<IEntity> affectedEntities, double deltaTime)
        {
            throw new NotImplementedException();
        }
    }
}