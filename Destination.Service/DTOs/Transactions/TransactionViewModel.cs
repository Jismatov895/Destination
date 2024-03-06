﻿namespace Destination.Service.DTOs.Transactions;
public class TransactionViewModel
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long MetroId { get; set; }
    public DateTime Time { get; set; }
    public long CardId { get; set; }
    public decimal Amount { get; set; } = 2000;
}
