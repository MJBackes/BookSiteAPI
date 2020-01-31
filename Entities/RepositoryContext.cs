using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookClub> BookClubs { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ClubMembers> ClubMembers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<CollectionBooks> CollectionBooks { get; set; }
        public DbSet<BookDiscussions> BookDiscussions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<GenreTag> GenreTags { get; set; }
        public DbSet<BookTags> BookTags { get; set; }
        public DbSet<FriendList> FriendLists { get; set; }
        public DbSet<FriendPair> FriendPairs { get; set; }
        public RepositoryContext( DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FriendPair>().HasKey(c => new { c.FriendId, c.ListId });
        }
    }
}
