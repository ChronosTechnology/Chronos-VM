using ChronosTech;
using ChronosTech.Vector;
using Xunit;

namespace Chronos_VM_Libray.Test
{
    public class Vector3Test
    {
        [Fact]
        public void ZeroArgContructorTest()
        {
            Vector3<int> vector = new Vector3<int>(); 

            Assert.Equal(vector.X, 0);
            Assert.Equal(vector.Y, 0);
            Assert.Equal(vector.Z, 0);
        }

        [Fact]
        public void OneArgContructorTest()
        {
            Vector3<int> vector = new Vector3<int>(1);

            Assert.Equal(vector.X, 1);
            Assert.Equal(vector.Y, 0);
            Assert.Equal(vector.Z, 0);
        }

        [Fact]
        public void TwoArgContructorTest()
        {
            Vector3<int> vector = new Vector3<int>(1,2);

            Assert.Equal(vector.X, 1);
            Assert.Equal(vector.Y, 2);
            Assert.Equal(vector.Z, 0);
        }

        [Fact]
        public void ThreeArgContructorTest()
        {
            Vector3<int> vector = new Vector3<int>(1, 2, 3);

            Assert.Equal(vector.X, 1);
            Assert.Equal(vector.Y, 2);
            Assert.Equal(vector.Z, 3);
        }

        [Fact]
        public void EqualityTest()
        {
            Vector3<int> a = new Vector3<int>();
            Vector3<int> b = new Vector3<int>();
            Vector3<int> c = new Vector3<int>();

            // Standard tests
            // see: http://msdn.microsoft.com/en-us/library/ms173147(v=vs.80).aspx
            Assert.True(a.Equals(a));
            Assert.Equal(a.Equals(b), b.Equals(a));
            Assert.Equal(a.Equals(b) && b.Equals(c), a.Equals(c));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualityVectorTest()
        {
            Vector3<int> a = new Vector3<int>();
            Vector3<int> b = new Vector3<int>(1,0,0);
            Vector3<int> c = new Vector3<int>(0,1,0);
            Vector3<int> d = new Vector3<int>(0,0,1);
            Vector3<int> e = new Vector3<int>(0,0,1);

            Assert.False(a.Equals(b));
            Assert.False(a.Equals(c));
            Assert.False(a.Equals(d));
            
            Assert.True(d.Equals(e));
        }

        [Fact]
        public void EqualityOperatorTest()
        {
            Vector3<int> a = new Vector3<int>();
            Vector3<int> b = new Vector3<int>(1, 0, 0);
            Vector3<int> c = new Vector3<int>(0, 1, 0);

            Assert.False(a == b);
            Assert.True(a == a);

        }

        [Fact]
        public void CrossProduct1Test()
        {
            Vector3<double> a = new Vector3<double>(1d,0d,0d);
            Vector3<double> b = new Vector3<double>(0d,1d,0d);

            Vector3<double> c = a*b;

            Assert.Equal(c, new Vector3<double>(0,0,1));
        }

        [Fact]
        public void CrossProduct2Test()
        {
            Vector3<double> a = new Vector3<double>(0d, 1d, 0d);
            Vector3<double> b = new Vector3<double>(0d, 0d, 1d); 

            Vector3<double> c = a * b;

            Assert.Equal(c, new Vector3<double>(1, 0, 0));
        }

        [Fact]
        public void CrossProduct3Test()
        {
            Vector3<double> a = new Vector3<double>(1d, 0d, 0d);
            Vector3<double> b = new Vector3<double>(0d, 0d, 1d);

            Vector3<double> c = a * b;

            Assert.Equal(c, new Vector3<double>(0, -1, 0));
        }

        [Fact]
        public void CrossProduct4Test()
        {
            Vector3<double> a = new Vector3<double>(1.0, 2.0, 3.0);
            Vector3<double> b = new Vector3<double>(3.0, 2.0, 3.0);

            Vector3<double> c = a * b;

            Assert.Equal(c, new Vector3<double>(0, 6, -4));
        }

        [Fact]
        public void ScalarProductTest()
        {
            Vector3<double> a = new Vector3<double>(1.0, 2.0, 3.0);
            

            Vector3<double> c = a * 2;

            Assert.Equal(c, new Vector3<double>(2, 4, 6));
        }

        [Fact]
        public void AddTest()
        {
            Vector3<double> a = new Vector3<double>(1.0, 2.0, 3.0);
            Vector3<double> b = new Vector3<double>(3.0, 2.0, 3.0);

            Vector3<double> c = a + b;

            Assert.Equal(c, new Vector3<double>(4, 4, 6));
        }

        [Fact]
        public void SubtractTest()
        {
            Vector3<double> a = new Vector3<double>(1.0, 2.0, 3.0);
            Vector3<double> b = new Vector3<double>(3.0, 2.0, 3.0);

            Vector3<double> c = a - b;

            Assert.Equal(c, new Vector3<double>(-2, 0, 0));
        }
    }
}
