﻿using FinalByMyself.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalByMyself.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectsUser> ProjectUser { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TicketAttachment> TicketAttachment { get; set; }
        public DbSet<TicketComment> TicketComment { get; set; }
        public DbSet<TicketHistory> TicketHistory { get; set; }
        public DbSet<TicketNotification> TicketNotification { get; set; }
    }
}