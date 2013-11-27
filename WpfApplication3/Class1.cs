using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3
{
    enum Dimension{ dim2 = "2D", dim3 = "3D" };

    class CImage
    {
        private String name { get; set; }
        private Int32 imageType { get; set; }
        private Dimension imageDimension { get; set; }
        private int height { get; set; }
        private int width { get; set; }
        private int depth { get; set; }
        private int size { get; set; }
        private Pixel[] pixels { get; set; }
        private int[] histogramme { get; set; }

        public CImage()
        {
            this.name = "";
            this.imageType = 0;
            this.imageDimension = Dimension.dim2;
            this.height = 0;
            this.width = 0;
            this.depth = 0;
            this.size = 0;
            this.histogramme = new int[256];
            
        }
        
        public CImage(String name, Int32 imagetype, Dimension imageDimension)
        {
            this.name = name;
            this.imageType = imageType;
            this.imageDimension = imageDimension;
        }



    }
}
