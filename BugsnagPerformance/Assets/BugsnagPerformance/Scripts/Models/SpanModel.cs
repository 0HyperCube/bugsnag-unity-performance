﻿using System;
using System.Collections.Generic;

namespace BugsnagUnityPerformance
{
    [Serializable]
    internal class SpanModel
    {
        public string name;
        public int kind;
        public string spanId;
        public string traceId;
        public string startTimeUnixNano;
        public string endTimeUnixNano;
        public List<AttributeModel> attributes = new List<AttributeModel>();

        public SpanModel(Span span)
        {
            name = span.Name;
            kind = (int)span.Kind;
            spanId = span.Id;
            traceId = span.TraceId.Replace("-",string.Empty);
            startTimeUnixNano = (span.StartTime.Ticks * 100).ToString();
            endTimeUnixNano = (span.EndTime.Ticks * 100).ToString();
            foreach (var attr in span.Attributes)
            {
                if (!string.IsNullOrEmpty(attr.key))
                {
                    attributes.Add(attr);
                }
            }
        }
    }
}