
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Area.generated.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// <auto-generated />
namespace Sundew.Quantities
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Globalization;
    using global::Sundew.Quantities.Core;
    using global::Sundew.Quantities.Representations.Expressions;
    using global::Sundew.Quantities.UnitSelectors;

    [GeneratedCode("Sundew.Quantities.Generator.Quantities.QuantityGenerator", "1.0.0.0")]
    public partial struct Area : IQuantity<Area, AreaUnitSelector>
    {
        private readonly double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unitSelector">The unit selector.</param>
        public Area(double value, SelectUnit<AreaUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new AreaUnitSelector())))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> struct.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Area(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        public Area(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        public Area(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        double IQuantity.Value => this.value;

        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <value>
        /// The unit.
        /// </value>
        public IUnit Unit { get; }

        /// <summary>
        /// Implements the unary + operator.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        /// The <paramref name="quantity"/>.
        /// </returns>
        public static Area operator +(Area quantity)
        {
            return quantity;
        }

        /// <summary>
        /// Implements the unary - operator.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        /// The negated <paramref name="quantity"/>.
        /// </returns>
        public static Area operator -(Area quantity)
        {
            return new Area(-quantity.value, quantity.Unit);
        }

        /// <summary>
        /// Increaments the specified <see cref="Area"/>.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        /// An increamented <see cref="Area"/>.
        /// </returns>
        public static Area operator ++(Area quantity)
        {
            return new Area(quantity.value + 1, quantity.Unit);
        }

        /// <summary>
        /// Decreaments the specified <see cref="Area"/>.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        /// An decreamented <see cref="Area"/>.
        /// </returns>
        public static Area operator --(Area quantity)
        {
            return new Area(quantity.value - 1, quantity.Unit);
        }

        /// <summary>
        /// Adds the specified rhs to the specified lhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// A <see cref="Area"/>.
        /// </returns>
        public static Area operator +(Area lhs, double rhs)
        {
            return new Area(lhs.value + rhs, lhs.Unit);
        }

        /// <summary>
        /// Subtracts the specified rhs from the specified lhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// A <see cref="Area"/>.
        /// </returns>
        public static Area operator -(Area lhs, double rhs)
        {
            return new Area(lhs.value - rhs, lhs.Unit);
        }

        /// <summary>
        /// Multiplies the specified lhs by the specified rhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// A <see cref="Area"/>.
        /// </returns>
        public static Area operator *(Area lhs, double rhs)
        {
            return new Area(lhs.value * rhs, lhs.Unit);
        }

        /// <summary>
        /// Divides the specified lhs by the specified rhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// A <see cref="Area"/>.
        /// </returns>
        public static Area operator /(Area lhs, double rhs)
        {
            return new Area(lhs.value / rhs, lhs.Unit);
        }

        /// <summary>
        /// Adds the specified rhs to the specified lhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// A <see cref="Area"/>.
        /// </returns>
        public static Area operator +(Area lhs, Area rhs)
        {
            return new Area(QuantityOperations.Add(lhs, rhs));
        }

        /// <summary>
        /// Subtracts the specified rhs from the specified lhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// A <see cref="Area"/>.
        /// </returns>
        public static Area operator -(Area lhs, Area rhs)
        {
            return new Area(QuantityOperations.Subtract(lhs, rhs));
        }

        /// <summary>
        /// Divides the specified lhs by the specified rhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        /// A <see cref="Area"/>.
        /// </returns>
        public static double operator /(Area lhs, Area rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        /// <summary>
        /// Determines whether the specified rhs, is equal to the lhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        ///   <c>true</c> if the specified rhs is equal to the lhs; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator ==(Area lhs, Area rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        /// <summary>
        /// Determines whether the specified rhs, is different from the lhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        ///   <c>true</c> if the specified rhs is different to the lhs; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator !=(Area lhs, Area rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        /// <summary>
        /// Compares whether the specified lhs is greather than or equal to the rhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        ///   <c>true</c> if the specified lhs is greater than or equal to the rhs; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator >=(Area lhs, Area rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        /// <summary>
        /// Compares whether the specified lhs is less than or equal to the rhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        ///   <c>true</c> if the specified lhs is less than or equal to the rhs; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator <=(Area lhs, Area rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        /// <summary>
        /// Compares whether the specified lhs is greather than the rhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        ///   <c>true</c> if the specified lhs is greater than or rhs; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator >(Area lhs, Area rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        /// <summary>
        /// Compares whether the specified lhs is less than the rhs.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <param name="rhs">The RHS.</param>
        /// <returns>
        ///   <c>true</c> if the specified lhs is less than the rhs; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator <(Area lhs, Area rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        /// <summary>
        /// Creates an <see cref="Interval"/> with the specified minimum, maximum and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>
        /// An <see cref="Interval"/>.
        /// </returns>
        public static Interval<Area> Interval(double min, double max, SelectUnit<AreaUnitSelector> unitSelector)
        {
            return new Interval<Area>(min, max, unitSelector(new AreaUnitSelector()));
        }

        /// <summary>
        /// Squares this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="Squared{Area}"/>.
        /// </returns>
        public Squared<Area> Squared()
        {
            return new Squared<Area>(this);
        }

        /// <summary>
        /// Cubes this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="Cubed{Area}"/>.
        /// </returns>
        public Cubed<Area> Cubed()
        {
            return new Cubed<Area>(this);
        }

        /// <summary>
        /// Converts this object to a <see cref="double" /> using the specified unit.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>
        /// The converted <see cref="double" />.
        /// </returns>
        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        /// <summary>
        /// Converts this object to a <see cref="IQuantity" /> using the unit specified by the <see cref="IUnit" />.
        /// </summary>
        /// <param name="unit">The target unit.</param>
        /// <returns>
        /// The resulting <see cref="IQuantity" />.
        /// </returns>
        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        /// <summary>
        /// Converts this object to a <see cref="Area" /> using the specified unit.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>
        /// The converted <see cref="Area" />.
        /// </returns>
        public Area ToUnit(IUnit unit)
        {
            return new Area(this.ToDouble(unit), unit);
        }

        /// <summary>
        /// Converts this object to a <see cref="Area" /> using the unit specified by the <see cref="AreaUnitSelector" />.
        /// </summary>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>
        /// The converted <see cref="Area" />.
        /// </returns>
        public Area ToUnit(SelectUnit<AreaUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new AreaUnitSelector())));
        }

        /// <summary>
        /// Converts this object to a <see cref="double" /> using the unit specified by the <see cref="AreaUnitSelector" />.
        /// </summary>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>
        /// The converted <see cref="double" />.
        /// </returns>
        public double ToDouble(SelectUnit<AreaUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new AreaUnitSelector())));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return QuantityHelper.GetHashCode(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return QuantityHelper.AreEqual(this, obj);
        }

        /// <summary>
        /// Determines whether the specified <see cref="IQuantity" />, is equal to this instance.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="IQuantity" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(IQuantity quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Area" />, is equal to this instance.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="Area" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Area quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name="obj" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name="obj" />. Greater than zero This instance follows <paramref name="obj" /> in the sort order.
        /// </returns>
        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Area>(this, obj);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="quantity">A quantityModel to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name="quantity" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name="quantity" />. Greater than zero This instance follows <paramref name="quantity" /> in the sort order.
        /// </returns>
        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="quantity">A quantity to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name="quantity" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name="quantity" />. Greater than zero This instance follows <paramref name="quantity" /> in the sort order.
        /// </returns>
        public int CompareTo(Area quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {{
            return this.ToString(CultureInfo.CurrentCulture);
        }}

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="unitFormat">The unit format.</param>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public string ToString(UnitFormat unitFormat)
        {{
            return this.ToString(unitFormat, null, CultureInfo.CurrentCulture);
        }}

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public string ToString(string format)
        {{
            return this.ToString(format, CultureInfo.CurrentCulture);
        }}

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public string ToString(IFormatProvider formatProvider)
        {{
            return this.ToString(null, formatProvider);
        }}

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="unitFormat">The unit format.</param>
        /// <param name="format">The format.</param>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public string ToString(UnitFormat unitFormat, string format)
        {{
            return this.ToString(unitFormat, format, CultureInfo.CurrentCulture);
        }}

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="unitFormat">The unit format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public string ToString(UnitFormat unitFormat, IFormatProvider formatProvider)
        {{
            return this.ToString(unitFormat, null, formatProvider);
        }}

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {{
            return this.ToString(UnitFormat.Default, format, formatProvider);
        }}

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="unitFormat">The unit format.</param>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public string ToString(UnitFormat unitFormat, string format, IFormatProvider formatProvider)
        {{
            return QuantityHelper.ToString(
                this.Unit.FormatValue(this.value, format, formatProvider),
                UnitFormatHelper.GetNotation(this.Unit, unitFormat));
        }}

        /// <summary>
        /// Creates the quantity.
        /// </summary>
        /// <param name="value">The quantity value.</param>
        /// <param name="unit">The quantity unit.</param>
        /// <returns>
        /// A <see cref="Area" />.
        /// </returns>
        public Area CreateQuantity(double value, IUnit unit)
        {
            return new Area(value, unit);
        }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>
        /// An <see cref="IQuantity" />.
        /// </returns>
        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        /// <summary>
        /// Creates the unit selector.
        /// </summary>
        /// <returns>
        /// A unit selector.
        /// </returns>
        AreaUnitSelector IQuantity<Area, AreaUnitSelector>.CreateUnitSelector()
        {
            return new AreaUnitSelector();
        }
    }
}
