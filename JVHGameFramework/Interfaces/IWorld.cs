using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Interfaces
{
    public interface IWorld
    {
        void UpdateState();
        bool Nearby();

    }
}
