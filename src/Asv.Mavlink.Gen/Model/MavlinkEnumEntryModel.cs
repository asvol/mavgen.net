using System.Collections.Generic;

namespace Asv.Mavlink.Gen
{
    public class MavlinkEnumEntryModel: MavlinkModelBase
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public IList<MavlinkEnumEntryParamModel> Params { get; } = new List<MavlinkEnumEntryParamModel>();
    }
}