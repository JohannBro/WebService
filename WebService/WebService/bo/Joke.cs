﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.bo
{
    public class Joke
    {  
            public object[] Categories { get; set; }
            public string Created_at { get; set; }
            public string Icon_url { get; set; }
            public string Id { get; set; }
            public string Updated_at { get; set; }
            public string Url { get; set; }
            public string Value { get; set; }
    }
}
