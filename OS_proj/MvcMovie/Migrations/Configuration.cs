namespace modeling_SearchBanners.Migrations
{
    using modeling_SearchBanners.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<modeling_SearchBanners.Models.SitesDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }

}
