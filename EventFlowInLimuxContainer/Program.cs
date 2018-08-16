using System;
using Microsoft.Diagnostics.EventFlow;

namespace EventFlowInLimuxContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipeline = DiagnosticPipelineFactory.CreatePipeline("eventFlowConfig.json");
        }
    }
}
