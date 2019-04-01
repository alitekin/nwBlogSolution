﻿using nwBlog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nwBlog.WebApp.Areas.Admin.ViewModels.AuthorUser
{
    public class DetailsViewModel
    {
        public AppUser User { get; set; }

        public List<Like> Likes { get; set; }
        public List<Comment> Comments { get; set; }
        public List<LastVisit> LastVisits { get; set; }
        public List<Entities.Log> Logs { get; set; }
        public List<AppRole> Roles { get; set; }
        public List<Entities.Blog> Blogs { get; set; }

        public DetailsViewModel()
        {
            Likes = new List<Like>();
            Comments = new List<Comment>();
            LastVisits = new List<LastVisit>();
            Logs = new List<Entities.Log>();
            Roles = new List<AppRole>();
            Blogs = new List<Entities.Blog>();
        }
    }
}