using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReminder.Domain;

namespace MovieReminder.Infrastructure.EntityTypeConfigurations;

internal class UserSessionConfiguration : IEntityTypeConfiguration<UserSession>
{
    public void Configure(EntityTypeBuilder<UserSession> builder)
    {
        builder.HasKey(userSession => userSession.Id);
        builder.HasIndex(userSession => userSession.Id).IsUnique();

        builder.Property(userSession => userSession.Token).IsRequired();

        builder.Property(userSession => userSession.Exp).HasColumnType("date").IsRequired();

        builder.HasOne(userSession => userSession.User)
            .WithMany(user => user.UserSessions)
            .HasForeignKey(userSession => userSession.UserId);
    }
}
