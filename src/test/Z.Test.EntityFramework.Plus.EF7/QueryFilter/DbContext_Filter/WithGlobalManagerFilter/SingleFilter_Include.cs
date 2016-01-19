﻿// Description: EF Bulk Operations & Utilities | Bulk Insert, Update, Delete, Merge from database.
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.EntityFramework.Plus;

namespace Z.Test.EntityFramework.Plus
{
    public partial class QueryFilter_DbContext_Filter
    {
        [TestMethod]
        public void WithGlobalManagerFilter_SingleFilter_Include()
        {
            using (var ctx = new TestContext())
            {
                QueryFilterHelper.CreateGlobalManagerFilter(true, enableFilter1: false, includeClass: true);
                QueryFilterManager.InitilizeGlobalFilter(ctx);

                Assert.AreEqual(44, ctx.Inheritance_Interface_Entities.Sum(x => x.ColumnInt));

                QueryFilterHelper.ClearGlobalManagerFilter();
            }
        }
    }
}