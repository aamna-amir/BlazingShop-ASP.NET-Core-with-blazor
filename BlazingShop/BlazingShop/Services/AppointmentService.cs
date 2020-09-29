using BlazingShop.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Services
{
    public class AppointmentService
    {
        private readonly ApplicationDbContext _db;
        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateAppoitment(Appointment appointment)
        {
            appointment.productId = appointment.Product.Id;
            appointment.Product = null;
            _db.Appointments.Add(appointment);
            _db.SaveChanges();
            return true;
        }

        public Appointment GetAppointment(int appointmentId)
        {
            Appointment obj = new Appointment();
            return _db.Appointments.FirstOrDefault(a => a.Id == appointmentId);
        }

        public List<Appointment> GetAppointments()
        {
            return _db.Appointments.Include(u => u.Product).Include(u => u.Product.Category).ToList();
            //return _db.Appointments.ToList();
        }

        public bool ConfirmAppointment(Appointment objAppointment)
        {
            var ExistingAppointment = _db.Appointments.FirstOrDefault(x => x.Id == objAppointment.Id);
            if (ExistingAppointment != null)
            {
                ExistingAppointment.IsConfirmed = true;
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool UpdateAppointment(Appointment objAppointment)
        {
            var existingAppointment = _db.Appointments.FirstOrDefault(u => u.Id == objAppointment.Id);
            if (existingAppointment != null)
            {
                _db.Appointments.Update(objAppointment);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteAppointment(Appointment objAppointment)
        {
            var existingAppointment = _db.Appointments.FirstOrDefault(u => u.Id == objAppointment.Id);
            if (existingAppointment != null)
            {
                _db.Appointments.Remove(existingAppointment);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
