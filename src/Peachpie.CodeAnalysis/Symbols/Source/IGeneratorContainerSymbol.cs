﻿using Devsense.PHP.Syntax.Ast;
using System.Collections.Generic;

namespace Pchp.CodeAnalysis.Symbols
{

    // Replace with SynthesizedManager, not sure how it works
    // Port lambda to use the same infrastructure as well

    //Could get merged with ILambdaContainerSymbol
    internal interface IGeneratorContainerSymbol
    {
        /// <summary>
        /// Adds declared generator into this container.
        /// </summary>
        /// <param name="routine"></param>
        void AddGenerator(SourceGeneratorSymbol routine);

        /// <summary>
        /// Gets generator functions declared within this container.
        /// </summary>
        IEnumerable<SourceGeneratorSymbol> Generators { get; }

        /// <summary>
        /// Resolves lambda symbol for given syntax node.
        /// </summary>
        SourceGeneratorSymbol ResolveGeneratorSymbol(YieldEx expr);
    }
}
