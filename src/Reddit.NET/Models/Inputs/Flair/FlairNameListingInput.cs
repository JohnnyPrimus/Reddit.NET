﻿using Newtonsoft.Json;
using System;

namespace Reddit.Models.Inputs.Flair
{
    [Serializable]
    public class FlairNameListingInput : SrListingInput
    {
        /// <summary>
        /// a user by name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// List of flairs.
        /// </summary>
        /// <param name="name">a user by name</param>
        /// <param name="after">fullname of a thing</param>
        /// <param name="before">fullname of a thing</param>
        /// <param name="limit">the maximum number of items desired (default: 25, maximum: 1000)</param>
        /// <param name="count">a positive integer (default: 0)</param>
        /// <param name="show">(optional) the string all</param>
        /// <param name="srDetail">(optional) expand subreddits</param>
        public FlairNameListingInput(string name = "", string after = "", string before = "", int limit = 25, int count = 0,
            string show = "all", bool srDetail = false)
        {
            Name = name;
            After = after;
            Before = before;
            Limit = limit;
            Count = count;
            Show = show;
            SrDetail = srDetail;
        }
    }
}
