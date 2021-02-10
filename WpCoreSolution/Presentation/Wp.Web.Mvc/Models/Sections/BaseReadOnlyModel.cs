﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wp.Core.Domain.Sections;
using Wp.Core.Domain.Security;
using Wp.Core.Domain.WebPages;
using Wp.Services.WebPages;

namespace Wp.Web.Mvc.Models.Sections
{
    public abstract class BaseReadOnlyModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BaseReadOnlyModel(Section section, IWebPageService webPageService, IHttpContextAccessor httpContextAccessor)
        {
            if (section != null)
            {
                this.Id = section.Id;
                this.WebPage = section.WebPage;
                this.UserHasEditRights = webPageService.HasEditRights(section.WebPageId);
                this.UserIsAdmin = _httpContextAccessor.HttpContext.User.IsInRole(SystemRoleNames.Administrators.ToString());
            }
            _httpContextAccessor = httpContextAccessor;
        }

        public BaseReadOnlyModel()
        {
            // TODO: Complete member initialization
        }
        [HiddenInput(DisplayValue = false)]
        public virtual int Id { get; set; }
        public virtual WebPage WebPage {get; set;}
        public virtual bool UserHasEditRights { get; set; }
        public virtual bool UserIsAdmin { get; set; }
        public virtual string Controller { get; set; }
    }
}