using Core.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Results;

namespace Core.Abstracts.IServices
{
    public interface IGithubService
    {
        Task<IDataResult<IEnumerable<GithubRepoListDTO>>> GetRepositoriesAsync();
    }
}
