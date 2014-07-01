namespace ChronosTech.Vector
{
    public class Vector2<T>
    {
        public Vector2() : this(default(T), default(T))
        {

        }

        public Vector2(T x) : this(x, default(T))
        {

        }

        public Vector2(T x, T y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets or sets the X component of the vector.
        /// </summary>
        public T X { get; set; }

        /// <summary>
        /// Gets or sets the Y component of the vector.
        /// </summary>
        public T Y { get; set; }
    }
}