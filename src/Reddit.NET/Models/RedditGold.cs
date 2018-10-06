﻿using Newtonsoft.Json;
using Reddit.NET.Models.Structures;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.NET.Models
{
    public class RedditGold : BaseModel
    {
        internal override RestClient RestClient { get; set; }

        public RedditGold(string refreshToken, string accessToken, RestClient restClient) : base(refreshToken, accessToken, restClient) { }

        public object Gild(string fullname)
        {
            return JsonConvert.DeserializeObject(ExecuteRequest("api/v1/gold/gild/" + fullname, Method.POST));
        }

        public object Give(string username, int months)
        {
            RestRequest restRequest = PrepareRequest("api/v1/gold/give/" + username, Method.POST);

            restRequest.AddParameter("months", months);

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }
    }
}
