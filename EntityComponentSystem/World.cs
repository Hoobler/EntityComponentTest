using System.Collections.Generic;

namespace EntityComponentSystem
{
    public class World : IWorld
    {
        private List<IEntity> _entities;

        public World()
        {
            _entities = new List<IEntity>();
        }

        public void AddEntity(IEntity entity)
        {
            _entities.Add(entity);
        }

        public List<IEntity> GetEntities()
        {
            return _entities;
        }
    }
}