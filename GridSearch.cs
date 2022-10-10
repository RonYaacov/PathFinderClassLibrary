using PathFinder.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.SearchMethods
{
    public class GridSearch:IGridSearch
    {
        public ISearchResponse.SearchTypes Type { get; set; }

        public bool ValidPosition(string[][] grid, int row, int column)
        {
            if (row >= 0 && row < grid.Length && column >= 0 && column < grid[row].Length) return true;
            return false;
        }

      
    }
}
