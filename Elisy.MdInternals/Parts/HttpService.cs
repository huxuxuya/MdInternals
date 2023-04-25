using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Elisy.MdInternals.Cf;

namespace Elisy.MdInternals
{
    [Guid("0fffc09c-8f4c-47cc-b41c-8d5c5a221d79")]
    public class HttpService : MetadataPart
    {
        public HttpService()
            : base()
        {
        }


        public HttpService(ImageRow imageRow)
            : base(imageRow)
        {
        }
    }
}
