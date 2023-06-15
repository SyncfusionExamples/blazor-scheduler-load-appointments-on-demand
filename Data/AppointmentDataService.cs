using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Microsoft.EntityFrameworkCore;

namespace SchedulerLoadOnDemand.Data
{
    public class AppointmentDataService
    {
        private readonly AppointmentDataContext _appointmentDataContext;

        public AppointmentDataService(AppointmentDataContext appDBContext)
        {
            _appointmentDataContext = appDBContext;
        }

        public async Task<List<AppointmentData>> Get(DateTime StartDate, DateTime EndDate)
        {
            return await _appointmentDataContext.AppointmentDataSet.Where(evt => evt.StartTime >= StartDate && evt.EndTime <= EndDate || evt.RecurrenceRule != null).ToListAsync();
        }

        public async Task Insert(AppointmentData appointment)
        {
            var app = new AppointmentData();            
            app.Subject = appointment.Subject;
            app.StartTime = appointment.StartTime;
            app.EndTime = appointment.EndTime;
            app.IsAllDay = appointment.IsAllDay;
            app.Location = appointment.Location;
            app.Description = appointment.Description;
            app.RecurrenceRule = appointment.RecurrenceRule;
            app.RecurrenceID = appointment.RecurrenceID;
            app.RecurrenceException = appointment.RecurrenceException;
            app.StartTimezone = appointment.StartTimezone;
            app.EndTimezone = appointment.EndTimezone;
            app.IsReadOnly = appointment.IsReadOnly;
            await _appointmentDataContext.AppointmentDataSet.AddAsync(app);
            await _appointmentDataContext.SaveChangesAsync();

        }

        public async Task Update(AppointmentData appointment)
        {
            var app = await _appointmentDataContext.AppointmentDataSet.FirstAsync(c => c.Id == appointment.Id);

            if (app != null)
            {
                app.Subject = appointment.Subject;
                app.StartTime = appointment.StartTime;
                app.EndTime = appointment.EndTime;
                app.IsAllDay = appointment.IsAllDay;
                app.Location = appointment.Location;
                app.Description = appointment.Description;
                app.RecurrenceRule = appointment.RecurrenceRule;
                app.RecurrenceID = appointment.RecurrenceID;
                app.RecurrenceException = appointment.RecurrenceException;
                app.StartTimezone = appointment.StartTimezone;
                app.EndTimezone = appointment.EndTimezone;
                app.IsReadOnly = appointment.IsReadOnly;

                _appointmentDataContext.AppointmentDataSet?.Update(app);
                await _appointmentDataContext.SaveChangesAsync();
            }
        }

        public async Task Delete(int appointmentId)
        {
            var app = await _appointmentDataContext.AppointmentDataSet.FirstAsync(c => c.Id == appointmentId);

            if (app != null)
            {
                _appointmentDataContext.AppointmentDataSet?.Remove(app);
                await _appointmentDataContext.SaveChangesAsync();
            }
        }
    }
}
