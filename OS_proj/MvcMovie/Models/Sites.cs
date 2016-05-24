using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace modeling_SearchBanners.Models
{
    public class Site
    {
        public int SiteID { set; get; }

        [Required]
        [Display(Name = "Заголовок сайта")]
        public string Name { set; get; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "URL")]
        public string Url { set; get; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public String Description { set; get; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Ключевые слова")]
        public String keyWords { set; get; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата регистрации")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateOfregistration { get; set; }

        //ссылка на рекламу
        public List<Commertial> Commertials { set; get; }

    }

    public class Commertial
    {
        public int CommertialID { set; get; }

        [Display(Name = "Номер договора")]
        public Contract contract { set; get; }
        public int? ContractID { set; get; }
            
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public String Description { set; get; }


        public int SiteID { set; get; }
        public virtual Site site { set; get; }  //связка для сайта - навигационное свойство

        //ссылка на типы
        public List<CommertialType> ComertialTypes { set; get; }

    }

    public class CommertialType
    {
        public int CommertialTypeId { set; get; }

        [Display(Name = "Тип рекламы")]
        public string Type { set; get; }

        public int ContractID { set; get; } //внешний ключ взаимодействия для договора
        public virtual Contract Contract { set; get; } //навигационное свойство для класса Contract

        public int CommertialID { set; get; } //внешний ключ взаимодействия для рекламы
        public Commertial Commertial { set; get; }
    }

    public class Contract
    {
        public int ContractID { set; get; }
        private string s = string.Empty;

        [Required]
        [Display(Name = "Номер договора")]
        public int ContractNumber { set; get; }

        [Display(Name = "ФИО партнера или юридическое имя")]
        public string PartnerName { set; get; }

        [Display(Name = "Срок действия")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpiratDate { set; get; }

        [Display(Name = "Адрес")]
        public string Address { set; get; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string phoneNumber { set; get; }

        public virtual List<CommertialType> commertialTypes { set; get; } //может содержать несколько типов
        

    }

    public class SitesDB : DbContext
    {
        public DbSet<CommertialType> commertialTypes { set; get; }
        public DbSet<Commertial> commertial { set; get; }
        public DbSet<Site> sites { set; get; }
        public DbSet<Contract> contracts { set; get; }

        public SitesDB() : base("DefaultConnection") { }
    }
}