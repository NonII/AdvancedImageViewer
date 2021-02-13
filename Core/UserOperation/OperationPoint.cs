using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedImageViewer.Core {
    public class OperationPoint {
        public CartesianCoordinate<double> VisualWorkspaceCoordinate { get; set; }
        public CartesianCoordinate<int> LayerCoordinate { get; set; }
        public CartesianCoordinate<int> BitmapCoordinate { get; set; }
        
    }
}
