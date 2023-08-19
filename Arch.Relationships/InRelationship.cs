﻿using Arch.Core;
using Arch.Core.Utils;

namespace Arch.Relationships;


/// <summary>
///     The struct <see cref="InRelationship"/>
///     represents a reference to a <see cref="Relationship{T}"/>.
///     It sits on an <see cref="Entity"/> to indicate in which other <see cref="Relationship{T}"/>s it is involved in.
/// </summary>
internal readonly struct InRelationship
{
    /// <summary>
    ///     The id of the <see cref="Relationship{T}"/>-Component that this <see cref="InRelationship"/> points to.
    ///     Basically the <see cref="Relationship{T}"/> the <see cref="Entity"/> is in. 
    /// </summary>
    public readonly int ComponentTypeId;

    /// <summary>
    ///     Creates a new <see cref="InRelationship"/> instance.
    /// </summary>
    /// <param name="targetRelation">The <see cref="ComponentType"/> that represents the relation.</param>
    internal InRelationship(ComponentType targetRelation)
    {
        ComponentTypeId = targetRelation.Id;
    }
}
