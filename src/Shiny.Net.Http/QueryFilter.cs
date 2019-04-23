﻿using System;
using System.Collections.Generic;


namespace Shiny.Net.Http
{
    public class QueryFilter
    {
        public List<string> Ids { get; set; } = new List<string>();
        public DirectionFilter Direction { get; set; } = DirectionFilter.Both;
        //public HttpTransferStateFilter States { get; set; } = HttpTransferStateFilter.None;


        //public QueryFilter SetStates(HttpTransferStateFilter states)
        //{
        //    this.States = states;
        //    return this;
        //}


        public QueryFilter SetDirection(DirectionFilter direction)
        {
            this.Direction = direction;
            return this;
        }


        public QueryFilter Add(params string[] ids)
        {
            this.Ids.AddRange(ids);
            return this;
        }
    }
}
