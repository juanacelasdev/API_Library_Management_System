using Library.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public LoadStatus Status { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int BookCopyId { get; set; }
        public BookCopy? BookCopy { get; set; }
    }
}
