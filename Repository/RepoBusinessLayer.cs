using Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepoBusinessLayer : IRepoBusinessLayer
    {
        protected IRepositoryManager Manager { get; set; }

        public RepoBusinessLayer(IRepositoryManager repository)
        {
            Manager = repository;
        }
    }
}
