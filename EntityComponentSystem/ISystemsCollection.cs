using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityComponentSystem
{
    public interface ISystemsCollection
    {
        void Update(World world, double deltaTime);
    }
}
