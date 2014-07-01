using System.Collections.Generic;

namespace Chronos
{
    public class Vector3<T>
    {
        public Vector3()
            : this(default(T), default(T), default(T))
        {
            
        }

        public Vector3(T x)
            : this(x, default(T), default(T))
        {
            
        }
        public Vector3(T x, T y)
            : this(x, y, default(T))
        {

        }

        public Vector3(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Vector3<T> that = obj as Vector3<T>;

            if (that == null)
            {
                return false;
            }

            return (EqualityComparer<T>.Default.Equals(X, that.X)) && 
                        (EqualityComparer<T>.Default.Equals(Y, that.Y)) && 
                        (EqualityComparer<T>.Default.Equals(Z, that.Z));
        }

        /// <summary>
        /// Gets or sets the X component of the vector.
        /// </summary>
        public T X { get; set; }

        /// <summary>
        /// Gets or sets the Y component of the vector.
        /// </summary>
        public T Y { get; set; }

        /// <summary>
        /// Gets or sets the Z component of the vector.
        /// </summary>
        public T Z { get; set; }
    }
}
