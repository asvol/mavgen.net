using System.Collections.Generic;
using System.IO;
using System.Xml;


namespace Asv.Mavlink.Gen
{
    public class MavlinkGenerator
    {
        public static MavlinkProtocolModel ParseXml(string fileName, Stream strm)
        {
            return new MavlinkParserXml().Parse(fileName,strm);
        }
    }
}
