using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubic_World
{
    class Block
    {
        float[] fVertices = {0, 0, 0,
                             1, 0, 0,
                             1, 1, 0,
                             0, 1, 0,
                             0, 1, 1,
                             1, 1, 1,
                             1, 0, 1,
                             0, 0, 1 };
        public float[] block_vertices()
        {
            return fVertices;
        }
    }
}
