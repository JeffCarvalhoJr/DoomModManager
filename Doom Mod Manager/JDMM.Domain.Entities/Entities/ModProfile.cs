using System.Collections.Generic;

namespace JDMM.Domain.Entities
{
    public class ModProfile
    {
        public string Name { get; set; }
        public IList<ModFile> ModList { get; set; }
        public IList<ModFile> ModLoadOrder { get; set; }
        public ModFile DoomEngine { get; set; }
    }
}
