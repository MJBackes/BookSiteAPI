using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext repositoryContext;
        private IAuthorRepository authorRepository;
        private IBookRepository bookRepository;
        private IBookAuthorRepository bookAuthorRepository;
        private IBookClubRepository bookClubRepository;
        private IBookDiscussionRepository bookDiscussionRepository;
        private IBookTagRepository bookTagRepository;
        private ICollectionRepository collectionRepository;
        private ICollectionBooksRepository collectionBooksRepository;
        private IClubMembersRepository clubMembersRepository;
        private ICommentRepository commentRepository;
        private IDiscussionRepository discussionRepository;
        private IFriendListRepository friendListRepository;
        private IFriendPairRepository friendPairRepository;
        private IGenreTagRepository genreTagRepository;
        private IMemberRepository memberRepository;
        private IReviewRepository reviewRepository;
        public RepositoryManager(RepositoryContext context)
        {
            repositoryContext = context;
        }
        public IAuthorRepository Author
        {
            get
            {
                if (authorRepository == null)
                    authorRepository = new AuthorRepository(repositoryContext);
                return authorRepository;
            }
        }
        public IBookRepository Book
        {
            get
            {
                if (bookRepository == null)
                    bookRepository = new BookRepository(repositoryContext);
                return bookRepository;
            }
        }
        public IBookAuthorRepository BookAuthor
        {
            get
            {
                if (bookAuthorRepository == null)
                    bookAuthorRepository = new BookAuthorRepository(repositoryContext);
                return bookAuthorRepository;
            }
        }
        public IBookClubRepository BookClub
        {
            get
            {
                if (bookClubRepository == null)
                    bookClubRepository = new BookClubRepository(repositoryContext);
                return bookClubRepository;
            }
        }
        public IBookDiscussionRepository BookDiscussion
        {
            get
            {
                if (bookDiscussionRepository == null)
                    bookDiscussionRepository = new BookDiscussionRepository(repositoryContext);
                return bookDiscussionRepository;
            }
        }
        public IBookTagRepository BookTag
        {
            get
            {
                if (bookTagRepository == null)
                    bookTagRepository = new BookTagRepository(repositoryContext);
                return bookTagRepository;
            }
        }
        public ICollectionRepository Collection
        {
            get
            {
                if (collectionRepository == null)
                    collectionRepository = new CollectionRepository(repositoryContext);
                return collectionRepository;
            }
        }
        public ICollectionBooksRepository CollectionBooks
        {
            get
            {
                if (collectionBooksRepository == null)
                    collectionBooksRepository = new CollectionBooksRepository(repositoryContext);
                return collectionBooksRepository;
            }
        }
        public IClubMembersRepository ClubMembers
        {
            get
            {
                if (clubMembersRepository == null)
                    clubMembersRepository = new ClubMembersRepository(repositoryContext);
                return clubMembersRepository;
            }
        }
        public ICommentRepository Comment
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(repositoryContext);
                return commentRepository;
            }
        }
        public IDiscussionRepository Discussion
        {
            get
            {
                if (discussionRepository == null)
                    discussionRepository = new DiscussionRepository(repositoryContext);
                return discussionRepository;
            }
        }
        public IFriendListRepository FriendList
        {
            get
            {
                if (friendListRepository == null)
                    friendListRepository = new FriendListRepository(repositoryContext);
                return friendListRepository;
            }
        }
        public IFriendPairRepository FriendPair
        {
            get
            {
                if (friendPairRepository == null)
                    friendPairRepository = new FriendPairRepository(repositoryContext);
                return friendPairRepository;
            }
        }
        public IGenreTagRepository GenreTag
        {
            get
            {
                if (genreTagRepository == null)
                    genreTagRepository = new GenreTagRepository(repositoryContext);
                return genreTagRepository;
            }
        }
        public IMemberRepository Member
        {
            get
            {
                if (memberRepository == null)
                    memberRepository = new MemberRepository(repositoryContext);
                return memberRepository;
            }
        }
        public IReviewRepository Review
        {
            get
            {
                if (reviewRepository == null)
                    reviewRepository = new ReviewRepository(repositoryContext);
                return reviewRepository;
            }
}
public void Save() => repositoryContext.SaveChanges();
    }
}
