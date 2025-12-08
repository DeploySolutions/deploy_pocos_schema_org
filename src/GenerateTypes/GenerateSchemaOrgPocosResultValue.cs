using Deploy.LaunchPad.Util;
using Deploy.LaunchPad.Util.CommandLine;
using Deploy.LaunchPad.Util.Methods;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deploy.GenerateSchemaOrgPocos
{
    public partial class GenerateSchemaOrgPocosResultValue : LaunchPadMethodResultValueBase
    {
        
        public required string DestinationFolderPath { get; set; }
        
        public GenerateSchemaOrgPocosResultValue()
        {
        }
    }
}
