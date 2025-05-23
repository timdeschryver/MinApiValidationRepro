﻿#nullable enable annotations
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable

namespace System.Runtime.CompilerServices
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.ValidationsGenerator, Version=10.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "10.0.0.0")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    file sealed class InterceptsLocationAttribute : System.Attribute
    {
        public InterceptsLocationAttribute(int version, string data)
        {
        }
    }
}

namespace Microsoft.AspNetCore.Http.Validation.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.ValidationsGenerator, Version=10.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "10.0.0.0")]
    file sealed class GeneratedValidatablePropertyInfo : global::Microsoft.AspNetCore.Http.Validation.ValidatablePropertyInfo
    {
        public GeneratedValidatablePropertyInfo(
            [param: global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties)]
            global::System.Type containingType,
            global::System.Type propertyType,
            string name,
            string displayName) : base(containingType, propertyType, name, displayName)
        {
            ContainingType = containingType;
            Name = name;
        }

        internal global::System.Type ContainingType { get; }
        internal string Name { get; }

        protected override global::System.ComponentModel.DataAnnotations.ValidationAttribute[] GetValidationAttributes()
            => ValidationAttributeCache.GetValidationAttributes(ContainingType, Name);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.ValidationsGenerator, Version=10.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "10.0.0.0")]
    file sealed class GeneratedValidatableTypeInfo : global::Microsoft.AspNetCore.Http.Validation.ValidatableTypeInfo
    {
        public GeneratedValidatableTypeInfo(
            [param: global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.Interfaces)]
            global::System.Type type,
            ValidatablePropertyInfo[] members) : base(type, members) { }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.ValidationsGenerator, Version=10.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "10.0.0.0")]
    file class GeneratedValidatableInfoResolver : global::Microsoft.AspNetCore.Http.Validation.IValidatableInfoResolver
    {
        public bool TryGetValidatableTypeInfo(global::System.Type type, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::Microsoft.AspNetCore.Http.Validation.IValidatableInfo? validatableInfo)
        {
            validatableInfo = null;
            if (type == typeof(global::MinApiValidationRepro.Persons.Entity))
            {
                validatableInfo = CreateEntity();
                return true;
            }
            if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Persons.Entity>))
            {
                validatableInfo = CreateDictionary`2();
                return true;
            }
            if (type == typeof(global::MinApiValidationRepro.Pets.Entity))
            {
                validatableInfo = CreateEntity();
                return true;
            }
            if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Pets.Entity>))
            {
                validatableInfo = CreateDictionary`2();
                return true;
            }

            return false;
        }

        // No-ops, rely on runtime code for ParameterInfo-based resolution
        public bool TryGetValidatableParameterInfo(global::System.Reflection.ParameterInfo parameterInfo, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::Microsoft.AspNetCore.Http.Validation.IValidatableInfo? validatableInfo)
        {
            validatableInfo = null;
            return false;
        }

        private ValidatableTypeInfo CreateEntity()
        {
            return new GeneratedValidatableTypeInfo(
                type: typeof(global::MinApiValidationRepro.Persons.Entity),
                members: [
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::MinApiValidationRepro.Persons.Entity),
                        propertyType: typeof(int),
                        name: "Id",
                        displayName: "Id"
                    ),
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::MinApiValidationRepro.Persons.Entity),
                        propertyType: typeof(string),
                        name: "Name",
                        displayName: "Name"
                    ),
                ]
            );
        }
        private ValidatableTypeInfo CreateDictionary`2()
        {
            return new GeneratedValidatableTypeInfo(
                type: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Persons.Entity>),
                members: [
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Persons.Entity>),
                        propertyType: typeof(global::MinApiValidationRepro.Persons.Entity),
                        name: "this[]",
                        displayName: "this[]"
                    ),
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Persons.Entity>),
                        propertyType: typeof(global::System.Collections.Generic.ICollection<global::MinApiValidationRepro.Persons.Entity>),
                        name: "System.Collections.Generic.IDictionary<TKey,TValue>.Values",
                        displayName: "System.Collections.Generic.IDictionary<TKey,TValue>.Values"
                    ),
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Persons.Entity>),
                        propertyType: typeof(global::System.Collections.Generic.IEnumerable<global::MinApiValidationRepro.Persons.Entity>),
                        name: "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values",
                        displayName: "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values"
                    ),
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Persons.Entity>),
                        propertyType: typeof(global::System.Collections.ICollection),
                        name: "System.Collections.IDictionary.Values",
                        displayName: "System.Collections.IDictionary.Values"
                    ),
                ]
            );
        }
        private ValidatableTypeInfo CreateEntity()
        {
            return new GeneratedValidatableTypeInfo(
                type: typeof(global::MinApiValidationRepro.Pets.Entity),
                members: [
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::MinApiValidationRepro.Pets.Entity),
                        propertyType: typeof(int),
                        name: "Id",
                        displayName: "Id"
                    ),
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::MinApiValidationRepro.Pets.Entity),
                        propertyType: typeof(string),
                        name: "Breed",
                        displayName: "Breed"
                    ),
                ]
            );
        }
        private ValidatableTypeInfo CreateDictionary`2()
        {
            return new GeneratedValidatableTypeInfo(
                type: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Pets.Entity>),
                members: [
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Pets.Entity>),
                        propertyType: typeof(global::MinApiValidationRepro.Pets.Entity),
                        name: "this[]",
                        displayName: "this[]"
                    ),
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Pets.Entity>),
                        propertyType: typeof(global::System.Collections.Generic.ICollection<global::MinApiValidationRepro.Pets.Entity>),
                        name: "System.Collections.Generic.IDictionary<TKey,TValue>.Values",
                        displayName: "System.Collections.Generic.IDictionary<TKey,TValue>.Values"
                    ),
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Pets.Entity>),
                        propertyType: typeof(global::System.Collections.Generic.IEnumerable<global::MinApiValidationRepro.Pets.Entity>),
                        name: "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values",
                        displayName: "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values"
                    ),
                    new GeneratedValidatablePropertyInfo(
                        containingType: typeof(global::System.Collections.Generic.Dictionary<string, global::MinApiValidationRepro.Pets.Entity>),
                        propertyType: typeof(global::System.Collections.ICollection),
                        name: "System.Collections.IDictionary.Values",
                        displayName: "System.Collections.IDictionary.Values"
                    ),
                ]
            );
        }

    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.ValidationsGenerator, Version=10.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "10.0.0.0")]
    file static class GeneratedServiceCollectionExtensions
    {
        [global::System.Runtime.CompilerServices.InterceptsLocationAttribute(1, "BplmWjhxehPN8aXetz+e4R4BAABQcm9ncmFtLmNz")]
        public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddValidation(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Action<global::Microsoft.AspNetCore.Http.Validation.ValidationOptions>? configureOptions = null)
        {
            // Use non-extension method to avoid infinite recursion.
            return global::Microsoft.Extensions.DependencyInjection.ValidationServiceCollectionExtensions.AddValidation(services, options =>
            {
                options.Resolvers.Insert(0, new GeneratedValidatableInfoResolver());
                if (configureOptions is not null)
                {
                    configureOptions(options);
                }
            });
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.ValidationsGenerator, Version=10.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "10.0.0.0")]
    file static class ValidationAttributeCache
    {
        private sealed record CacheKey(global::System.Type ContainingType, string PropertyName);
        private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<CacheKey, global::System.ComponentModel.DataAnnotations.ValidationAttribute[]> _cache = new();

        public static global::System.ComponentModel.DataAnnotations.ValidationAttribute[] GetValidationAttributes(
            global::System.Type containingType,
            string propertyName)
        {
            var key = new CacheKey(containingType, propertyName);
            return _cache.GetOrAdd(key, static k =>
            {
                var results = new global::System.Collections.Generic.List<global::System.ComponentModel.DataAnnotations.ValidationAttribute>();

                // Get attributes from the property
                var property = k.ContainingType.GetProperty(k.PropertyName);
                if (property != null)
                {
                    var propertyAttributes = global::System.Reflection.CustomAttributeExtensions
                        .GetCustomAttributes<global::System.ComponentModel.DataAnnotations.ValidationAttribute>(property, inherit: true);

                    results.AddRange(propertyAttributes);
                }

                // Check constructors for parameters that match the property name
                // to handle record scenarios
                foreach (var constructor in k.ContainingType.GetConstructors())
                {
                    // Look for parameter with matching name (case insensitive)
                    var parameter = global::System.Linq.Enumerable.FirstOrDefault(
                        constructor.GetParameters(),
                        p => string.Equals(p.Name, k.PropertyName, global::System.StringComparison.OrdinalIgnoreCase));

                    if (parameter != null)
                    {
                        var paramAttributes = global::System.Reflection.CustomAttributeExtensions
                            .GetCustomAttributes<global::System.ComponentModel.DataAnnotations.ValidationAttribute>(parameter, inherit: true);

                        results.AddRange(paramAttributes);

                        break;
                    }
                }

                return results.ToArray();
            });
        }
    }
}