﻿using System.Linq;
using Nsr.Common.Core;
using Wp.Resumes.Core.Domain;

namespace Wp.Resumes.Services
{
    public class ResumeService : EntityService<Resume>, IResumeService
    {
        private IBaseRepository<Resume> _resumeRepo;

        public ResumeService(IUnitOfWork unitOfWork, IBaseRepository<Resume> resumeRepo) : base(unitOfWork, resumeRepo)
        {
            this._resumeRepo = resumeRepo;
        }

       
        public Resume GetByUserName(string userName)
        {
            return _resumeRepo.Table.Where(x => x.ApplicationUserName == userName).FirstOrDefault();
        }
    }
}
