using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SampleWebApi.Interfaces
{
    public interface IListService
    {
        Task SaveList(ListEntity listEntity);
        Task<ListEntity> GetList(string name);
    }
}