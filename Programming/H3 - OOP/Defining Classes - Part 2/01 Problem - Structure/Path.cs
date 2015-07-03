/*Problem 4. Path

Create a class Path to hold a sequence of points in the 3D space.
Create a static class PathStorage with static methods to save and load paths from a text file.
Use a file format of your choice.
 */

namespace ProblemStructure
{
    using System.Collections.Generic;

    class Path
    {
        public List<Point3D> path = new List<Point3D>();

        public void AddPoint(Point3D point)
        {
            path.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            path.Remove(point);
        }

        // clear path collection ???
        private void ClearPointCollection()
        {
            path.Clear();
        }

    }
}
