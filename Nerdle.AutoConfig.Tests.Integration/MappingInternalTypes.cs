﻿using FluentAssertions;
using NUnit.Framework;

namespace Nerdle.AutoConfig.Tests.Integration
{
    [TestFixture]
    public class MappingInternalTypes : EndToEndTest
    {
        [Test]
        public void Mapping_an_internal_type_when_InternalsVisibleTo_is_set()
        {
            var foo = AutoConfig.Map<IFooConfig>();
            foo.Foo.Should().Be("foo");
        }

        internal interface IFooConfig
        {
            string Foo { get; }
        }
    }
}
