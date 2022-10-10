using PathFinder.SearchMethods;

namespace PathFinder
{
    public class GridBFS:GridSearch
    {
        public GridBFS()
        {
            Type = ISearchResponse.SearchTypes.BFS; 
        }
        public ISearchResponse BFS(string[][] grid, int[] startPosition, int[] destinationPosition, ISearchResponse response)
        {
            var steps = new List<int[]>();
            var visited = "#";
            var queue = new Queue<(int[], int, string)>();
            queue.Enqueue((startPosition,0,""));
            while(queue.Count > 0)
            { 
                var current = queue.Dequeue();
                var currentPosition = current.Item1;
                var currentDistance = current.Item2;
                var currentPath = current.Item3;    
              
                steps.Add(currentPosition);
                if (grid[currentPosition[0]][currentPosition[1]] == visited )continue;
                grid[currentPosition[0]][currentPosition[1]] = visited;
                if (currentPosition[0] == destinationPosition[0] && currentPosition[1] == destinationPosition[1])
                {
                    response.Distance = currentDistance;
                    response.Path = currentPath;
                    response.Steps = steps;
                    response.Success = true;
                    response.SearchType = Type;
                    return response;
                }
                    

                if (ValidPosition(grid, currentPosition[0] - 1, currentPosition[1]) &&
                    grid[currentPosition[0] - 1][currentPosition[1]] != visited) {
                    queue.Enqueue((new int[2] { currentPosition[0] - 1, currentPosition[1] }, currentDistance + 1,currentPath+"U"));
                }

                if (ValidPosition(grid, currentPosition[0], currentPosition[1] + 1) &&
                    grid[currentPosition[0]][currentPosition[1] + 1] != visited)
                {
                    queue.Enqueue((new int[2] { currentPosition[0], currentPosition[1] + 1 }, currentDistance + 1,currentPath+"R"));
                }

                if (ValidPosition(grid, currentPosition[0] + 1, currentPosition[1]) &&
                    grid[currentPosition[0] + 1][currentPosition[1]] != visited)
                {
                    queue.Enqueue((new int[2] { currentPosition[0] + 1, currentPosition[1] }, currentDistance + 1, currentPath+"D"));
                }
                if (ValidPosition(grid, currentPosition[0], currentPosition[1] - 1) &&
                    grid[currentPosition[0]][currentPosition[1] - 1] != visited)
                {
                    queue.Enqueue((new int[2] { currentPosition[0], currentPosition[1] - 1 }, currentDistance + 1, currentPath+"L"));
                }
            }
            response.Distance = -1;
            response.Steps = steps;
            response.Success = false;
            response.SearchType = Type;          
            return response;

        }
        
    }
   
}
