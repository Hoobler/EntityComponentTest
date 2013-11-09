using System;
using System.Collections.Generic;

namespace EntityComponentSystem
{
    public interface ISystem
    {
        void Update(IEnumerable<IEntity> affectedEntities, double deltaTime);
        List<Type> RequiredComponents { get; set; }
    }
}