﻿// Description: EF Bulk Operations & Utilities | Bulk Insert, Update, Delete, Merge from database.
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.EntityFramework.Plus;
#if EF5 || EF6
using System.Data.Entity;

#elif EF7
using Microsoft.Data.Entity;

#endif

namespace Z.Test.EntityFramework.Plus
{
    public partial class QueryFuture_Future
    {
        [TestMethod]
        public void Queryable_AsNoTracking()
        {
            TestContext.DeleteAll(x => x.Entity_Basics);
            TestContext.Insert(x => x.Entity_Basics, 10);

            using (var ctx = new TestContext())
            {
                var futureList1 = ctx.Entity_Basics.Where(x => x.ColumnInt < 5).AsNoTracking().Future();
                var futureList2 = ctx.Entity_Basics.Where(x => x.ColumnInt >= 5).AsNoTracking().Future();

                // TEST: The batch contains 2 queries
                Assert.AreEqual(2, QueryFutureManager.AddOrGetBatch(ctx.GetObjectContext()).Queries.Count);

                var list = futureList1.ToList();

                // AFTER

                // TEST: The batch contains 0 queries
                Assert.AreEqual(0, QueryFutureManager.AddOrGetBatch(ctx.GetObjectContext()).Queries.Count);

                // TEST: The futureList1 has a value and the list contains 5 items
                Assert.IsTrue(futureList1.HasValue);
                Assert.AreEqual(5, futureList1.ToList().Count);
                Assert.AreEqual(5, list.Count);

                // TEST: The futureList2 has a value and the list contains 5 items
                Assert.IsTrue(futureList2.HasValue);
                Assert.AreEqual(5, futureList2.ToList().Count);

                // TEST: No entries has been loaded in the change tracker
                Assert.AreEqual(0, ctx.ChangeTracker.Entries().Count());
            }
        }
    }
}