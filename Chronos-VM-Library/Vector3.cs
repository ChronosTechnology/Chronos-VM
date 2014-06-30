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
