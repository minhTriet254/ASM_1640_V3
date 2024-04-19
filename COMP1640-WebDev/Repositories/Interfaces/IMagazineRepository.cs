﻿using COMP1640_WebDev.Data;
using COMP1640_WebDev.Models;
using COMP1640_WebDev.ViewModels;

namespace COMP1640_WebDev.Repositories.Interfaces
{
    public interface IMagazineRepository
    {
		MagazineViewModel GetMagazineViewModel();
		MagazineViewModel GetMagazineViewModelByID(string idMagazine);
		Task<IEnumerable<Magazine>> GetMagazines();
        Task<Magazine> GetMagazine(string id);
        Task<Magazine> CreateMagazine(MagazineViewModel magazineViewModel);
        Task<Magazine> UpdateMagazine(MagazineViewModel magazineViewModel);
        Task<Magazine> RemoveMagazine(string id);


    }
}
