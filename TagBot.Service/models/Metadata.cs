using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TagBot.Service.models
{
    public class Metadata
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Tracknumber { get; set; }
        public string Comment { get; set; }

        public object this[string name]
        {
            get
            {
                var properties = typeof(Metadata).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var property in properties)
                {
                    if (property.Name == name && property.CanRead)
                    {
                        return property.GetValue(this, null);
                    }
                }

                throw new ArgumentException("Can't find property");
            }
            set
            {
                try
                {
                    var properties = typeof(Metadata).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    foreach (var property in properties)
                    {
                        if (property.Name == name && property.CanRead)
                        {
                            property.SetValue(this, value.ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                
                return;
            }
        }
    }
}
