﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CoffeeScriptPreprocessor.cs" company="James South">
//   Copyright (c) James South.
//   Licensed under the Apache License, Version 2.0.
// </copyright>
// <summary>
//   The coffee script pre-processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Cruncher.Preprocessors.Coffee
{
    /// <summary>
    /// The coffee script pre-processor.
    /// </summary>
    public class CoffeeScriptPreprocessor : IPreprocessor
    {
        /// <summary>
        /// Gets the extensions that this filter processes.
        /// </summary>
        public string[] AllowedExtensions
        {
            get
            {
                return new[] { ".COFFEE" };
            }
        }

        /// <summary>
        /// Transforms the content of the given string.
        /// </summary>
        /// <param name="input">The input string to transform.</param>
        /// <param name="path">The path to the given input string to transform.</param>
        /// <param name="cruncher">The cruncher that is running the transform.</param>
        /// <returns>The transformed string.</returns>
        public string Transform(string input, string path, CruncherBase cruncher)
        {
            CoffeeScriptCompiler coffeeScriptCompiler = new CoffeeScriptCompiler();
            return coffeeScriptCompiler.Compile(input);
        }
    }
}
