// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DivisionExpression.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Expressions
{
    using System;

    /// <summary>
    /// Represents an division operation of two expressions.
    /// </summary>
    public sealed class DivisionExpression : Expression, IHaveLhsAndRhs<Expression>, IEquatable<DivisionExpression>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DivisionExpression" /> class.
        /// </summary>
        /// <param name="lhs">The LHS <see cref="Expression"/>.</param>
        /// <param name="rhs">The RHS <see cref="Expression"/>.</param>
        public DivisionExpression(Expression lhs, Expression rhs)
        {
            this.Lhs = lhs;
            this.Rhs = rhs;
        }

        /// <summary>
        /// Gets the LHS.
        /// </summary>
        /// <value>
        /// The LHS <see cref="Expression"/>.
        /// </value>
        public Expression Lhs { get; }

        /// <summary>
        /// Gets the RHS.
        /// </summary>
        /// <value>
        /// The RHS <see cref="Expression"/>.
        /// </value>
        public Expression Rhs { get; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        ///     <c>true</c> if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(DivisionExpression other)
        {
            return Equals(this.Lhs, other.Lhs) && Equals(this.Rhs, other.Rhs);
        }

        /// <summary>
        /// Visits the specified expression visitor.
        /// </summary>
        /// <typeparam name="TParameter1">The type of the parameter1.</typeparam>
        /// <typeparam name="TParameter2">The type of the parameter2.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="expressionVisitor">The expression visitor.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        public override void Visit<TParameter1, TParameter2, TResult>(
            IExpressionVisitor<TParameter1, TParameter2, TResult> expressionVisitor,
            TParameter1 parameter1,
            TParameter2 parameter2)
        {
            expressionVisitor.Divide(this, parameter1, parameter2);
        }
    }
}