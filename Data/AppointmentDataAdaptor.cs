using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;

namespace SchedulerLoadOnDemand.Data
{
    public class AppointmentDataAdaptor : DataAdaptor
    {
        private readonly AppointmentDataService _appService;
        public AppointmentDataAdaptor(AppointmentDataService appService)
        {
            _appService = appService;
        }

        List<AppointmentData>? EventData;

        //Performs Read operation
        public override async Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {
            System.Collections.Generic.IDictionary<string, object> Params = dataManagerRequest.Params;
            DateTime start = DateTime.Parse((string)Params["StartDate"]);
            DateTime end = DateTime.Parse((string)Params["EndDate"]);
            EventData = await _appService.Get(start, end);
            return dataManagerRequest.RequiresCounts ? new DataResult() { Result = EventData, Count = EventData.Count() } : EventData;
        }

        //Performs Insert operation
        public async override Task<object> InsertAsync(DataManager dataManager, object data, string key)
        {
            await _appService.Insert(data as AppointmentData);
            return data;
        }

        //Performs Update operation
        public async override Task<object> UpdateAsync(DataManager dataManager, object data, string keyField, string key)
        {
            await _appService.Update(data as AppointmentData);
            return data;
        }

        //Performs Delete operation
        public async override Task<object> RemoveAsync(DataManager dataManager, object data, string keyField, string key)
        {
            await _appService.Delete(data as AppointmentData);
            return data;
        }

        //Performs Batch update operations
        public async override Task<object> BatchUpdateAsync(DataManager dataManager, object changedRecords, object addedRecords, object deletedRecords, string keyField, string key, int? dropIndex)
        {
            object records = deletedRecords;
            List<AppointmentData>? deleteData = deletedRecords as List<AppointmentData>;
            if (deleteData != null)
            {
                foreach (var data in deleteData)
                {
                    await _appService.Delete(data as AppointmentData);
                }
            }
            List<AppointmentData>? addData = addedRecords as List<AppointmentData>;
            if (addData != null)
            {
                foreach (var data in addData)
                {
                    await _appService.Insert(data as AppointmentData);
                    records = addedRecords;
                }
            }
            List<AppointmentData>? updateData = changedRecords as List<AppointmentData>;
            if (updateData != null)
            {
                foreach (var data in updateData)
                {
                    await _appService.Update(data as AppointmentData);
                    records = changedRecords;
                }
            }
            return records;
        }
    }
}
