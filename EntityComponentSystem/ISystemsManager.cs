using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityComponentSystem
{
    public interface ISystemsManager
    {
        void Update(double deltaTime);
    }
}
