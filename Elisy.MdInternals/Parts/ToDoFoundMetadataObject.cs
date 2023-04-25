using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Elisy.MdInternals.Cf;

namespace Elisy.MdInternals
{
    [Guid("6e6dc072-b7ac-41e7-8f88-278d25b6da2a")]
    public class ToDoFoundMetadataObject : MetadataPart
    {
        public ToDoFoundMetadataObject()
            : base()
        {
        }


        public ToDoFoundMetadataObject(ImageRow imageRow)
            : base(imageRow)
        {
        }
    }
}
