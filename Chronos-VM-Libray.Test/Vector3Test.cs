using Chronos;
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
    }
}
