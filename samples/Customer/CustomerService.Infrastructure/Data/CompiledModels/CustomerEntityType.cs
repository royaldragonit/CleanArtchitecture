﻿// <auto-generated />
using System;
using System.Reflection;
using CustomerService.AppCore.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using N8T.Core.Domain;

#pragma warning disable 219, 612, 618
#nullable enable

namespace CustomerService.Infrastructure
{
    partial class CustomerEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "CustomerService.AppCore.Core.Entities.Customer",
                typeof(Customer),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(Guid),
                propertyInfo: typeof(EntityBase).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EntityBase).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw);
            id.AddAnnotation("Relational:ColumnName", "id");
            id.AddAnnotation("Relational:ColumnType", "uuid");
            id.AddAnnotation("Relational:DefaultValueSql", "uuid_generate_v4()");

            var balance = runtimeEntityType.AddProperty(
                "Balance",
                typeof(decimal),
                propertyInfo: typeof(Customer).GetProperty("Balance", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Customer).GetField("<Balance>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            balance.AddAnnotation("Relational:ColumnName", "balance");

            var countryId = runtimeEntityType.AddProperty(
                "CountryId",
                typeof(Guid),
                propertyInfo: typeof(Customer).GetProperty("CountryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Customer).GetField("<CountryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            countryId.AddAnnotation("Relational:ColumnName", "country_id");
            countryId.AddAnnotation("Relational:ColumnType", "uuid");

            var created = runtimeEntityType.AddProperty(
                "Created",
                typeof(DateTime),
                propertyInfo: typeof(EntityBase).GetProperty("Created", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EntityBase).GetField("<Created>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd);
            created.AddAnnotation("Relational:ColumnName", "created");
            created.AddAnnotation("Relational:DefaultValueSql", "now()");

            var email = runtimeEntityType.AddProperty(
                "Email",
                typeof(string),
                propertyInfo: typeof(Customer).GetProperty("Email", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Customer).GetField("<Email>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            email.AddAnnotation("Relational:ColumnName", "email");

            var firstName = runtimeEntityType.AddProperty(
                "FirstName",
                typeof(string),
                propertyInfo: typeof(Customer).GetProperty("FirstName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Customer).GetField("<FirstName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            firstName.AddAnnotation("Relational:ColumnName", "first_name");

            var lastName = runtimeEntityType.AddProperty(
                "LastName",
                typeof(string),
                propertyInfo: typeof(Customer).GetProperty("LastName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Customer).GetField("<LastName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            lastName.AddAnnotation("Relational:ColumnName", "last_name");

            var updated = runtimeEntityType.AddProperty(
                "Updated",
                typeof(DateTime?),
                propertyInfo: typeof(EntityBase).GetProperty("Updated", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EntityBase).GetField("<Updated>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            updated.AddAnnotation("Relational:ColumnName", "updated");

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "pk_customers");

            var index = runtimeEntityType.AddIndex(
                new[] { id },
                unique: true);
            index.AddAnnotation("Relational:Name", "ix_customers_id");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "customer");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "customers");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
