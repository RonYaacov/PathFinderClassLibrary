using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public interface ISearchResponse
    {
        enum SearchTypes { BFS,DFS}
        SearchTypes? SearchType { get; set; }
        string Path { get; set; }   

        List<int[]> Steps { get; set; }
        int Distance { get; set; }  
        bool Success { get; set; }  
    }
}
