﻿using System;
using System.Text;
using Newtonsoft.Json;

namespace Slack.NetStandard.Messages.Elements
{
    public class Option
    {
        [JsonProperty("text")]
        public PlainText Text { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("url",NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }
}
