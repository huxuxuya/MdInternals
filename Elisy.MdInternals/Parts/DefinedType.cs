using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Elisy.MdInternals.Cf;

namespace Elisy.MdInternals
{
    [Guid("c045099e-13b9-4fb6-9d50-fca00202971e")]
    public class DefinedType : MetadataPart
    {
        public DefinedType()
            : base()
        {
        }


        public DefinedType(ImageRow imageRow)
            : base(imageRow)
        {
        }
    }
}
