﻿using System.Collections.Generic;
using System.Linq;
using Wp.Common;
using Wp.Localization.Core;

namespace Wp.Localization.Services
{

    public class LanguageService : EntityService<Language>, ILanguageService
    {
        #region Constants

        private const string LANGUAGES_ALL_KEY = "Wp.language.all.";

        #endregion

        private readonly IBaseRepository<Language> _languageRepo;

        public LanguageService(IUnitOfWork unitOfWork, IBaseRepository<Language> languageRepo) : base(unitOfWork, languageRepo)
        {
            this._languageRepo = languageRepo;
        }

        public override IList<Language> GetAll()
        {
            //string key = string.Format(LANGUAGES_ALL_KEY);
            //return _cacheManager.Get(key, () =>
            //    {
            //       return _languageRepo.Table.ToList();
            //    });
            return _languageRepo.Table.ToList();
        }

               
    }
}