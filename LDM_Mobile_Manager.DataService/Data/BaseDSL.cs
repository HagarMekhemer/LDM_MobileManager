﻿using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using LDM_Mobile_Manager.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.DataService.Data
{
    public class BaseDSL<T> : IBaseDSL<T>
    {
        private readonly IBaseRepo<T> _repository;

        public BaseDSL(IBaseRepo<T> repository)
        {
            _repository = repository;
        }

        public async Task<ResponseDTO<List<T>>> GetAllAsync()
        {
            var data = await _repository.GetAllAsync();
            return new ResponseDTO<List<T>>(true, "Request Processed Successfully", data);
        }
    }
}
