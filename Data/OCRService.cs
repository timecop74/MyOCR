using Aspose.OCR;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace MyOCR.Data
{
    public class OCRService
    {
        private AsposeOcr ac = new AsposeOcr();
        private MemoryStream ms = new MemoryStream();

        public async Task<List<Rectangle>> GetRectAsync(IBrowserFile file)
        {
            ms.Close();
            ms = new MemoryStream();
            var t = file.OpenReadStream(file.Size);
            await t.CopyToAsync(ms);
            List<Rectangle> rects = ac.GetRectangles(ms);
            return rects;
        }

        public async Task<List<string>> Recognize(List<Rectangle> areas)
        {
            return ac.RecognizeImage(ms, areas);
        }
    }
}
