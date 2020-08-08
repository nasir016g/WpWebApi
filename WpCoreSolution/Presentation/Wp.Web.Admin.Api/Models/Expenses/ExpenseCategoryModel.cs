﻿using System.Collections.Generic;

namespace Wp.Web.Admin.Api.Models.Admin
{
    public class ExpenseCategoryModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public List<ExpenseModel> Expenses { get; set; }

    }
}
