using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public enum OffHandType
    {
        Source,
        Shield,
        Quiver,
        Mojo
    }

    public class OffHand : Item
    {
        public OffHandType Type { get; protected set; }

        public OffHand() : base(ItemSlot.OffHand) { }

        public override string ToString()
        {
            return "Off-Hand: " + this.Name;
        }
    }
}
