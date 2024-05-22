using System;

namespace lab7
{
    internal class Vector
    {
        private int a;
        private int b;
        private int c;

        public Vector(int a, int b, int c)
        {
            if (!(int.TryParse(a.ToString(),out a)|| int.TryParse(b.ToString(), out b)||int.TryParse(c.ToString(), out c)))
            {
                throw new ArgumentException("Значения компонентов вектора должны быть целыми числами по условию.");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public override string ToString()
        {
            return ("Vector = (" + a + ", " + b + ", " + c + ")");
        }
        public int this[int index]
        {
            get
            {
                if (index == 0) return a;
                else if (index == 1) return b;
                else if (index == 2) return c;
                else throw new IndexOutOfRangeException();
            }
        }
        public static Vector operator +(Vector vector1,Vector vector2)
        {
            return new Vector(vector1.a + vector2.a, vector1.b + vector2.b, vector1.c + vector2.c);
        }
        public static Vector operator -(Vector vector1,Vector vector2)
        {
            return new Vector(vector1.a-vector2.a,vector1.b-vector2.b,vector1.c-vector2.c);
        }
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.a*vector2.a, vector1.b*vector2.b, vector1.c*vector2.c);
        }
        public static Vector operator *(Vector vector, int number) 
        {
            return new Vector(vector.a*number,vector.b*number,vector.c*number);
        } 
        public static Vector operator /(Vector vector, int number)
        {
            if (number == 0) return vector;
            else return new Vector(vector.a / number, vector.b / number, vector.c / number);
        }
        public static Vector operator ++(Vector vector)
        {
            return new Vector(vector.a + 1, vector.b + 1, vector.c + 1);
        }
        public static Vector operator --(Vector vector)
        {
            return new Vector(vector.a - 1, vector.b - 1, vector.c - 1);
        }
        public static bool operator ==(Vector vector1, Vector vector2)
        {
            return (vector1.a == vector2.a && vector1.b == vector2.b && vector1.c == vector2.c);
        }
        public static bool operator !=(Vector vector1, Vector vector2)
        {
            return (vector1.a != vector2.a && vector1.b != vector2.b && vector1.c != vector2.c);
        }
        private static double Length(Vector vector)
        {
            return (Math.Sqrt(Math.Pow((double)vector.a, 2) + Math.Pow((double)vector.b, 2) + Math.Pow((double)vector.c, 2)));
        }
        public static bool operator >(Vector vector1, Vector vector2)
        {
            return (Length(vector1) > Length(vector2));
        }
        public static bool operator <(Vector vector1, Vector vector2)
        {
            return (Length(vector1) < Length(vector2));
        }
        public static bool operator true(Vector vector)
        {
            if (vector.a != 0 && vector.b != 0 && vector.c != 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(Vector vector)
        {
            if (vector.a == 0 && vector.b == 0 && vector.c == 0)
            {
                return false;
            }
            return true;
        }

        public static explicit operator double(Vector vector)
        {
            return Length(vector);
        }
        public static explicit operator Vector(double number)
        {
            return new Vector((int)number, (int)number, (int)number);
        }
        public static explicit operator int(Vector vector)
        {
            return (Math.Abs(vector.a) + Math.Abs(vector.b) + Math.Abs(vector.c));
        }
        public static explicit operator Vector(int number)
        {
            return new Vector(number, number, number);
        }
        
    }
}
