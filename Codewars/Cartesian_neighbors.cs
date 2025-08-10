namespace Codewars;

public class Cartesian_neighbors
{
    public static IEnumerable<int[]> cartesianNeighbor(int x, int y){
        var result = new List<int[]>
        {
            new [] {x-1, y-1}, new []{x-1, y}, new []{x-1, y+1}, new []{x, y-1}, new []{x, y+1},
            new [] {x+1, y-1},new [] {x+1, y}, new [] {x+1, y+1}
        };
        
        return result;
    }
}