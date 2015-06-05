using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace arkadaslar.Models
{
    public class Post
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the context")]
        public string Context { get; set; }

        public DateTime PostDateTime { get { return DateTime.Now; } }
        public string CreatedBy { get; set; }

        public string preview { set; get; }

        public virtual ICollection<Pictures> Pictures { get; set; }
        public virtual ICollection<PicturePaths> PicturePaths { get; set; }

    }

    public class Pictures
    {
        [Key]
        public int Picture_Id { get; set; }
        [StringLength(255)]
        public string Picture_Name { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public PictureType PictureType { get; set; }
        public int ID { get; set; }
        public virtual Post post { get; set; }
    }
    public class PicturePaths
    {
        [Key]
        public int PicturePathId { get; set; }
        [StringLength(255)]
        public string PicturePathName { get; set; }
        public PictureType PicturePathType { get; set; }
        public int ID { get; set; }
        public virtual Post post { get; set; }
    }
    public enum PictureType
    {
        Picture = 1, Photo
    }
}