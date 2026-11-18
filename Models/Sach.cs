using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace PhamThiThuyQuynh_241230831.Models;

public partial class Sach
{
    [Key]
    public int MaSach { get; set; }

    public int MaTl { get; set; }

    [Required(ErrorMessage ="Ten sach khong duoc de trong")]
    public string TenSach { get; set; } = null!;

    [Range(50, 1000, ErrorMessage= "Gia phai tu 50-1000")]
    public decimal? Gia { get; set; }

    public string? Anh { get; set; }

    public virtual TheLoai MaTlNavigation { get; set; } = null!;
}
