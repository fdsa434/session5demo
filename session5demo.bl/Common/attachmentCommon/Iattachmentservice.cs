using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.bl.Common.attachmentCommon
{
    public interface Iattachmentservice
    {
        public string addattachment(IFormFile file, string folder);
        public bool delete( string filepath);


    }
}
