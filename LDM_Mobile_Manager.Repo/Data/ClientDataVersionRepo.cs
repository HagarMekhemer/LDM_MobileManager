﻿using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Repo
{
    public class ClientDataVersionRepo : IBaseRepo<GetClientDataVersionResponseDTO>
    {
        public async Task<List<GetClientDataVersionResponseDTO>> GetAllAsync()
        {
            var versions = new List<GetClientDataVersionResponseDTO>
            {
                new GetClientDataVersionResponseDTO
                {
                    Name = "Health Tips",
                    Version = 2,
                    ModifiedAt = DateTime.Parse("2024-08-24T14:15:22Z")
                }
            };

            return await Task.FromResult(versions);
        }
    }
}
