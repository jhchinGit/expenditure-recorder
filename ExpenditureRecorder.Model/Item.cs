using ExpenditureRecorder.Data.Enums;
using ExpenditureRecorder.Model;
using System;

namespace ExpenditureRecorder.Data
{
    public class Item
    {
        public ItemType ItemType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
    }
}