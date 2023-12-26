using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Square
        {
            public double _x0, _y0, _len, _x1, _x2, _x3, _x4, _y1, _y2, _y3, _y4, _angle;

            public Square(double len, double x, double y)
            {
                _len = len;
                _x0 = x;
                _y0 = y;
                _angle = Math.PI / 4;
            _x1 = Math.Round(_x0 + _len * Math.Sin(_angle), 2);
            _x2 = Math.Round(_x0 + _len * Math.Sin(_angle + Math.PI / 2), 2);
            _x3 = Math.Round(_x0 - _len * Math.Sin(_angle), 2);
            _x4 = Math.Round(_x0 - _len * Math.Sin(_angle + Math.PI / 2), 2);

            _y1 = Math.Round(_y0 + _len * Math.Cos(_angle), 2);
            _y2 = Math.Round(_y0 + _len * Math.Cos(_angle + Math.PI / 2), 2);
            _y3 = Math.Round(_y0 - _len * Math.Cos(_angle), 2);
            _y4 = Math.Round(_y0 - _len * Math.Cos(_angle + Math.PI / 2), 2);
        }
            public void Move(double x, double y)
            {
                _x0 += x;
                _y0 += y;
            }
            public void Resize(double len)
            {
                _len = len;
            }
            public void Rotate(double angle)
            {
                _angle = angle - _angle;
            }
            public bool Intersects(object shape)
            {
                if (shape is Square)
                {
                    var s = (Square)shape;
                    double rad0 = Math.Sqrt(Math.Pow((_x0 - s._x0), 2) + Math.Pow((_y0 - s._y0), 2));

                    if (rad0 != 0)
                    {
                        double angRad1 = 0;
                        double angRad2 = 0;
                        double rad1, rad2;

                        double c1Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x1), 2) + Math.Pow((_y0 - s._y1), 2));
                        double c2Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x2), 2) + Math.Pow((_y0 - s._y2), 2));
                        double c3Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x3), 2) + Math.Pow((_y0 - s._y3), 2));
                        double c4Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x4), 2) + Math.Pow((_y0 - s._y4), 2));

                        double c1Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x1), 2) + Math.Pow((s._y0 - _y1), 2));
                        double c2Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x2), 2) + Math.Pow((s._y0 - _y2), 2));
                        double c3Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x3), 2) + Math.Pow((s._y0 - _y3), 2));
                        double c4Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x4), 2) + Math.Pow((s._y0 - _y4), 2));


                        if ((c1Rad1 <= c2Rad1) && (c1Rad1 <= c3Rad1) && (c1Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x1 - s._x0) * (_x0 - s._x0) + (s._y1 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c2Rad1 <= c1Rad1) && (c2Rad1 <= c3Rad1) && (c2Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x2 - s._x0) * (_x0 - s._x0) + (s._y2 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c3Rad1 <= c2Rad1) && (c3Rad1 <= c1Rad1) && (c3Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x3 - s._x0) * (_x0 - s._x0) + (s._y3 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c4Rad1 <= c2Rad1) && (c4Rad1 <= c3Rad1) && (c4Rad1 <= c1Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x4 - s._x0) * (_x0 - s._x0) + (s._y4 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));


                        if ((c1Rad2 <= c2Rad2) && (c1Rad2 <= c3Rad2) && (c1Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x1 - _x0) * (s._x0 - _x0) + (_y1 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c2Rad2 <= c1Rad2) && (c2Rad2 <= c3Rad2) && (c2Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x2 - _x0) * (s._x0 - _x0) + (_y2 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c3Rad2 <= c2Rad2) && (c3Rad2 <= c1Rad2) && (c3Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x3 - _x0) * (s._x0 - _x0) + (_y3 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c4Rad2 <= c2Rad2) && (c4Rad2 <= c3Rad2) && (c4Rad2 <= c1Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x4 - _x0) * (s._x0 - _x0) + (_y4 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));


                        rad1 = s._len * Math.Sin(Math.PI / 4) / Math.Sin(Math.PI - Math.PI / 4 - angRad1);
                        rad2 = _len * Math.Sin(Math.PI / 4) / Math.Sin(Math.PI - Math.PI / 4 - angRad2);


                        return (rad1 + rad2 >= rad0) && (rad1 != 0) && (rad2 != 0);
                    }
                    else
                        return true;
                }

                if (shape is Rectangle)
                {
                    var s = (Rectangle)shape;
                    double rad0 = Math.Sqrt(Math.Pow((_x0 - s._x0), 2) + Math.Pow((_y0 - s._y0), 2));

                    if (rad0 != 0)
                    {
                        double angRad1 = 0;
                        double angRad2 = 0;
                        double rad1, rad2;

                        double c1Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x1), 2) + Math.Pow((_y0 - s._y1), 2));
                        double c2Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x2), 2) + Math.Pow((_y0 - s._y2), 2));
                        double c3Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x3), 2) + Math.Pow((_y0 - s._y3), 2));
                        double c4Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x4), 2) + Math.Pow((_y0 - s._y4), 2));

                        double c1Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x1), 2) + Math.Pow((s._y0 - _y1), 2));
                        double c2Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x2), 2) + Math.Pow((s._y0 - _y2), 2));
                        double c3Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x3), 2) + Math.Pow((s._y0 - _y3), 2));
                        double c4Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x4), 2) + Math.Pow((s._y0 - _y4), 2));


                        if ((c1Rad1 <= c2Rad1) && (c1Rad1 <= c3Rad1) && (c1Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x1 - s._x0) * (_x0 - s._x0) + (s._y1 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c2Rad1 <= c1Rad1) && (c2Rad1 <= c3Rad1) && (c2Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x2 - s._x0) * (_x0 - s._x0) + (s._y2 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c3Rad1 <= c2Rad1) && (c3Rad1 <= c1Rad1) && (c3Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x3 - s._x0) * (_x0 - s._x0) + (s._y3 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c4Rad1 <= c2Rad1) && (c4Rad1 <= c3Rad1) && (c4Rad1 <= c1Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x4 - s._x0) * (_x0 - s._x0) + (s._y4 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));


                        if ((c1Rad2 <= c2Rad2) && (c1Rad2 <= c3Rad2) && (c1Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x1 - _x0) * (s._x0 - _x0) + (_y1 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c2Rad2 <= c1Rad2) && (c2Rad2 <= c3Rad2) && (c2Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x2 - _x0) * (s._x0 - _x0) + (_y2 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c3Rad2 <= c2Rad2) && (c3Rad2 <= c1Rad2) && (c3Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x3 - _x0) * (s._x0 - _x0) + (_y3 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c4Rad2 <= c2Rad2) && (c4Rad2 <= c3Rad2) && (c4Rad2 <= c1Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x4 - _x0) * (s._x0 - _x0) + (_y4 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));


                        rad1 = s._len * (Math.Sin(s._angle0) / Math.Sin(Math.PI - angRad1 - s._angle0));
                        rad2 = _len * Math.Sin(Math.PI / 4) / Math.Sin(Math.PI - Math.PI / 4 - angRad2);


                        return (rad1 + rad2 >= rad0) && (rad1 != 0) && (rad2 != 0);
                    }
                    else
                        return true;
                }

                if (shape is Circle)
                {
                    var s = (Circle)shape;
                    double rad0 = Math.Sqrt(Math.Pow((_x0 - s._x0), 2) + Math.Pow((_y0 - s._y0), 2));

                    if (rad0 != 0)
                    {
                        double angRad2 = 0;
                        double rad1, rad2;

                        double c1Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x1), 2) + Math.Pow((s._y0 - _y1), 2));
                        double c2Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x2), 2) + Math.Pow((s._y0 - _y2), 2));
                        double c3Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x3), 2) + Math.Pow((s._y0 - _y3), 2));
                        double c4Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x4), 2) + Math.Pow((s._y0 - _y4), 2));

                        if ((c1Rad2 <= c2Rad2) && (c1Rad2 <= c3Rad2) && (c1Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x1 - _x0) * (s._x0 - _x0) + (_y1 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c2Rad2 <= c1Rad2) && (c2Rad2 <= c3Rad2) && (c2Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x2 - _x0) * (s._x0 - _x0) + (_y2 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c3Rad2 <= c2Rad2) && (c3Rad2 <= c1Rad2) && (c3Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x3 - _x0) * (s._x0 - _x0) + (_y3 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c4Rad2 <= c2Rad2) && (c4Rad2 <= c3Rad2) && (c4Rad2 <= c1Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x4 - _x0) * (s._x0 - _x0) + (_y4 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));


                        rad1 = s._radius;
                        rad2 = _len * Math.Sin(Math.PI / 4) / Math.Sin(Math.PI - Math.PI / 4 - angRad2);


                        return (rad1 + rad2 >= rad0) && (rad1 != 0) && (rad2 != 0);
                    }
                    else
                        return true;
                }

                throw new NotSupportedException();
            }
            public override string ToString()
            {
                _x1 = Math.Round(_x0 + _len * Math.Sin(_angle), 2);
                _x2 = Math.Round(_x0 + _len * Math.Sin(_angle + Math.PI / 2), 2);
                _x3 = Math.Round(_x0 - _len * Math.Sin(_angle), 2);
                _x4 = Math.Round(_x0 - _len * Math.Sin(_angle + Math.PI / 2), 2);

                _y1 = Math.Round(_y0 + _len * Math.Cos(_angle), 2);
                _y2 = Math.Round(_y0 + _len * Math.Cos(_angle + Math.PI / 2), 2);
                _y3 = Math.Round(_y0 - _len * Math.Cos(_angle), 2);
                _y4 = Math.Round(_y0 - _len * Math.Cos(_angle + Math.PI / 2), 2);


                return $"Квадрат \n" +
                    $" Центр {_x0}; {_y0} \n" +
                    $" Длина вектора от центра до вершины = {_len}\n" +
                    $" Вершина 1 = ({_x1}; {_y1}) \n" +
                    $" Вершина 2 = ({_x2}; {_y2}) \n" +
                    $" Вершина 3 = ({_x3}; {_y3}) \n" +
                    $" Вершина 4 = ({_x4}; {_y4})";
            }

        }

    public class Rectangle
        {
            public double _x0, _y0, _h, _w, _x1, _x2, _x3, _x4, _y1, _y2, _y3, _y4, _angle0, _angle, _len;

            public Rectangle(double h, double w, double x, double y)
            {
                _w = w;
                _h = h;
                _x0 = x;
                _y0 = y;
                _angle0 = Math.Atan(h / w);
                _len = Math.Sqrt(Math.Pow(_w, 2) + Math.Pow(_h, 2)) / 2;
            _x1 = Math.Round(_x0 + _len * Math.Cos(_angle0 + _angle), 2);
            _x2 = Math.Round(_x0 + _len * Math.Cos(Math.PI - _angle0 + _angle), 2);
            _x3 = Math.Round(_x0 - _len * Math.Cos(_angle0 + _angle), 2);
            _x4 = Math.Round(_x0 - _len * Math.Cos(Math.PI - _angle0 + _angle), 2);

            _y1 = Math.Round(_y0 + _len * Math.Sin(_angle0 + _angle), 2);
            _y2 = Math.Round(_y0 + _len * Math.Sin(Math.PI - _angle0 + _angle), 2);
            _y3 = Math.Round(_y0 - _len * Math.Sin(_angle0 + _angle), 2);
            _y4 = Math.Round(_y0 - _len * Math.Sin(Math.PI - _angle0 + _angle), 2);
        }
            public void Move(double x, double y)
            {
                _x0 += x;
                _y0 += y;
            }
            public void ResizeHeight(double h)
            {
                _h = h;
            }
            public void ResizeWidth(double w)
            {
                _w = w;
            }
            public void Rotate(double angle)
            {
                _angle = angle;
            }
            public bool Intersects(object shape)
            {
                if (shape is Square)
                {
                    var s = (Square)shape;
                    double rad0 = Math.Sqrt(Math.Pow((_x0 - s._x0), 2) + Math.Pow((_y0 - s._y0), 2));

                    if (rad0 != 0)
                    {
                        double angRad1 = 0;
                        double angRad2 = 0;
                        double rad1, rad2;

                        double c1Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x1), 2) + Math.Pow((_y0 - s._y1), 2));
                        double c2Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x2), 2) + Math.Pow((_y0 - s._y2), 2));
                        double c3Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x3), 2) + Math.Pow((_y0 - s._y3), 2));
                        double c4Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x4), 2) + Math.Pow((_y0 - s._y4), 2));

                        double c1Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x1), 2) + Math.Pow((s._y0 - _y1), 2));
                        double c2Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x2), 2) + Math.Pow((s._y0 - _y2), 2));
                        double c3Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x3), 2) + Math.Pow((s._y0 - _y3), 2));
                        double c4Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x4), 2) + Math.Pow((s._y0 - _y4), 2));


                        if ((c1Rad1 <= c2Rad1) && (c1Rad1 <= c3Rad1) && (c1Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x1 - s._x0) * (_x0 - s._x0) + (s._y1 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c2Rad1 <= c1Rad1) && (c2Rad1 <= c3Rad1) && (c2Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x2 - s._x0) * (_x0 - s._x0) + (s._y2 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c3Rad1 <= c2Rad1) && (c3Rad1 <= c1Rad1) && (c3Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x3 - s._x0) * (_x0 - s._x0) + (s._y3 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c4Rad1 <= c2Rad1) && (c4Rad1 <= c3Rad1) && (c4Rad1 <= c1Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x4 - s._x0) * (_x0 - s._x0) + (s._y4 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));


                        if ((c1Rad2 <= c2Rad2) && (c1Rad2 <= c3Rad2) && (c1Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x1 - _x0) * (s._x0 - _x0) + (_y1 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c2Rad2 <= c1Rad2) && (c2Rad2 <= c3Rad2) && (c2Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x2 - _x0) * (s._x0 - _x0) + (_y2 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c3Rad2 <= c2Rad2) && (c3Rad2 <= c1Rad2) && (c3Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x3 - _x0) * (s._x0 - _x0) + (_y3 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c4Rad2 <= c2Rad2) && (c4Rad2 <= c3Rad2) && (c4Rad2 <= c1Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x4 - _x0) * (s._x0 - _x0) + (_y4 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));


                        rad1 = s._len * (Math.Sin(Math.PI / 4)) / Math.Sin(Math.PI - Math.PI / 4 - angRad1);
                        rad2 = _len * (Math.Sin(_angle0)) / Math.Sin(Math.PI - angRad2 - _angle0);


                        return (rad1 + rad2 >= rad0) && (rad1 != 0) && (rad2 != 0);
                    }
                    else
                        return true;
                }

                if (shape is Rectangle)
                {
                    var s = (Rectangle)shape;
                    double rad0 = Math.Sqrt(Math.Pow((_x0 - s._x0), 2) + Math.Pow((_y0 - s._y0), 2));

                    if (rad0 != 0)
                    {
                        double angRad1 = 0;
                        double angRad2 = 0;
                        double rad1, rad2;

                        double c1Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x1), 2) + Math.Pow((_y0 - s._y1), 2));
                        double c2Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x2), 2) + Math.Pow((_y0 - s._y2), 2));
                        double c3Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x3), 2) + Math.Pow((_y0 - s._y3), 2));
                        double c4Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x4), 2) + Math.Pow((_y0 - s._y4), 2));

                        double c1Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x1), 2) + Math.Pow((s._y0 - _y1), 2));
                        double c2Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x2), 2) + Math.Pow((s._y0 - _y2), 2));
                        double c3Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x3), 2) + Math.Pow((s._y0 - _y3), 2));
                        double c4Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x4), 2) + Math.Pow((s._y0 - _y4), 2));


                        if ((c1Rad1 <= c2Rad1) && (c1Rad1 <= c3Rad1) && (c1Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x1 - s._x0) * (_x0 - s._x0) + (s._y1 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c2Rad1 <= c1Rad1) && (c2Rad1 <= c3Rad1) && (c2Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x2 - s._x0) * (_x0 - s._x0) + (s._y2 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c3Rad1 <= c2Rad1) && (c3Rad1 <= c1Rad1) && (c3Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x3 - s._x0) * (_x0 - s._x0) + (s._y3 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c4Rad1 <= c2Rad1) && (c4Rad1 <= c3Rad1) && (c4Rad1 <= c1Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x4 - s._x0) * (_x0 - s._x0) + (s._y4 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));


                        if ((c1Rad2 <= c2Rad2) && (c1Rad2 <= c3Rad2) && (c1Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x1 - _x0) * (s._x0 - _x0) + (_y1 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c2Rad2 <= c1Rad2) && (c2Rad2 <= c3Rad2) && (c2Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x2 - _x0) * (s._x0 - _x0) + (_y2 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c3Rad2 <= c2Rad2) && (c3Rad2 <= c1Rad2) && (c3Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x3 - _x0) * (s._x0 - _x0) + (_y3 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c4Rad2 <= c2Rad2) && (c4Rad2 <= c3Rad2) && (c4Rad2 <= c1Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x4 - _x0) * (s._x0 - _x0) + (_y4 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));


                        rad1 = s._len * (Math.Sin(_angle0) / Math.Sin(Math.PI - angRad1 - _angle0));
                        rad2 = _len * (Math.Sin(_angle0) / Math.Sin(Math.PI - angRad2 - _angle0));


                        return (rad1 + rad2 >= rad0) && (rad1 != 0) && (rad2 != 0);
                    }
                    else
                        return true;
                }

                if (shape is Circle)
                {
                    var s = (Circle)shape;
                    double rad0 = Math.Sqrt(Math.Pow((_x0 - s._x0), 2) + Math.Pow((_y0 - s._y0), 2));

                    if (rad0 != 0)
                    {
                        double angRad2 = 0;
                        double rad1, rad2;

                        double c1Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x1), 2) + Math.Pow((s._y0 - _y1), 2));
                        double c2Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x2), 2) + Math.Pow((s._y0 - _y2), 2));
                        double c3Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x3), 2) + Math.Pow((s._y0 - _y3), 2));
                        double c4Rad2 = Math.Sqrt(Math.Pow((s._x0 - _x4), 2) + Math.Pow((s._y0 - _y4), 2));

                        if ((c1Rad2 <= c2Rad2) && (c1Rad2 <= c3Rad2) && (c1Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x1 - _x0) * (s._x0 - _x0) + (_y1 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c2Rad2 <= c1Rad2) && (c2Rad2 <= c3Rad2) && (c2Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x2 - _x0) * (s._x0 - _x0) + (_y2 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c3Rad2 <= c2Rad2) && (c3Rad2 <= c1Rad2) && (c3Rad2 <= c4Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x3 - _x0) * (s._x0 - _x0) + (_y3 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));

                        if ((c4Rad2 <= c2Rad2) && (c4Rad2 <= c3Rad2) && (c4Rad2 <= c1Rad2))
                            angRad2 = Math.Acos(Math.Round((((_x4 - _x0) * (s._x0 - _x0) + (_y4 - _y0) * (s._y0 - _y0)) / (rad0 * _len)),2));


                        rad1 = s._radius;
                        rad2 = _len * (Math.Sin(_angle0) / Math.Sin(Math.PI - angRad2 - _angle0));


                        return (rad1 + rad2 >= rad0) && (rad1 != 0) && (rad2 != 0);
                    }
                    else
                        return true;
                }

                throw new NotSupportedException();



            }
            public override string ToString()
            {
                _len = Math.Sqrt(Math.Pow(_w, 2) + Math.Pow(_h, 2)) / 2;

                _x1 = Math.Round(_x0 + _len * Math.Cos(_angle0 + _angle), 2);
                _x2 = Math.Round(_x0 + _len * Math.Cos(Math.PI - _angle0 + _angle), 2);
                _x3 = Math.Round(_x0 - _len * Math.Cos(_angle0 + _angle), 2);
                _x4 = Math.Round(_x0 - _len * Math.Cos(Math.PI - _angle0 + _angle), 2);

                _y1 = Math.Round(_y0 + _len * Math.Sin(_angle0 + _angle), 2);
                _y2 = Math.Round(_y0 + _len * Math.Sin(Math.PI - _angle0 + _angle), 2);
                _y3 = Math.Round(_y0 - _len * Math.Sin(_angle0 + _angle), 2);
                _y4 = Math.Round(_y0 - _len * Math.Sin(Math.PI - _angle0 + _angle), 2);


                return $"Прямоугольник \n" +
                    $" Центр {_x0}; {_y0} \n" +
                    $" Длина вектора от центра до вершины = {Math.Round(_len, 2)}\n" +
                    $" Вершина 1 = ({_x1}; {_y1}) \n" +
                    $" Вершина 2 = ({_x2}; {_y2}) \n" +
                    $" Вершина 3 = ({_x3}; {_y3}) \n" +
                    $" Вершина 4 = ({_x4}; {_y4})";
            }

        }

    public class Circle
        {
            public double _x0, _y0, _x1, _x2, _x3, _x4, _y1, _y2, _y3, _y4, _radius, _angle0;

            public Circle(double radius, double x, double y)
            {
                _radius = radius;
                _x0 = x;
                _y0 = y;
                _angle0 = 0;
            }
            public void Move(double x, double y)
            {
                _x0 += x;
                _y0 += y;
            }
            public void Resize(double radius)
            {
                _radius = radius;
            }
            public void Rotate(double angle)
            {
                _angle0 = angle;
            }
            public bool Intersects(object shape)
            {
                if (shape is Square)
                {
                    var s = (Square)shape;
                    double rad0 = Math.Sqrt(Math.Pow((_x0 - s._x0), 2) + Math.Pow((_y0 - s._y0), 2));

                    if (rad0 != 0)
                    {
                        double angRad1 = 0;
                        double rad1, rad2;

                        double c1Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x1), 2) + Math.Pow((_y0 - s._y1), 2));
                        double c2Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x2), 2) + Math.Pow((_y0 - s._y2), 2));
                        double c3Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x3), 2) + Math.Pow((_y0 - s._y3), 2));
                        double c4Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x4), 2) + Math.Pow((_y0 - s._y4), 2));


                        if ((c1Rad1 <= c2Rad1) && (c1Rad1 <= c3Rad1) && (c1Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x1 - s._x0) * (_x0 - s._x0) + (s._y1 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c2Rad1 <= c1Rad1) && (c2Rad1 <= c3Rad1) && (c2Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x2 - s._x0) * (_x0 - s._x0) + (s._y2 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c3Rad1 <= c2Rad1) && (c3Rad1 <= c1Rad1) && (c3Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x3 - s._x0) * (_x0 - s._x0) + (s._y3 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c4Rad1 <= c2Rad1) && (c4Rad1 <= c3Rad1) && (c4Rad1 <= c1Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x4 - s._x0) * (_x0 - s._x0) + (s._y4 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));


                        rad1 = s._len * Math.Sin(Math.PI / 4) / Math.Sin(Math.PI - Math.PI / 4 - angRad1);
                        rad2 = _radius;


                        return (rad1 + rad2 >= rad0) && (rad1 != 0) && (rad2 != 0);
                    }
                    else
                        return true;
                }

                if (shape is Rectangle)
                {
                    var s = (Rectangle)shape;
                    double rad0 = Math.Sqrt(Math.Pow((_x0 - s._x0), 2) + Math.Pow((_y0 - s._y0), 2));

                    if (rad0 != 0)
                    {
                        double angRad1 = 0;
                        double rad1, rad2;

                        double c1Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x1), 2) + Math.Pow((_y0 - s._y1), 2));
                        double c2Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x2), 2) + Math.Pow((_y0 - s._y2), 2));
                        double c3Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x3), 2) + Math.Pow((_y0 - s._y3), 2));
                        double c4Rad1 = Math.Sqrt(Math.Pow((_x0 - s._x4), 2) + Math.Pow((_y0 - s._y4), 2));


                        if ((c1Rad1 <= c2Rad1) && (c1Rad1 <= c3Rad1) && (c1Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x1 - s._x0) * (_x0 - s._x0) + (s._y1 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c2Rad1 <= c1Rad1) && (c2Rad1 <= c3Rad1) && (c2Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x2 - s._x0) * (_x0 - s._x0) + (s._y2 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c3Rad1 <= c2Rad1) && (c3Rad1 <= c1Rad1) && (c3Rad1 <= c4Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x3 - s._x0) * (_x0 - s._x0) + (s._y3 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));

                        if ((c4Rad1 <= c2Rad1) && (c4Rad1 <= c3Rad1) && (c4Rad1 <= c1Rad1))
                            angRad1 = Math.Acos(Math.Round((((s._x4 - s._x0) * (_x0 - s._x0) + (s._y4 - s._y0) * (_y0 - s._y0)) / (rad0 * s._len)),2));


                        rad1 = s._len * (Math.Sin(s._angle0) / Math.Sin(Math.PI - angRad1 - s._angle0));
                        rad2 = _radius;


                        return (rad1 + rad2 >= rad0) && (rad1 != 0) && (rad2 != 0);
                    }
                    else
                        return true;
                }

                if (shape is Circle)
                {
                    var s = (Circle)shape;
                    double rad0 = Math.Sqrt(Math.Pow((_x0 - s._x0), 2) + Math.Pow((_y0 - s._y0), 2));
                    double rad1 = _radius;
                    double rad2 = s._radius;


                    return (rad1 + rad2 >= rad0) && (rad1 != 0) && (rad2 != 0);
                }

                throw new NotSupportedException();
            }
            public override string ToString()
            {
                _x1 = Math.Round(_x0 + _radius * Math.Sin(_angle0), 2);
                _x2 = Math.Round(_x0 + _radius * Math.Sin(_angle0 + Math.PI / 2), 2);
                _x3 = Math.Round(_x0 - _radius * Math.Sin(_angle0), 2);
                _x4 = Math.Round(_x0 - _radius * Math.Sin(_angle0 + Math.PI / 2), 2);

                _y1 = Math.Round(_y0 + _radius * Math.Cos(_angle0), 2);
                _y2 = Math.Round(_y0 + _radius * Math.Cos(_angle0 + Math.PI / 2), 2);
                _y3 = Math.Round(_y0 - _radius * Math.Cos(_angle0), 2);
                _y4 = Math.Round(_y0 - _radius * Math.Cos(_angle0 + Math.PI / 2), 2);

                return $"Круг \n" +
                    $" Центр {_x0}; {_y0} \n" +
                    $" Радиус = {_radius}\n" +
                    $" Квадрант 1 = ({_x1}; {_y1}) \n" +
                    $" Квадрант 2 = ({_x2}; {_y2}) \n" +
                    $" Квадрант 3 = ({_x3}; {_y3}) \n" +
                    $" Квадрант 4 = ({_x4}; {_y4})";
            }
        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Количество квадратов
            Console.WriteLine("Введите желаемое количество квадратов, но не больше 10.");
            string str = "";
            int Nsquare = 0;
            while (str == "")
            {
                str = Console.ReadLine();
                bool check = int.TryParse(str, out Nsquare);
                if ((check) && (Nsquare <= 10) && (Nsquare >= 0))
                    break;
                else
                    str = "";
                Console.WriteLine("Введите значение от 0 до 10");
            }

            ///Количество прямоугольников
            Console.WriteLine("Введите желаемое количество прямоугольников, но не больше 10.");
            str = "";
            int Nrectangles = 0;
            while (str == "")
            {
                str = Console.ReadLine();
                bool check = int.TryParse(str, out Nrectangles);
                if ((check) && (Nrectangles <= 10) && (Nrectangles >= 0))
                    break;
                else
                    str = "";
                Console.WriteLine("Введите значение от 0 до 10");
            }

            ///Количество кругов
            Console.WriteLine("Введите желаемое количество кругов, но не больше 10.");
            str = "";
            int Ncircles = 0;
            while (str == "")
            {
                str = Console.ReadLine();
                bool check = int.TryParse(str, out Ncircles);
                if ((check) && (Ncircles <= 10) && (Ncircles >= 0))
                    break;
                else
                    str = "";
                Console.WriteLine("Введите значение от 0 до 10");
            }


            /// Создание массива под объекты, выделение памяти
            var squares = new Square[Nsquare];
            var rectangles = new Rectangle[Nrectangles];
            var circles = new Circle[Ncircles];


            /// Создание квадратов
            for (int i = 0; i < Nsquare; i++)
            {
                Console.WriteLine("Введите параметры для квадрата " + (i + 1));

                double x0, y0, len;
                Console.WriteLine("Введите длину вектора от центра до вершины квадрата и нажмите Enter:");
                len = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите абсциссу центра квадрата и нажмите Enter:");
                x0 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ориданту центра квадрата и нажмите Enter:");
                y0 = double.Parse(Console.ReadLine());
                squares[i] = new Square(len, x0, y0);
            }

            /// Создание прямоугольников
            for (int i = 0; i < Nrectangles; i++)
            {
                Console.WriteLine("Введите параметры для прямоугольника " + (i + 1));

                double x0, y0, len, heigth;
                Console.WriteLine("Введите размер высоты прямоугольника и нажмите Enter:");
                heigth = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите размер ширины прямоугольника и нажмите Enter:");
                len = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите абсциссу центра прямоугольника и нажмите Enter:");
                x0 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ориданту центра прямоугольника и нажмите Enter:");
                y0 = double.Parse(Console.ReadLine());
                rectangles[i] = new Rectangle(heigth, len, x0, y0);
            }

            /// Создание кругов
            for (int i = 0; i < Ncircles; i++)
            {
                Console.WriteLine("Введите параметры для круга " + (i + 1));

                double x0, y0, len;
                Console.WriteLine("Введите радиус круга и нажмите Enter:");
                len = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите абсциссу центра круга и нажмите Enter:");
                x0 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ориданту центра круга и нажмите Enter:");
                y0 = double.Parse(Console.ReadLine());
                circles[i] = new Circle(len, x0, y0);
            }

            /// Действия с объектами
            int nomber = -1;
            if (Ncircles + Nsquare + Nrectangles == 0)
            {
                Console.WriteLine("Нет созданых объектов. Завершение программы");
                nomber = 0;
            }
            while (nomber != 0)
            {
                double x;
                double y = 0;
                double len, angle;
                int Nom = -1;

                Console.WriteLine("Выберите тип объекта, над которым собираетесь совершать действие: \n 1. Квадрат \n 2. Прямоугольник \n 3. Круг");
                str = "";
                while (str == "")
                {
                    str = Console.ReadLine();
                    bool check = int.TryParse(str, out Nom);
                    if ((check) && (Nom <= 3) && (Nom >= 1))
                        break;
                    else
                        str = "";
                    Console.WriteLine("Введите значение от 1 до 3");
                }

                switch (Nom)
                {
                    case 1:
                        {
                            int N = 0;
                            if (Nsquare != 0)
                            {
                                Console.WriteLine("Выберите номер квадрата, над которым собираетесь совершать действие от 1 до " + Nsquare);
                                str = "";
                                while (str == "")
                                {
                                    str = Console.ReadLine();
                                    bool check = int.TryParse(str, out N);
                                    if ((check) && (N <= Nsquare) && (N >= 1))
                                        break;
                                    else
                                        str = "";
                                    Console.WriteLine("Введите значение от 1 до " + Nsquare);
                                }

                                Console.WriteLine("Выберите действие: \n 0. Покинуть программу \n 1. Преместить \n 2. Изменить размер \n 3. Повернуть \n 4. Проверка на пересечение фигур \n 5. Вывести информацию об объекте \n ");
                                str = "";
                                while (str == "")
                                {
                                    str = Console.ReadLine();
                                    bool check = int.TryParse(str, out nomber);
                                    if ((check) && (nomber <= 5) && (nomber >= 0))
                                        break;
                                    else
                                        str = "";
                                    Console.WriteLine("Введите значение от 0 до 5");
                                }

                                switch (nomber)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        {
                                            Console.WriteLine("Введите абсциссу вектора перемещения:");
                                            x = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите ординату вектора перемещения:");
                                            y = double.Parse(Console.ReadLine());
                                            squares[N - 1].Move(x, y);
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine("Введите длину вектора от центра до вершины квадрата:");
                                            len = double.Parse(Console.ReadLine());
                                            squares[N - 1].Resize(len);
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("Введите угол, на который хотите повернуть фигуру:");
                                            angle = double.Parse(Console.ReadLine());
                                            squares[N - 1].Rotate(angle);
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.WriteLine("Введите тип фигуры, с которой желаете проверить пересечение: \n 1. Квадрат \n 2. Прямоугольник \n 3. Круг");
                                            str = "";
                                            int Nom2 = 0;
                                            while (str == "")
                                            {
                                                str = Console.ReadLine();
                                                bool check = int.TryParse(str, out Nom2);
                                                if ((check) && (Nom2 <= 3) && (Nom2 >= 1))
                                                    break;
                                                else
                                                    str = "";
                                                Console.WriteLine("Введите значение от 1 до 3");
                                            }

                                            switch (Nom2)
                                            {
                                                case 1:
                                                    {
                                                        if (Nsquare != 0)
                                                        {
                                                            Console.WriteLine("Выберите номер квадрата с которым желаете проверить пересчение от 1 до " + Nsquare);
                                                            str = "";
                                                            int N2 = -1;
                                                            while (str == "")
                                                            {
                                                                str = Console.ReadLine();
                                                                bool check = int.TryParse(str, out N2);
                                                                if ((check) && (N2 <= Nsquare) && (N2 >= 1))
                                                                    break;
                                                                else
                                                                    str = "";
                                                                Console.WriteLine("Введите значение от 1 до " + Nsquare);
                                                            }
                                                            if (squares[N - 1].Intersects(squares[N2 - 1]))
                                                                Console.WriteLine("Выбранные объекты пересекаются");
                                                            else
                                                                Console.WriteLine("Выбранные объекты НЕ пересекаются");
                                                        }
                                                        else
                                                            Console.WriteLine("Не существует экзэмпляров выбранного объекта");

                                                    }
                                                    break;
                                                case 2:
                                                    {
                                                        if (Nrectangles != 0)
                                                        {
                                                            Console.WriteLine("Выберите номер прямоугольника с которым желаете проверить пересчение от 1 до " + Nrectangles);
                                                            str = "";
                                                            int N2 = -1;
                                                            while (str == "")
                                                            {
                                                                str = Console.ReadLine();
                                                                bool check = int.TryParse(str, out N2);
                                                                if ((check) && (N2 <= Nrectangles) && (N2 >= 1))
                                                                    break;
                                                                else
                                                                    str = "";
                                                                Console.WriteLine("Введите значение от 1 до " + Nrectangles);
                                                            }
                                                            if (squares[N - 1].Intersects(rectangles[N2 - 1]))
                                                                Console.WriteLine("Выбранные объекты пересекаются");
                                                            else
                                                                Console.WriteLine("Выбранные объекты НЕ пересекаются");
                                                        }
                                                        else
                                                            Console.WriteLine("Не существует экзэмпляров выбранного объекта");
                                                    }
                                                    break;
                                                case 3:
                                                    {
                                                        if (Ncircles != 0)
                                                        {
                                                            Console.WriteLine("Выберите номер круга с которым желаете проверить пересчение от 1 до " + Ncircles);
                                                            str = "";
                                                            int N2 = -1;
                                                            while (str == "")
                                                            {
                                                                str = Console.ReadLine();
                                                                bool check = int.TryParse(str, out N2);
                                                                if ((check) && (N2 <= Ncircles) && (N2 >= 1))
                                                                    break;
                                                                else
                                                                    str = "";
                                                                Console.WriteLine("Введите значение от 1 до " + Ncircles);
                                                            }
                                                            if (squares[N - 1].Intersects(circles[N2 - 1]))
                                                                Console.WriteLine("Выбранные объекты пересекаются");
                                                            else
                                                                Console.WriteLine("Выбранные объекты НЕ пересекаются");
                                                        }
                                                        else
                                                            Console.WriteLine("Не существует экзэмпляров выбранного объекта");
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.WriteLine(squares[N - 1]);
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                                Console.WriteLine("Созданные квадраты отсутсвуют");
                        }
                        break;
                    case 2:
                        {
                            int N = 0;
                            if (Nrectangles != 0)
                            {
                                Console.WriteLine("Выберите номер прямоуголника, над которым собираетесь совершать действие от 1 до " + Nrectangles);
                                str = "";
                                while (str == "")
                                {
                                    str = Console.ReadLine();
                                    bool check = int.TryParse(str, out N);
                                    if ((check) && (N <= Nrectangles) && (N >= 1))
                                        break;
                                    else
                                        str = "";
                                    Console.WriteLine("Введите значение от 1 до " + Nrectangles);
                                }

                                Console.WriteLine("Выберите действие: \n 0. Покинуть программу \n 1. Преместить \n 2. Изменить размер \n 3. Повернуть \n 4. Проверка на пересечение фигур \n 5. Вывести информацию об объекте \n ");
                                str = "";
                                while (str == "")
                                {
                                    str = Console.ReadLine();
                                    bool check = int.TryParse(str, out nomber);
                                    if ((check) && (nomber <= 5) && (nomber >= 0))
                                        break;
                                    else
                                        str = "";
                                    Console.WriteLine("Введите значение от 0 до 5");
                                }

                                switch (nomber)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        {
                                            Console.WriteLine("Введите абсциссу вектора перемещения:");
                                            x = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите ординату вектора перемещения:");
                                            y = double.Parse(Console.ReadLine());
                                            rectangles[N - 1].Move(x, y);
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine("Введите какой параметр вы желаете изменить: \n 1. Высоту \n 2. Ширину");
                                            int k = 0;
                                            str = "";
                                            while (str == "")
                                            {
                                                str = Console.ReadLine();
                                                bool check = int.TryParse(str, out k);
                                                if ((check) && (k <= 2) && (k >= 1))
                                                    break;
                                                else
                                                    str = "";
                                                Console.WriteLine("Введите значение от 1 до 2");
                                            }
                                            Console.WriteLine("Введите размер выбранной величины");
                                            len = double.Parse(Console.ReadLine());
                                            if (k == 1)
                                                rectangles[N - 1].ResizeHeight(len);
                                            else
                                                rectangles[N - 1].ResizeWidth(len);
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("Введите угол, на который хотите повернуть фигуру:");
                                            angle = double.Parse(Console.ReadLine());
                                            rectangles[N - 1].Rotate(angle);
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.WriteLine("Введите тип фигуры, с которой желаете проверить пересечение: \n 1. Квадрат \n 2. Прямоугольник \n 3. Круг");
                                            str = "";
                                            int Nom2 = 0;
                                            while (str == "")
                                            {
                                                str = Console.ReadLine();
                                                bool check = int.TryParse(str, out Nom2);
                                                if ((check) && (Nom2 <= 3) && (Nom2 >= 1))
                                                    break;
                                                else
                                                    str = "";
                                                Console.WriteLine("Введите значение от 1 до 3");
                                            }

                                            switch (Nom2)
                                            {
                                                case 1:
                                                    {
                                                        if (Nsquare != 0)
                                                        {
                                                            Console.WriteLine("Выберите номер квадрата с которым желаете проверить пересчение от 1 до " + Nsquare);
                                                            str = "";
                                                            int N2 = -1;
                                                            while (str == "")
                                                            {
                                                                str = Console.ReadLine();
                                                                bool check = int.TryParse(str, out N2);
                                                                if ((check) && (N2 <= Nsquare) && (N2 >= 1))
                                                                    break;
                                                                else
                                                                    str = "";
                                                                Console.WriteLine("Введите значение от 1 до " + Nsquare);
                                                            }
                                                            if (rectangles[N - 1].Intersects(squares[N2 - 1]))
                                                                Console.WriteLine("Выбранные объекты пересекаются");
                                                            else
                                                                Console.WriteLine("Выбранные объекты НЕ пересекаются");
                                                        }
                                                        else
                                                            Console.WriteLine("Не существует экзэмпляров выбранного объекта");
                                                    }
                                                    break;
                                                case 2:
                                                    {
                                                        if (Nrectangles != 0)
                                                        {
                                                            Console.WriteLine("Выберите номер прямоугольника с которым желаете проверить пересчение от 1 до " + Nrectangles);
                                                            str = "";
                                                            int N2 = -1;
                                                            while (str == "")
                                                            {
                                                                str = Console.ReadLine();
                                                                bool check = int.TryParse(str, out N2);
                                                                if ((check) && (N2 <= Nrectangles) && (N2 >= 1))
                                                                    break;
                                                                else
                                                                    str = "";
                                                                Console.WriteLine("Введите значение от 1 до " + Nrectangles);
                                                            }
                                                            if (rectangles[N - 1].Intersects(rectangles[N2 - 1]))
                                                                Console.WriteLine("Выбранные объекты пересекаются");
                                                            else
                                                                Console.WriteLine("Выбранные объекты НЕ пересекаются");
                                                        }
                                                        else
                                                            Console.WriteLine("Не существует экзэмпляров выбранного объекта");
                                                    }
                                                    break;
                                                case 3:
                                                    {
                                                        if (Ncircles != 0)
                                                        {
                                                            Console.WriteLine("Выберите номер круга с которым желаете проверить пересчение от 1 до " + Ncircles);
                                                            str = "";
                                                            int N2 = -1;
                                                            while (str == "")
                                                            {
                                                                str = Console.ReadLine();
                                                                bool check = int.TryParse(str, out N2);
                                                                if ((check) && (N2 <= Ncircles) && (N2 >= 1))
                                                                    break;
                                                                else
                                                                    str = "";
                                                                Console.WriteLine("Введите значение от 1 до " + Ncircles);
                                                            }
                                                            if (rectangles[N - 1].Intersects(circles[N2 - 1]))
                                                                Console.WriteLine("Выбранные объекты пересекаются");
                                                            else
                                                                Console.WriteLine("Выбранные объекты НЕ пересекаются");
                                                        }
                                                        else
                                                            Console.WriteLine("Не существует экзэмпляров выбранного объекта");
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.WriteLine(rectangles[N - 1]);
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                                Console.WriteLine("Созданные прямоугольники отсутсвуют");
                        }
                        break;
                    case 3:
                        {
                            int N = 0;
                            if (Ncircles != 0)
                            {
                                Console.WriteLine("Выберите номер круга, над которым собираетесь совершать действие от 1 до " + Ncircles);
                                str = "";
                                while (str == "")
                                {
                                    str = Console.ReadLine();
                                    bool check = int.TryParse(str, out N);
                                    if ((check) && (N <= Ncircles) && (N >= 1))
                                        break;
                                    else
                                        str = "";
                                    Console.WriteLine("Введите значение от 1 до " + Ncircles);
                                }

                                Console.WriteLine("Выберите действие: \n 0. Покинуть программу \n 1. Преместить \n 2. Изменить размер \n 3. Повернуть \n 4. Проверка на пересечение фигур \n 5. Вывести информацию об объекте \n ");
                                str = "";
                                while (str == "")
                                {
                                    str = Console.ReadLine();
                                    bool check = int.TryParse(str, out nomber);
                                    if ((check) && (nomber <= 5) && (nomber >= 0))
                                        break;
                                    else
                                        str = "";
                                    Console.WriteLine("Введите значение от 0 до 5");
                                }

                                switch (nomber)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        {
                                            Console.WriteLine("Введите абсциссу вектора перемещения:");
                                            x = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите ординату вектора перемещения:");
                                            y = double.Parse(Console.ReadLine());
                                            circles[N - 1].Move(x, y);
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine("Введите радиус круга:");
                                            len = double.Parse(Console.ReadLine());
                                            circles[N - 1].Resize(len);
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("Введите угол, на который хотите повернуть фигуру:");
                                            angle = double.Parse(Console.ReadLine());
                                            circles[N - 1].Rotate(angle);
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.WriteLine("Введите тип фигуры, с которой желаете проверить пересечение: \n 1. Квадрат \n 2. Прямоугольник \n 3. Круг");
                                            str = "";
                                            int Nom2 = 0;
                                            while (str == "")
                                            {
                                                str = Console.ReadLine();
                                                bool check = int.TryParse(str, out Nom2);
                                                if ((check) && (Nom2 <= 3) && (Nom2 >= 1))
                                                    break;
                                                else
                                                    str = "";
                                                Console.WriteLine("Введите значение от 1 до 3");
                                            }

                                            switch (Nom2)
                                            {
                                                case 1:
                                                    {
                                                        if (Nsquare != 0)
                                                        {
                                                            Console.WriteLine("Выберите номер квадрата с которым желаете проверить пересчение от 1 до " + Nsquare);
                                                            str = "";
                                                            int N2 = -1;
                                                            while (str == "")
                                                            {
                                                                str = Console.ReadLine();
                                                                bool check = int.TryParse(str, out N2);
                                                                if ((check) && (N2 <= Nsquare) && (N2 >= 1))
                                                                    break;
                                                                else
                                                                    str = "";
                                                                Console.WriteLine("Введите значение от 1 до " + Nsquare);
                                                            }
                                                            if (circles[N - 1].Intersects(squares[N2 - 1]))
                                                                Console.WriteLine("Выбранные объекты пересекаются");
                                                            else
                                                                Console.WriteLine("Выбранные объекты НЕ пересекаются");
                                                        }
                                                        else
                                                            Console.WriteLine("Не существует экзэмпляров выбранного объекта");
                                                    }
                                                    break;
                                                case 2:
                                                    {
                                                        if (Nrectangles != 0)
                                                        {
                                                            Console.WriteLine("Выберите номер прямоугольника с которым желаете проверить пересчение от 1 до " + Nrectangles);
                                                            str = "";
                                                            int N2 = -1;
                                                            while (str == "")
                                                            {
                                                                str = Console.ReadLine();
                                                                bool check = int.TryParse(str, out N2);
                                                                if ((check) && (N2 <= Nrectangles) && (N2 >= 1))
                                                                    break;
                                                                else
                                                                    str = "";
                                                                Console.WriteLine("Введите значение от 1 до " + Nrectangles);
                                                            }
                                                            if (circles[N - 1].Intersects(rectangles[N2 - 1]))
                                                                Console.WriteLine("Выбранные объекты пересекаются");
                                                            else
                                                                Console.WriteLine("Выбранные объекты НЕ пересекаются");
                                                        }
                                                        else
                                                            Console.WriteLine("Не существует экзэмпляров выбранного объекта");
                                                    }
                                                    break;
                                                case 3:
                                                    {
                                                        if (Ncircles != 0)
                                                        {
                                                            Console.WriteLine("Выберите номер круга с которым желаете проверить пересчение от 1 до " + Ncircles);
                                                            str = "";
                                                            int N2 = -1;
                                                            while (str == "")
                                                            {
                                                                str = Console.ReadLine();
                                                                bool check = int.TryParse(str, out N2);
                                                                if ((check) && (N2 <= Ncircles) && (N2 >= 1))
                                                                    break;
                                                                else
                                                                    str = "";
                                                                Console.WriteLine("Введите значение от 1 до " + Ncircles);
                                                            }
                                                            if (circles[N - 1].Intersects(circles[N2 - 1]))
                                                                Console.WriteLine("Выбранные объекты пересекаются");
                                                            else
                                                                Console.WriteLine("Выбранные объекты НЕ пересекаются");
                                                        }
                                                        else
                                                            Console.WriteLine("Не существует экзэмпляров выбранного объекта");
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.WriteLine(circles[N - 1]);
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                                Console.WriteLine("Созданные круги отсутсвуют");
                        }
                        break;
                }
            }
        }
    }
}
