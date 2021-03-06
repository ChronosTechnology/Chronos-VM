﻿using System;
using System.Collections.Generic;

namespace ChronosTech.Vector
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Computes the Cross product of two vectors. If the type of the vector does not support multiplication a 
        /// exception will be thrown at runtime.
        /// </summary>
        /// <param name="v1">Vector 1</param>
        /// <param name="v2">Vector 2</param>
        /// <returns>Cross product of the two vectors</returns>
        public static Vector3<T> operator *(Vector3<T> v1, Vector3<T> v2)
        {
            return new Vector3<T>((dynamic)v1.Y * v2.Z - (dynamic)v1.Z * v2.Y, 
                                  (dynamic)v1.Z * v2.X - (dynamic)v1.X * v2.Z , 
                                  (dynamic)v1.X * v2.Y - (dynamic)v1.Y * v2.X);
        }

        /// <summary>
        /// Computes the multiplication of a vector with a scalar value.
        /// </summary>
        /// <param name="v1">vector</param>
        /// <param name="scalar">Scalar value</param>
        /// <returns><typeparam name="Vector3">Vector</typeparam></returns>
        public static Vector3<T> operator *(Vector3<T> v1, double scalar)
        {
            return new Vector3<T>((dynamic)v1.X * scalar, (dynamic)v1.Y * scalar, (dynamic)v1.Z * scalar);    
        }

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector3<T> operator +(Vector3<T> v1, Vector3<T> v2)
        {
            return new Vector3<T>((dynamic)v1.X + v2.X, (dynamic)v1.Y + v2.Y, (dynamic)v1.Z + v2.Z);
        }

        /// <summary>
        /// Subtracts two vectors.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector3<T> operator -(Vector3<T> v1, Vector3<T> v2)
        {
            return new Vector3<T>((dynamic)v1.X - v2.X, (dynamic)v1.Y - v2.Y, (dynamic)v1.Z - v2.Z);
        }

        /// <summary>
        /// Divides the vector by a scalar value
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector3<T> operator /(Vector3<T> v1, double scalar)
        {
            return new Vector3<T>((dynamic)v1.X / scalar, (dynamic)v1.Y / scalar, (dynamic)v1.Z / scalar); 
        }

        /// <summary>
        /// Computes the inner product of two vectors.
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static double Dot(Vector3<T> vector1, Vector3<T> vector2)
        {
            return (((dynamic) vector1.X*vector2.X) + ((dynamic) vector1.Y*vector2.Y) + ((dynamic) vector1.Z*vector2.Z));
        }

        /// <summary>
        /// Returns the magnitude of the vector. Also called the length of the vector. 
        /// </summary>
        /// <returns>Double representing the length of the vector.</returns>
        public double Magnitude()
        {
            return Math.Sqrt(Dot(this, this));
        }

        /// <summary>
        /// Return the normalized vector.
        /// </summary>
        /// <returns>Normalized vector.</returns>
        public Vector3<T> Normalize()
        {
            return this / Magnitude();
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
