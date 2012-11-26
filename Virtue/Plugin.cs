using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Virtue
{
    public abstract class Plugin
    {
        public abstract void Load(XElement configuration);
    }
}
