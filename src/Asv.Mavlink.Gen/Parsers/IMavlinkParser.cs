using System.IO;


namespace Asv.Mavlink.Gen
{
    public interface IMavlinkParser
    {
        MavlinkProtocolModel Parse(string fileName, Stream data);
    }
}
