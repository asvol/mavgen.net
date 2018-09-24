using System.Collections.Generic;

namespace Asv.Mavlink.Gen
{
    public class MessageFieldModel: MavlinkModelBase
    {
        public MessageFieldType Type { get; set; }
        public int FieldTypeByteSize { get; set; }
        public int FieldByteSize => IsArray ? FieldTypeByteSize * ArrayLength : FieldTypeByteSize;
        public string Name { get; set; }
        public string Units { get; set; }
        public byte ArrayLength { get; set; }
        public bool IsArray { get; set; }
        public bool IsExtended { get; set; }
        public string TypeName { get; set; }
        public string Enum { get; set; }
    }
}