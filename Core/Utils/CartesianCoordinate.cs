using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedImageViewer.Core {
    public struct CartesianCoordinate<T> where T : struct {
        public T X { get; set; }
        public T Y { get; set; }
    }
}
