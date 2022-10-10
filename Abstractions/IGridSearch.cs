using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Abstractions
{
    public interface IGridSearch
    {
        public bool ValidPosition(string[][] grid, int row, int column);
        public ISearchResponse.SearchTypes Type { get; set; }

    }
}
