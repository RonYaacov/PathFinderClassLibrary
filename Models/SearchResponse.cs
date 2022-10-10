using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Models
{
    public class SearchResponse: ISearchResponse
    {
        public int Distance { get; set; }
        public List<int[]> Steps { get; set; }
        public bool Success { get; set; }
        public ISearchResponse.SearchTypes? SearchType { get; set; }
        public string Path { get; set; }

        public SearchResponse(int distanse,List<int[]> steps,
            bool success, ISearchResponse.SearchTypes? searchType,string path)
        {
            Distance = distanse;        
            Steps = steps;  
            Success = success;
            SearchType = searchType;
            Path = path;
        } 
    }
}
