// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LuminousIntensityUnitSelector.generated.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// <auto-generated />
namespace Sundew.Quantities.UnitSelectors
{
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Generic;
    using global::Sundew.Quantities.Representations.Expressions;
    using global::Sundew.Quantities.Representations.Units;
    using global::Sundew.Quantities.UnitSelection;

    /// <summary>
    /// UnitSelector for <see cref="LuminousIntensity"/>.
    /// </summary>
    [GeneratedCode("Sundew.Quantities.Generator.UnitSelectors.UnitSelectorGenerator", "1.0.0.0")]
    public class LuminousIntensityUnitSelector : IExponentSelector<IPrefixedLuminousIntensityUnitSelector>, IPrefixedLuminousIntensityUnitSelector
    {
        private int actualExponent = 1;

        private Prefix actualPrefix;

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => UnitDefinitions.Candela;

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerable{IUnit}" />.
        /// </returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Candela;
        }

        /// <summary>
        /// Gets the square.
        /// </summary>
        /// <value>
        /// The square.
        /// </value>
        public IPrefixedLuminousIntensityUnitSelector Square => this.GetPrefixesAndUnits(2);

        /// <summary>
        /// Gets the cubic.
        /// </summary>
        /// <value>
        /// The cubic.
        /// </value>
        public IPrefixedLuminousIntensityUnitSelector Cubic => this.GetPrefixesAndUnits(3);

        /// <summary>
        /// Gets the quartic.
        /// </summary>
        /// <value>
        /// The quartic.
        /// </value>
        public IPrefixedLuminousIntensityUnitSelector Quartic => this.GetPrefixesAndUnits(4);

        /// <summary>
        /// Gets the quintic.
        /// </summary>
        /// <value>
        /// The quintic.
        /// </value>
        public IPrefixedLuminousIntensityUnitSelector Quintic => this.GetPrefixesAndUnits(5);

        /// <summary>
        /// Gets the yotta.
        /// </summary>
        /// <value>
        /// The yotta.
        /// </value>
        public ILuminousIntensityUnitSelector Yotta => this.GetUnits(Prefixes.Yotta);

        /// <summary>
        /// Gets the zetta.
        /// </summary>
        /// <value>
        /// The zetta.
        /// </value>
        public ILuminousIntensityUnitSelector Zetta => this.GetUnits(Prefixes.Zetta);

        /// <summary>
        /// Gets the exa.
        /// </summary>
        /// <value>
        /// The exa.
        /// </value>
        public ILuminousIntensityUnitSelector Exa => this.GetUnits(Prefixes.Exa);

        /// <summary>
        /// Gets the peta.
        /// </summary>
        /// <value>
        /// The peta.
        /// </value>
        public ILuminousIntensityUnitSelector Peta => this.GetUnits(Prefixes.Peta);

        /// <summary>
        /// Gets the tera.
        /// </summary>
        /// <value>
        /// The tera.
        /// </value>
        public ILuminousIntensityUnitSelector Tera => this.GetUnits(Prefixes.Tera);

        /// <summary>
        /// Gets the giga.
        /// </summary>
        /// <value>
        /// The giga.
        /// </value>
        public ILuminousIntensityUnitSelector Giga => this.GetUnits(Prefixes.Giga);

        /// <summary>
        /// Gets the mega.
        /// </summary>
        /// <value>
        /// The mega.
        /// </value>
        public ILuminousIntensityUnitSelector Mega => this.GetUnits(Prefixes.Mega);

        /// <summary>
        /// Gets the kilo.
        /// </summary>
        /// <value>
        /// The kilo.
        /// </value>
        public ILuminousIntensityUnitSelector Kilo => this.GetUnits(Prefixes.Kilo);

        /// <summary>
        /// Gets the hecto.
        /// </summary>
        /// <value>
        /// The hecto.
        /// </value>
        public ILuminousIntensityUnitSelector Hecto => this.GetUnits(Prefixes.Hecto);

        /// <summary>
        /// Gets the deca.
        /// </summary>
        /// <value>
        /// The deca.
        /// </value>
        public ILuminousIntensityUnitSelector Deca => this.GetUnits(Prefixes.Deca);

        /// <summary>
        /// Gets the deci.
        /// </summary>
        /// <value>
        /// The deci.
        /// </value>
        public ILuminousIntensityUnitSelector Deci => this.GetUnits(Prefixes.Deci);

        /// <summary>
        /// Gets the centi.
        /// </summary>
        /// <value>
        /// The centi.
        /// </value>
        public ILuminousIntensityUnitSelector Centi => this.GetUnits(Prefixes.Centi);

        /// <summary>
        /// Gets the milli.
        /// </summary>
        /// <value>
        /// The milli.
        /// </value>
        public ILuminousIntensityUnitSelector Milli => this.GetUnits(Prefixes.Milli);

        /// <summary>
        /// Gets the micro.
        /// </summary>
        /// <value>
        /// The micro.
        /// </value>
        public ILuminousIntensityUnitSelector Micro => this.GetUnits(Prefixes.Micro);

        /// <summary>
        /// Gets the nano.
        /// </summary>
        /// <value>
        /// The nano.
        /// </value>
        public ILuminousIntensityUnitSelector Nano => this.GetUnits(Prefixes.Nano);

        /// <summary>
        /// Gets the pico.
        /// </summary>
        /// <value>
        /// The pico.
        /// </value>
        public ILuminousIntensityUnitSelector Pico => this.GetUnits(Prefixes.Pico);

        /// <summary>
        /// Gets the femto.
        /// </summary>
        /// <value>
        /// The femto.
        /// </value>
        public ILuminousIntensityUnitSelector Femto => this.GetUnits(Prefixes.Femto);

        /// <summary>
        /// Gets the atto.
        /// </summary>
        /// <value>
        /// The atto.
        /// </value>
        public ILuminousIntensityUnitSelector Atto => this.GetUnits(Prefixes.Atto);

        /// <summary>
        /// Gets the zepto.
        /// </summary>
        /// <value>
        /// The zepto.
        /// </value>
        public ILuminousIntensityUnitSelector Zepto => this.GetUnits(Prefixes.Zepto);

        /// <summary>
        /// Gets the yocto.
        /// </summary>
        /// <value>
        /// The yocto.
        /// </value>
        public ILuminousIntensityUnitSelector Yocto => this.GetUnits(Prefixes.Yocto);

        /// <summary>
        /// Gets the candela expression.
        /// </summary>
        /// <value>
        /// The candela.
        /// </value>
        public Expression Candelas => this.SpecifyUnit(UnitDefinitions.Candela);

        /// <summary>
        /// Specifies the prefix by the specified factor.
        /// </summary>
        /// <param name="factor">The factor.</param>
        /// <returns>The available units.</returns>
        public ILuminousIntensityUnitSelector By(double factor)
        {
            return this.GetUnits(new FactoredPrefix(factor));
        }

        /// <summary>
        /// Specifies the exponent.
        /// </summary>
        /// <param name="exponent">The exponent.</param>
        public void SpecifyExponent(int exponent)
        {
            this.actualExponent = exponent;
        }

        /// <summary>
        /// Specifies the prefix.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        public void SpecifyPrefix(Prefix prefix)
        {
            this.actualPrefix = prefix;
        }

        /// <summary>
        /// Selects the unit based on the specified magnitude, prefix and base unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>
        /// An <see cref="Expression"/>.
        /// </returns>
        public Expression SpecifyUnit(IUnit unit)
        {
            return UnitSelectorHelper.CreateExpression(ref this.actualExponent, ref this.actualPrefix, unit);
        }

        /// <summary>
        /// Gets the prefixes and unit selector.
        /// </summary>
        /// <param name="exponent">The exponent.</param>
        /// <returns>
        /// The available prefixes and units.
        /// </returns>
        private IPrefixedLuminousIntensityUnitSelector GetPrefixesAndUnits(int exponent)
        {
            this.SpecifyExponent(exponent);
            return this;
        }

        /// <summary>
        /// Gets the unit selector.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <returns>The available units.</returns>
        private ILuminousIntensityUnitSelector GetUnits(Prefix prefix)
        {
            this.SpecifyPrefix(prefix);
            return this;
        }
    }
}