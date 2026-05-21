using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class LoanConfigurations : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            
            builder.HasKey(loan => loan.Id);

            
            builder.Property(loan => loan.LoanDate)
                .IsRequired();

            builder.Property(loan => loan.DueDate)
                .IsRequired();

            builder.Property(loan => loan.ReturnDate);

            builder.Property(loan => loan.Status)
                .IsRequired();

            
            builder.HasOne(loan => loan.User)
                .WithMany(user => user.Loans)
                .HasForeignKey(loan => loan.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            
            builder.HasOne(loan => loan.BookCopy)
                .WithMany(bookcopy => bookcopy.Loans)
                .HasForeignKey(loan => loan.BookCopyId)
                .OnDelete(DeleteBehavior.Restrict);

           
            builder.ToTable("Loans");
        }
    }
}