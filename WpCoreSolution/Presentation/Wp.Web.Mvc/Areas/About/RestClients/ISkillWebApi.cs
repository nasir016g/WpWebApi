﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wp.Web.Mvc.About.Models;

namespace Wp.Web.Mvc.About.RestClients
{
    public interface ISkillWebApi
    {
        [Get("/skill/GetByResumeId/{resumeId}")]
        Task<List<SkillModel>> GetSkills([AliasAs("resumeId")] int resumeId);

        [Get("/skill/{id}")]
        Task<SkillModel> GetSkillById([AliasAs("id")] int id);

        [Put("/skill/{id}")]
        Task Update(int id, SkillModel model);

        [Delete("/skill/{id}")]
        Task Delete([AliasAs("id")] int id);

        [Get("/skill/items/{skillId}")]
        Task<List<SkillItemModel>> GetItems(int skillId);

        [Get("/skill/item/{id}")]
        Task<SkillItemModel> GetItem(int id);

        [Put("/skill/item/{id}")]
        Task UpdateItem(int id, SkillItemModel model);

        [Delete("/skill/item/{id}")]
        Task DeleteItem([AliasAs("id")] int id);
    }
}
