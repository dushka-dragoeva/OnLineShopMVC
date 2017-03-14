﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using OnLineShop.Data.Models.Contracts;

namespace OnLineShop.Data.Models
{
    public class Photo : IDbModel

    {
        public const int UrlLengthMinLength = 6;
        public const int UrlLengthMaxValue = 300;

        public int Id { get; set; }

        //  [Required]
        public string PictureBase64 { get; set; }

        [MinLength(UrlLengthMinLength)]
        [MaxLength(UrlLengthMaxValue)]
        public string PictureUrl { get; set; }

        //  [Required]
        [MaxLength(5)]
        public string MimeType { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public bool IsDeleted { get; set; }
    }
}
