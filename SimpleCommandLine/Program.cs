using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityComponentSystem;

namespace SimpleCommandLine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var systemsCollection = new SystemsCollection();
            systemsCollection.Add(new MoveSystem());

            var world = new World();
            var player = new Entity();
            player.AddComponent(new PositionComponent());
            world.AddEntity(player);

            while (true)
            {
                systemsCollection.Update(world, 0);
            }
        }
    }
}
