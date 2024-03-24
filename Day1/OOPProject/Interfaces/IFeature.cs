using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Interfaces
{
    public interface IFeature
    {
        void Read(string name);
        void Listen(string name);
        void Write(string name);
    }
}
