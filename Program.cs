using InputUtilitys;
namespace Ex27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var width = InputUtility.InputFloat("boxの幅");
            var height = InputUtility.InputFloat("boxの高さ");
            var depth = InputUtility.InputFloat("boxの奥行");
            Box box = new Box(width, height, depth);
            Console.WriteLine($"boxの表面積＝{box.GetBoxSurface()}, boxの体積={box.GetBoxVolume()}");

            var radius = InputUtility.InputFloat("円柱の半径");
            var height2 = InputUtility.InputFloat("円柱の高さ");
            Cylinder cylinder = new Cylinder(radius, height2);
            Console.WriteLine($"円柱の表面積＝{cylinder.GetCylinderSurface():f3}, 円柱の体積＝{cylinder.GetCylinderVolume():f3}");

            var radius2 = InputUtility.InputFloat("球の半径");
            Sphere sphere = new Sphere(radius2);
            Console.WriteLine($"球の表面積＝{sphere.GetSphereSurface():f3}, 球の体積＝{sphere.GetSphereVolume():f3}");

            var bottom = InputUtility.InputFloat("三角形の底辺"); 
            var top = InputUtility.InputFloat("三角形の高さ");
            TriangularPrism triangularprism = new TriangularPrism(bottom, top, height);
            Console.WriteLine($"三角柱の表面積={triangularprism.GetTriangularPrismSurface():f3}, 三角柱の体積={triangularprism.GetTriangularPrismVolume()}");
        }
        class Box
        {
            private float width;
            private float height;
            private float depth;
            public Box(float w, float h, float d)
            {
                this.width = w;
                this.height = h;
                this.depth = d;
            }
            public float GetBoxVolume()
            {
                return width * height * depth;
            }
            public float GetBoxSurface()
            {
                return (width * height + height * depth + depth * width) * 2;
            }
        }
        class Cylinder
        {
            private float radius;
            private float height2;

            public Cylinder(float r, float h)
            {
                this.radius = r;
                this.height2 = h;
            }

            public float GetCylinderVolume()
            {
                return radius * radius * (float)Math.PI * height2;
            }
            public float GetCylinderSurface()
            {
                return (radius * radius * (float)Math.PI) * 2 + (radius * 2 * (float)Math.PI * height2);
            }
        }
        class Sphere
        {
            private float radius2;
            public Sphere(float r)
            {
                this.radius2 = r;
            }

            public float GetSphereVolume()
            {
                return 4 * (float)Math.PI / 3 * radius2 * radius2 * radius2;
            }
            public float GetSphereSurface()
            {
                return (4 * (float)Math.PI * radius2 * radius2);
            }
        }
        class TriangularPrism

        {
            private float bottom;
            private float top;
            private float height;

            public TriangularPrism(float r, float t, float h)
            {
                this.bottom = r;
                this.top = t;
                this.height = h;
            }

            public float GetTriangularPrismVolume()
            {
                return (bottom * top) / 2 * height;
            }
            public float GetTriangularPrismSurface()
            {
                return bottom * top + (bottom + top + (float)Math.Sqrt(bottom * bottom + top * top)) * height;
            }
        }
    }
}