﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitSelectorInterfaceGenerator.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator.UnitSelectors
{
    using System.Collections.Generic;
    using System.Text;
    using Sundew.Generator;
    using Sundew.Generator.Code;
    using Sundew.Generator.Code.CSharp;
    using Sundew.Generator.Core;

    public class UnitSelectorInterfaceGenerator : IGenerator<ICodeSetup, ICodeGeneratorSetup, IProject, IQuantityModel, ICodeRun, ITextOutput>
    {
        public IReadOnlyList<ICodeRun> Prepare(ICodeSetup codeSetup, ICodeGeneratorSetup codeGeneratorSetup, IProject target, IQuantityModel model, string modelOrigin)
        {
            return new[]
            {
                new CodeRun(model.Name, $"I{model.Name}UnitSelector{target.FileSuffix}", codeGeneratorSetup.TargetNamespace ?? codeSetup.TargetNamespace)
            };
        }

        public ITextOutput Generate(ICodeSetup codeSetup, ICodeGeneratorSetup codeGeneratorSetup, IProject target, IQuantityModel model, ICodeRun run, long index)
        {
            return new TextOutput($@"
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=""{run.FileName}"" company=""Hukano"">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// <auto-generated />
namespace {NamespaceHelper.CombineNamespaces(target.RootNamespace, run.Namespace)}
{{
{UsingsHelper.GetUsings(codeSetup.UseGlobalUsings | codeGeneratorSetup.UseGlobalUsings, 4, codeSetup.Usings, codeGeneratorSetup.Usings)}

    /// <summary>
    /// Interface for <see cref=""{model.Name}""/> unit selector.
    /// </summary>
    [GeneratedCode(""{this.GetType().FullName}"", ""{this.GetType().Assembly.GetName().Version}"")]
    public interface I{model.Name}UnitSelector : IUnitSelector
    {{
{this.GetUnits(model)}
    }}
}}
");
        }

        private IndentedString GetUnits(IQuantityModel model)
        {
            var stringBuilder = new StringBuilder();
            foreach (var unitModel in model.Units)
            {
                stringBuilder.AppendLine($@"
/// <summary>
/// Gets the {UnitsHelper.GetDocumentationName(unitModel)}.
/// </summary>
/// <value>
/// The yard <see cref=""Expression""/>.
/// </value>
Expression {unitModel.Identifier} {{ get; }}");
            }

            return new IndentedString(8, stringBuilder.ToString());
        }
    }
}