using System;
using System.Collections.Generic;

namespace WebApi
{
    public class Reserve
    {
        public int reserve_id { get; set; }
        
        public DateTime start_datetime { get; set; }
        
        public DateTime end_datetime { get; set; }
        
        public int meeting_id { get; set; }
        
        public List<int> sankasha { get; set; }
        
    }
}