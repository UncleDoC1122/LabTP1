using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1TP
{
    interface InterfaceMove
    {
        void moveTo(int x, int y);

        int getX();
        int getY();
    }
}
