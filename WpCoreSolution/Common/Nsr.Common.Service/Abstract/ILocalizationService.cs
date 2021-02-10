﻿using Nsr.Common.Core;
using Nsr.Common.Core.Localization;
using System.Collections.Generic;

namespace Nsr.Common.Services
{
    public partial interface ILocalizationService : IEntityService<LocaleStringResource>
    {
        IEnumerable<LocaleStringResource> GetAll(int languageId, string sortOrder, string searchString, int page, int pageSize, out int total);
        //LocaleStringResource GetById(int id);
        LocaleStringResource GetByName(string resourceName);
        LocaleStringResource GetByName(string resourceName, int languageId);

        Dictionary<string, KeyValuePair<int, string>> GetAllResourceValues(int languageId);
        string GetResource(string resourceKey);
        string GetResource(string resourceKey, int languageId, string defaultValue = "");
        void ImportResourcesFromXml(Language language, string xml);
    }
}