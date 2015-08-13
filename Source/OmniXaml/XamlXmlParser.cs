﻿namespace OmniXaml
{
    using System.Collections.Generic;
    using System.IO;
    using Glass;
    using Parsers.ProtoParser;
    using Parsers.XamlNodes;

    public class XamlXmlParser : IXamlParser
    {
        private readonly IObjectAssembler objectAssembler;
        private readonly IProtoParser protoParser;
        private readonly IXamlInstructionParser parser;

        public XamlXmlParser(PhaseParserKit phaseParserKit)  
        {
            Guard.ThrowIfNull(phaseParserKit, nameof(phaseParserKit));

            objectAssembler = phaseParserKit.ObjectAssembler;        
            protoParser = phaseParserKit.ProtoParser;
            parser = phaseParserKit.Parser;
        }

        public object Parse(Stream stream)
        {
            var xamlProtoNodes = protoParser.Parse(stream);
            var xamlNodes = parser.Parse(xamlProtoNodes);
            return Parse(xamlNodes);
        }

        private object Parse(IEnumerable<XamlInstruction> xamlNodes)
        {
            foreach (var xamlNode in xamlNodes)
            {
                objectAssembler.Process(xamlNode);
            }

            return objectAssembler.Result;
        }
    }
}