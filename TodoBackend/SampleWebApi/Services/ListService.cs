using SampleWebApi.Interfaces;
using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SampleWebApi.Services
{
    public class ListService : IListService
    {
        private readonly Dictionary<string, ListEntity> _dict = new Dictionary<string, ListEntity>();

        public Task<ListEntity> GetList(string name)
        {
            if (_dict.TryGetValue(name, out ListEntity list)) 
                return Task.FromResult(list);

            throw new Exception($"The {name} doesn't exist");
        }

        public Task SaveList(ListEntity listEntity)
        {
            if (!_dict.ContainsKey(listEntity.Name))
            {
                _dict.Add(listEntity.Name, listEntity);
            }
            else
            {
                _dict[listEntity.Name] = listEntity;
            }

            return Task.CompletedTask;
        }
    }
}