﻿using Antlr4.Runtime;
using System.Collections.Generic;
using System.Linq;

namespace Cool.AST
{
    class ClassNode : ASTNode
    {
        public TypeNode TypeClass => Children[0] as TypeNode;

        public TypeNode TypeInherits => Children[1] as TypeNode;

        public List<FeatureNode> FeatureNodes => Children.Skip(2).Cast<FeatureNode>().ToList();

        public ClassNode(ParserRuleContext context) : base(context)
        {
        }

    }
}
