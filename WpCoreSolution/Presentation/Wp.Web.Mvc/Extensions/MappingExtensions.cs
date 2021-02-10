﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nsr.Common.Services;
using System.Linq;
using Wp.Core.Domain.Sections;
using Wp.Core.Domain.Security;
using Wp.Core.Domain.WebPages;
using Wp.Services.Sections;
using Wp.Services.WebPages;
using Wp.Web.Mvc.Infrastructure.Mapper;
using Wp.Web.Mvc.Models;
using Wp.Web.Mvc.Models.Sections;

namespace Wp.Web.Mvc.Extensions
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return AutoMapperMvcConfiguration.Mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return AutoMapperMvcConfiguration.Mapper.Map(source, destination);
        }

        #region Sections

        #region HtmlContentSection

        public static HtmlContentSectionModel ToModel(this HtmlContentSection entity)
        {
            return entity.MapTo<HtmlContentSection, HtmlContentSectionModel>();
        }

        public static HtmlContentSection ToEntity(this HtmlContentSectionModel model)
        {
            return model.MapTo<HtmlContentSectionModel, HtmlContentSection>();
        }

        public static HtmlContentSection ToEntity(this HtmlContentSectionModel model, HtmlContentSection destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region ResumeSection

        public static ResumeSectionModel ToModel(this ResumeSection entity)
        {
            return entity.MapTo<ResumeSection, ResumeSectionModel>();
        }

        public static ResumeSection ToEntity(this ResumeSectionModel model)
        {
            return model.MapTo<ResumeSectionModel, ResumeSection>();
        }

        public static ResumeSection ToEntity(this ResumeSectionModel model, ResumeSection destination)
        {
            return model.MapTo(destination);
        }

        #endregion     

        #endregion

        //webpage
        public static WebPageModel ToModel(this WebPage entity, IWebPageService webPageService, ISectionService sectionService)
        {
            if (entity == null)
                return null;

            bool userIsAdmin = webPageService.IsAdminCurrentUser();  
            bool userHasEditRights = webPageService.HasEditRights(entity.Id);
            bool userHasCreateRights = webPageService.HasCreateRights(entity.Id);

            var model = new WebPageModel()
            {
                Id = entity.Id,
                //SidebarVisible = entity.SidebarEnabled,
                UserHasCreateRights = userHasCreateRights,
                AvailableSections = sectionService.GetAvailableSections().Select(x => new SelectListItem { Text = x })
            };

            foreach (var sectionEntity in entity.Sections)
            {
                var sm = GetSectionModel(sectionEntity);
                sm.Id = sectionEntity.Id;
                sm.WebPage = sectionEntity.WebPage;
                sm.UserHasEditRights = userHasEditRights;
                sm.UserIsAdmin = userIsAdmin;
                model.Sections.Add(sm);
            }
            return model;
        }

        private static BaseReadOnlyModel GetSectionModel(Section entity)
        {
            if (entity is HtmlContentSection)
            {
                var htmlContent = new HtmlContentSectionReadOnlyModel();
                htmlContent.Html = ((HtmlContentSection)entity).GetLocalized(x => x.Html);
                htmlContent.Controller = "HtmlContent";
                return htmlContent;
            }
            else if (entity is ResumeSection)
            {
                var resume = new ResumeSectionReadOnlyModel();
                resume.ApplicationUserName = ((ResumeSection)entity).ApplicationUserName;
                resume.Controller = "Resume";
                return resume;
            }           
            return null;
        }
    }   
}