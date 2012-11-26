using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Virtue
{
    public class Configuration
    {
        public Configuration()
        {
            // TODO: Some default values in here
        }

        public static Configuration Load(string file)
        {
            // TODO
            return null;
        }

        public void Save(string file)
        {
            // TODO
        }

        public string GitHubUsername { get; set; }
        // We want to keep this information away from plugins
        internal string GitHubPassword { get; set; }
    }
}
