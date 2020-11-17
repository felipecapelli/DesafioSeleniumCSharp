using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Felipe.Desafio.AnalistaDeTestes.Tests.Helpers
{
    class TestHelper
    {
        public static string PastaDoExecutavel => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}
