﻿using Business.Dtos.Model;

namespace Business.Responses.Model
{
    public class GetModelListResponse
    {
        public ICollection<ModelListItemDto> Items { get; set; }
    }
}

