using Deploy.LaunchPad.Util;
using Deploy.LaunchPad.Util.CommandLine;
using Deploy.LaunchPad.Util.Methods;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deploy.LaunchPad.FactoryLite.Actions.GeneratePowerPoint
{
    public partial class GenerateSchemaOrgPocosInputValue : LaunchPadMethodResultValueBase
    {

        public required string SourceFilePath { get; set; }

        
        public required string DestinationFolderPath { get; set; }


        public GenerateSchemaOrgPocosInputValue()
        {
        }
    }
}
