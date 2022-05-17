﻿using goodtrip.Models;
using goodtrip.Storage.Entity;

namespace goodtrip.Managers
{
    public interface IProfileManager
    {
        DocumentsModel DocumentsInfo(string username);
        Task ChangeDocumentsAsync(string username, DocumentsModel profile);
        void CreateTour(string username, NewTourModel newTourModel, IFormFileCollection files);
        List<Tour> AllTours(string username);
        void RemoveTour(string id);
        List<RequestModel> AllRequests(string username);
    }
}