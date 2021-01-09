﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wp.Common;
using Wp.Core;
using Wp.Core.Domain.Localization;

namespace Wp.Cv.Core.Domain
{
    public class Education : EntityAuditable, ILocalizedEntity
    {            
        public string Name { get; set; }

        public int ResumeId { get; set; }
        public virtual Resume Resume { get; set; }

        private ICollection<EducationItem> _educationItems;
        public virtual ICollection<EducationItem> EducationItems
        {
            get { return _educationItems ?? (_educationItems = new List<EducationItem>()); }
            set { _educationItems = value; }
        }
    }
}
