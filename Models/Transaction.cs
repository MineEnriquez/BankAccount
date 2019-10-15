using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models{
public class Transaction
{
    [Key]
    public int TransactionId { get; set; }

    [Required]
    [Display(Name = "Current Balance:")]
    public decimal Amount{ get; set; }

    [NotMapped]
    [Display(Name = "Deposit/Withdraw:")]
    public decimal TransactionAmount { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public int UserId { get; set; }
    public User UserInfo {get; set;}
}

}