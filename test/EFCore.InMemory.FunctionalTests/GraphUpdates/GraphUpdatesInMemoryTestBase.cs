// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore;

public abstract class GraphUpdatesInMemoryTestBase<TFixture> : GraphUpdatesTestBase<TFixture>
    where TFixture : GraphUpdatesInMemoryTestBase<TFixture>.GraphUpdatesInMemoryFixtureBase, new()
{
    protected GraphUpdatesInMemoryTestBase(TFixture fixture)
        : base(fixture)
    {
    }

    // In-memory database does not have database default values
    public override Task Can_insert_when_bool_PK_in_composite_key_has_sentinel_value(bool async, bool initialValue)
        => Task.CompletedTask;

    // In-memory database does not have database default values
    public override Task Can_insert_when_int_PK_in_composite_key_has_sentinel_value(bool async, int initialValue)
        => Task.CompletedTask;

    // In-memory database does not have database default values
    public override Task Can_insert_when_nullable_bool_PK_in_composite_key_has_sentinel_value(bool async, bool? initialValue)
        => Task.CompletedTask;

    // In-memory database does not have database default values
    public override Task Throws_for_single_property_bool_key_with_default_value_generation(bool async, bool initialValue)
        => Task.CompletedTask;

    // In-memory database does not have database default values
    public override Task Throws_for_single_property_nullable_bool_key_with_default_value_generation(bool async, bool? initialValue)
        => Task.CompletedTask;

    // In-memory database does not have database default values
    public override Task Can_insert_when_composite_FK_has_default_value_for_one_part(bool async)
        => Task.CompletedTask;

    // In-memory database does not have database default values
    public override Task Can_insert_when_FK_has_default_value(bool async)
        => Task.CompletedTask;

    // In-memory database does not have database default values
    public override Task Can_insert_when_FK_has_sentinel_value(bool async)
        => Task.CompletedTask;

    public override void Required_many_to_one_dependents_are_cascade_deleted_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Optional_many_to_one_dependents_are_orphaned_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_many_to_one_dependents_with_alternate_key_are_cascade_deleted_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Optional_many_to_one_dependents_with_alternate_key_are_orphaned_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Optional_one_to_one_relationships_are_one_to_one(
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_one_to_one_relationships_are_one_to_one(
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Save_required_one_to_one_changed_by_reference(
        ChangeMechanism changeMechanism,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Sever_required_one_to_one(
        ChangeMechanism changeMechanism,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_one_to_one_are_cascade_deleted_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_non_PK_one_to_one_are_cascade_deleted_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Optional_one_to_one_are_orphaned_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_one_to_one_are_cascade_detached_when_Added(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_non_PK_one_to_one_are_cascade_detached_when_Added(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Optional_one_to_one_with_AK_relationships_are_one_to_one(
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_one_to_one_with_AK_relationships_are_one_to_one(
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_one_to_one_with_alternate_key_are_cascade_deleted_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_non_PK_one_to_one_with_alternate_key_are_cascade_deleted_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Optional_one_to_one_with_alternate_key_are_orphaned_in_store(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_non_PK_one_to_one_with_alternate_key_are_cascade_detached_when_Added(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    public override void Required_one_to_one_with_alternate_key_are_cascade_detached_when_Added(
        CascadeTiming? cascadeDeleteTiming,
        CascadeTiming? deleteOrphansTiming)
    {
        // FK uniqueness not enforced in in-memory database
    }

    protected override void ExecuteWithStrategyInTransaction(
        Action<DbContext> testOperation,
        Action<DbContext> nestedTestOperation1 = null,
        Action<DbContext> nestedTestOperation2 = null,
        Action<DbContext> nestedTestOperation3 = null)
    {
        base.ExecuteWithStrategyInTransaction(testOperation, nestedTestOperation1, nestedTestOperation2, nestedTestOperation3);
        Fixture.Reseed();
    }

    protected override async Task ExecuteWithStrategyInTransactionAsync(
        Func<DbContext, Task> testOperation,
        Func<DbContext, Task> nestedTestOperation1 = null,
        Func<DbContext, Task> nestedTestOperation2 = null,
        Func<DbContext, Task> nestedTestOperation3 = null)
    {
        await base.ExecuteWithStrategyInTransactionAsync(
            testOperation, nestedTestOperation1, nestedTestOperation2, nestedTestOperation3);

        Fixture.Reseed();
    }

    public abstract class GraphUpdatesInMemoryFixtureBase : GraphUpdatesFixtureBase
    {
        protected override ITestStoreFactory TestStoreFactory
            => InMemoryTestStoreFactory.Instance;

        public override DbContextOptionsBuilder AddOptions(DbContextOptionsBuilder builder)
            => base.AddOptions(builder).ConfigureWarnings(w => w.Log(InMemoryEventId.TransactionIgnoredWarning));
    }
}
