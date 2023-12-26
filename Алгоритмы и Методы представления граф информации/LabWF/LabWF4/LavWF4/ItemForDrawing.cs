using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavWF4
{

    public class ItemForDrawing
    {
        public enum TypeOfObject : int
        { Point = 0, Line = 1, Rectangle = 2, Ellipse = 3, String = 4 }
        public Point start_coord { get; set; }
        public Point end_coord { get; set; }
        public Size size { get; set; }
        public String text { get; set; }
        public int typeOfObject { get; set; }
        public ItemForDrawing(Point coord)
        {
            start_coord = coord;
            this.typeOfObject = (int)TypeOfObject.Point;
        }
        public ItemForDrawing(int typeOfObject, Point coord, Size size)
        {
            this.start_coord = coord;
            this.size = size;
            this.typeOfObject = typeOfObject;
        }
        public ItemForDrawing(Point start_coord, Point end_coord)
        {
            this.start_coord = start_coord;
            this.end_coord = end_coord;
            this.typeOfObject = (int)TypeOfObject.Line;
        }
        public ItemForDrawing(Point start_coord, String text)
        {
            this.start_coord = start_coord;
            this.text = text;
            this.typeOfObject = (int)TypeOfObject.String;
        }
    }
    
}
