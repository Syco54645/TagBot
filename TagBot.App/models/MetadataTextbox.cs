using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagBot.App.models
{
    public class MetadataTextBox
    {
        public string FieldInMetadata { get; set; }
        public string MutuallyExclusiveField { get; set; } = null;
        public MetadataTextboxType MetadataTextboxType { get; set; }
    }
    public enum MetadataTextboxType
    {
        Single,
        Overall
    }
}
