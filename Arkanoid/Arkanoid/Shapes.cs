using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arkanoid
{
    [Serializable]
    public abstract class Shapes
    {
        float x;
        float y;

        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public abstract void Draw(Graphics g);
    }

    [Serializable]
    public class Ellipse : Shapes
    {
        Color col;
        int radiusX;
        int radiusY;

        public Ellipse(float xVal, float yVal, int radXVal, int radYVal, Color color)
        {
            X = xVal;
            Y = yVal;
            radiusX = radXVal;
            radiusY = radYVal;
            col = color;
        }

        public Color Col
        {
            get
            {
                return col;
            }

            set
            {
                col = value;
            }
        }

        public int RadiusX
        {
            get
            {
                return radiusX;
            }

            set
            {
                radiusX = value;
            }
        }

        public int RadiusY
        {
            get
            {
                return radiusY;
            }

            set
            {
                radiusY = value;
            }
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(col);
            Pen pen = new Pen(Color.Black, 1);
            g.FillEllipse(br, X - radiusX, Y - radiusY, radiusX, 2 * radiusY);
            g.DrawEllipse(pen, X - radiusX, Y - radiusY, radiusX, 2 * radiusY);
        }

        public bool isEllipsePassLine(int yVal)
        {
            if (this.Y == yVal)
                return true;

            return false;
        }

        public void move_ellipse()
        {
            this.Y += 1;
        }
    }

    [Serializable]
    public class Ball : Ellipse
    {
        int deltaX;
        int deltaY;
        int powerHit;

        public Ball(float xVal, float yVal, int radVal, Color c) : base(xVal, yVal, radVal, radVal, c)
        {
            deltaX = 3;
            deltaY = 3;
            powerHit = 1;
        }

        public int Radius
        {
            get
            {
                return RadiusX;
            }

            set
            {
                RadiusX = value;
                RadiusY = value;
            }
        }

        public int DeltaX
        {
            get
            {
                return deltaX;
            }

            set
            {
                deltaX = value;
            }
        }

        public int DeltaY
        {
            get
            {
                return deltaY;
            }

            set
            {
                deltaY = value;
            }
        }

        public int PowerHit
        {
            get
            {
                return powerHit;
            }
            
            set
            {
                powerHit = value;
            }
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(this.Col);
            Pen pen = new Pen(Color.Black, 2);
            g.FillEllipse(br, X - RadiusX, Y - RadiusX, 2 * RadiusX, 2 * RadiusX);
            g.DrawEllipse(pen, X - RadiusX, Y - RadiusX, 2 * RadiusX, 2 * RadiusX);
        }

        public void move_ball(int height, int width)
        {
            if ((this.X - this.RadiusX) <= 0)
                this.deltaX = 3;

            if ((this.X) >= width)
                this.deltaX = -3;

            this.X += this.deltaX;

            if ((this.Y - this.RadiusY) <= 0)
                this.deltaY = 3;

            if ((this.Y - this.RadiusY) >= height)
                this.deltaY = -3;

            this.Y += this.deltaY;
        }

        public void IsTouchRacket(Racket r)
        {
            Rectangle ballBorder = new Rectangle((int)(this.X - this.RadiusX), (int)this.Y, this.RadiusX * 2, this.RadiusX);
            Rectangle racketBorder = new Rectangle((int)(r.X - r.Width / 2), (int)(r.Y - r.Height / 2), r.Width, r.Height);

            if (ballBorder.IntersectsWith(racketBorder))
            {
                deltaY = -3;

                if (this.X < r.X - r.Width / 2)
                    this.deltaX = -3;

                if (this.X > r.X + r.Width / 2)
                    this.deltaX = 3;
            }
        }
    }

    [Serializable]
    public abstract class myRectangle : Shapes
    {
        int width;
        int height;

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }
    }

    [Serializable]
    public class Racket : myRectangle
    {
        public Racket(float xVal, float yVal, int widVal, int heiVal)
        {
            X = xVal;
            Y = yVal;
            Width = widVal;
            Height = heiVal;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(Color.LightGray);
            Pen pen = new Pen(Color.LightGray, 2);
            g.FillRectangle(br, X - Width / 2, Y - Height / 2, Width, Height);
            g.DrawRectangle(pen, X - Width / 2, Y - Height / 2, Width, Height);
        }

        public bool isEllipseTouch(Ellipse c)
        {
            Rectangle coinBorder = new Rectangle((int)(c.X - c.RadiusX), (int)c.Y, c.RadiusX, c.RadiusY);
            Rectangle racketBorder = new Rectangle((int)(this.X - this.Width / 2), (int)(this.Y - this.Height / 2), this.Width, this.Height);

            if (coinBorder.IntersectsWith(racketBorder))
                return true;

            return false;
        }

        public bool isDiamondTouch(Diamond d)
        {
            Rectangle diamondBorder = new Rectangle(d.PointX - 6, d.PointY, 12, 15);
            Rectangle racketBorder = new Rectangle((int)(this.X - this.Width / 2), (int)(this.Y - this.Height / 2), this.Width, this.Height);

            if (diamondBorder.IntersectsWith(racketBorder))
                return true;

            return false;
        }
    }

    [Serializable]
    public class Brick : myRectangle
    {
        int num_to_hit;
        bool hasDiamond;
        Color c;

        public Brick(float xVal, float yVal, int widVal, int heiVal, int hitVal, Color cVal)
        {
            X = xVal;
            Y = yVal;
            Width = widVal;
            Height = heiVal;
            num_to_hit = hitVal;
            c = cVal;
            hasDiamond = false;
        }

        public int Num_to_hit
        {
            get
            {
                return num_to_hit;
            }

            set
            {
                num_to_hit = value;
            }
        }

        public Color C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public bool HasDiamond
        {
            get
            {
                return hasDiamond;
            }

            set
            {
                hasDiamond = value;
            }
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(this.c);
            Pen pen = new Pen(Color.White, 1);
            g.FillRectangle(br, X - Width / 2, Y - Height / 2, Width, Height);
            g.DrawRectangle(pen, X - Width / 2, Y - Height / 2, Width, Height);
        }

        public bool IsTouchBall(Ball c)
        {
            Rectangle brickBorder = new Rectangle((int)(this.X - this.Width / 2), (int)(this.Y - this.Height / 2), this.Width, this.Height);
            Rectangle ballBorder = new Rectangle((int)(c.X - c.Radius), (int)(c.Y - c.Radius), c.Radius * 2, c.Radius * 2);

            if (brickBorder.IntersectsWith(ballBorder))
            {
                if (c.PowerHit == 1)
                    this.num_to_hit--;
                
                else
                    this.num_to_hit -= 2;

                if (c.Y > this.Y)
                    c.DeltaY = 3;

                else
                    c.DeltaY = -3;

                if (c.X < this.X - this.Width / 2)
                    c.DeltaX = -3;

                if (c.X > this.X + this.Width / 2)
                    c.DeltaX = 3;

                return true;
            }

            return false;
        }
    }

    [Serializable]
    public class Diamond : Shapes
    {
        Point[] points;

        public Diamond(int x, int y)
        {
            points = new Point[6];
            points[0] = new Point(x, y);
            points[1] = new Point(x - 6, y + 5);
            points[2] = new Point(x - 6, y + 10);
            points[3] = new Point(x, y + 15);
            points[4] = new Point(x + 6, y + 10);
            points[5] = new Point(x + 6, y + 5);
        }

        public int PointX
        {
            get
            {
                return points[0].X;
            }
        }

        public int PointY
        {
            get
            {
                return points[0].Y;
            }
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(Color.FromArgb(this.rnd_color(), this.rnd_color(), this.rnd_color()));
            Pen pen = new Pen(Color.White, 1);
            g.FillPolygon(br, points);
            g.DrawPolygon(pen, points);
        }

        public int rnd_color()
        {
            Random r = new Random();
            return r.Next(0, 256);
        }

        public void move_diamond()
        {
            for (int i = 0; i < 6; i++)
                points[i].Y += 1;
        }
    }

    [Serializable]
    public class ShapeList
    {
        protected List<Shapes> shapes;
        protected int score;
        protected int life;
        protected int countDiamondsHit;

        public ShapeList()
        {
            shapes = new List<Shapes>();
            score = 0;
            life = 3;
            countDiamondsHit = 0;
        }

        public int Capacity
        {
            get
            {
                return shapes.Count;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        public int Life
        {
            get
            {
                return life;
            }

            set
            {
                life = value;
            }
        }

        public int CountDiamondsHit
        {
            get
            {
                return countDiamondsHit;
            }

            set
            {
                countDiamondsHit = value;
            }
        }

        public Shapes this[int index]
        {
            get
            {
                if (index >= shapes.Count)
                    return (Shapes)null;

                return (Shapes)shapes[index];
            }

            set
            {
                if (index < shapes.Count)
                    shapes[index] = value;
            }
        }

        public void DrawAll(Graphics g)
        {
            for (int i = 0; i < shapes.Count; i++)
                shapes[i].Draw(g);
        }

        public void Add(Shapes s)
        {
            shapes.Add(s);
        }

        public void createList(int objectsNum, int width, int height, int hitsNum, Color c)
        {
            int xVal = width / objectsNum / 2, yVal = height;
            int diamovdInd = this.rndIndex(objectsNum);
            Brick b;

            for (int i = 0; i < objectsNum; i++)
            {
                b = new Brick(xVal, yVal, 98, 20, hitsNum, c);

                if (i == diamovdInd)
                    b.HasDiamond = true;

                this.shapes.Add(b);
                xVal += width / objectsNum;
            }
        }

        public void RemoveBrick(int index)
        {
            Ellipse e;
            Diamond d;
            
            if (((Brick)shapes[index]).Num_to_hit <= 0)
            {
                if (((Brick)shapes[index]).HasDiamond)
                {
                    d = new Diamond((int)((Brick)shapes[index]).X, (int)((Brick)shapes[index]).Y);
                    this.Add(d);
                }

                else
                {
                    e = new Ellipse(((Brick)shapes[index]).X, ((Brick)shapes[index]).Y, 10, 14, Color.Pink);
                    this.Add(e);
                }

                this.shapes.RemoveAt(index);
            }
        }

        public int countBricks()
        {
            int count = 0;

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].GetType().Name == "Brick")
                    count++;
            }

            return count;
        }

        public int checkIsPassLine(int yVal)
        {
            if ((this.shapes[1].Y > yVal) && (this.life > 0))
            {
                this.life--;
                this.shapes[1].X = this.shapes[0].X;
                this.shapes[1].Y = this.shapes[0].Y - 18;
            }

            else if (this.life == 0)
                this.shapes.RemoveAt(1);

            return this.life;
        }

        public bool checkIsTouchBall()
        {
            for (int i = 2; i < this.countBricks() + 2; i++)
            {
                if (((Brick)shapes[i]).IsTouchBall((Ball)shapes[1]) && ((Brick)shapes[i]).Num_to_hit <= 0)
                {
                    this.RemoveBrick(i);
                    return true;
                }
            }

            return false;
        }

        public void moveObjects(int height, int width)
        {
            for (int i = 1; i < this.Capacity; i++)
            {
                switch (this.shapes[i].GetType().Name)
                {
                    case "Ball":
                        ((Ball)this.shapes[i]).move_ball(height, width);
                        break;
                    case "Ellipse":
                        ((Ellipse)this.shapes[i]).move_ellipse();
                        break;
                    case "Diamond":
                        ((Diamond)this.shapes[i]).move_diamond();
                        break;
                    default:
                        break;
                }
            }    
        }

        public void checkIsObjectTouchRacket()
        {
            for (int i = this.countBricks() + 2; i < this.Capacity; i++)
            {
                switch (this.shapes[i].GetType().Name)
                {
                    case "Ellipse":
                        if (((Racket)shapes[0]).isEllipseTouch((Ellipse)shapes[i]))
                        {
                            this.Score += 5;
                            shapes.RemoveAt(i);
                        }
                        break;
                    case "Diamond":
                        if (((Racket)shapes[0]).isDiamondTouch((Diamond)shapes[i]))
                        {
                            this.countDiamondsHit++;
                            shapes.RemoveAt(i);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public void checkIsObjectPassLine(int height)
        {
            for (int i = this.countBricks() + 2; i < this.Capacity; i++)
            {
                if (shapes[i].Y >= height)
                    shapes.RemoveAt(i);
            }
        }

        public int rndIndex(int numBricks)
        {
            Random rnd = new Random();
            return rnd.Next(0, numBricks);
        }

        public void changeBallColor()
        {
            if (this.CountDiamondsHit == 2)
            {
                ((Ball)shapes[1]).Col = Color.Aquamarine;
                ((Ball)shapes[1]).PowerHit = 2;

                for (int i = 2; i < this.countBricks(); i++)
                    ((Brick)shapes[i]).HasDiamond = false;
            }
        }
    }
}