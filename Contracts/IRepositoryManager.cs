using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        IBookAuthorRepository BookAuthor { get; }
        IBookClubRepository BookClub { get; }
        IBookDiscussionRepository BookDiscussion { get; }
        IBookTagRepository BookTag { get; }
        ICollectionRepository Collection { get; }
        ICollectionBooksRepository CollectionBooks { get; }
        IClubMembersRepository ClubMembers { get; }
        ICommentRepository Comment { get; }
        IDiscussionRepository Discussion { get; }
        IFriendListRepository FriendList { get; }
        IFriendPairRepository FriendPair { get; }
        IGenreTagRepository GenreTag { get; }
        IMemberRepository Member { get; }
        IReviewRepository Review { get; }
        void Save();
    }
}
