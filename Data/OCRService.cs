using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Aspose.OCR;
using System.IO;

namespace MyOCR.Data
{
    public class OCRService
    {

        public async Task<List<Rectangle>> GetRectAsync(IBrowserFile file)
        {
            AsposeOcr ac = new AsposeOcr();
            MemoryStream ms = new MemoryStream();
            var t = file.OpenReadStream(file.Size);
            await t.CopyToAsync(ms);
            List<Rectangle> rects = ac.GetRectangles(ms);
            return rects;
        }
    }
}
