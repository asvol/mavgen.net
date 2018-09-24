namespace Asv.Mavlink.Gen
{
    public interface IMavlinkGenerator
    {
        string Generate(string template, MavlinkProtocolModel model);
    }
}