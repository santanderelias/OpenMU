// <copyright file="QuestItemRequirement.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel
{
    using System;
    using System.Collections.Generic;
    using MUnique.OpenMU.Persistence.Json;
    
    /// <summary>
    /// A plain implementation of <see cref="QuestItemRequirement"/>.
    /// </summary>
    public partial class QuestItemRequirement : MUnique.OpenMU.DataModel.Configuration.Quests.QuestItemRequirement, IIdentifiable, IConvertibleTo<QuestItemRequirement>
    {
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw object of <see cref="Item" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public ItemDefinition RawItem
        {
            get => base.Item as ItemDefinition;
            set => base.Item = value;
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition Item
        {
            get => base.Item;
            set => base.Item = value;
        }

        /// <summary>
        /// Gets the raw object of <see cref="DropItemGroup" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dropItemGroup")]
        [System.Text.Json.Serialization.JsonPropertyName("dropItemGroup")]
        public DropItemGroup RawDropItemGroup
        {
            get => base.DropItemGroup as DropItemGroup;
            set => base.DropItemGroup = value;
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override MUnique.OpenMU.DataModel.Configuration.DropItemGroup DropItemGroup
        {
            get => base.DropItemGroup;
            set => base.DropItemGroup = value;
        }


        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            var baseObject = obj as IIdentifiable;
            if (baseObject != null)
            {
                return baseObject.Id == this.Id;
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        /// <inheritdoc/>
        public QuestItemRequirement Convert() => this;
    }
}