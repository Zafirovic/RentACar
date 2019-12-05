using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CassandraDataLayer.QueryEntities;
using Cassandra;

namespace CassandraDataLayer
{
	public static class DataProvider
	{
		#region Cars

		public static Car getCar(string CarID)
		{
			ISession session = SessionManager.GetSession();
			Car car = new Car();

			if(session == null)
			{
				return null;
			}

			Row carData = session.Execute("select * from \"car\" where \"id\"=" + CarID).FirstOrDefault();

			if(carData != null)
			{
				car.id = carData["id"] != null ? carData["id"].ToString() : string.Empty;
				car.model = carData["model"] != null ? carData["model"].ToString() : string.Empty;
				car.naziv = carData["naziv"] != null ? carData["naziv"].ToString() : string.Empty;
			}

			return car;
		}

		public static List<Car> getCars()
		{
			ISession session = SessionManager.GetSession();

			if(session == null)
			{
				return null;
			}

			List<Car> cars = new List<Car>();

			var carsData = session.Execute("select * from \"car\"");

			foreach(var car in carsData)
			{
				Car cr = new Car();

				cr.id = car["id"] != null ? car["id"].ToString() : string.Empty;
				cr.model = car["model"] != null ? car["model"].ToString() : string.Empty;
				cr.naziv = car["naziv"] != null ? car["naziv"].ToString() : string.Empty;

				cars.Add(cr);
			}

			return cars;
		}

		public static void AddCar(string carID, string model, string naziv)
		{
			ISession session = SessionManager.GetSession();

			if(session == null)
			{
				return;
			}

			RowSet carData = session.Execute("insert into \"car\" (id, model, naziv) values('" + carID + "','" + model + "','" + naziv + "')");
		}

		public static void deleteCar(string carID)
		{
			ISession session = SessionManager.GetSession();

			if(session == null)
			{
				return;
			}

			RowSet carData = session.Execute("delete from \"car\" where \"id\" = '" + carID + "'");
		}

		#endregion

		#region Klijent

		public static Klijent getKlijent(string jmbg)
		{
			ISession session = SessionManager.GetSession();
			Klijent klijent = new Klijent();

			if (session == null)
			{
				return null;
			}

			Row klijentData = session.Execute("select * from \"klijent\" where \"jmbg\"=" + jmbg).FirstOrDefault();

			if (klijentData != null)
			{
				klijent.jmbg = klijentData["jmbg"] != null ? klijentData["jmbg"].ToString() : string.Empty;
				klijent.ime = klijentData["ime"] != null ? klijentData["ime"].ToString() : string.Empty;
				klijent.prezime = klijentData["prezime"] != null ? klijentData["prezime"].ToString() : string.Empty;
			}

			return klijent;
		}

		public static List<Klijent> getKlijents()
		{
			ISession session = SessionManager.GetSession();

			if (session == null)
			{
				return null;
			}

			List<Klijent> klijenti = new List<Klijent>();

			var klijentsData = session.Execute("select * from \"klijent\"");

			foreach (var klijent in klijentsData)
			{
				Klijent kl = new Klijent();

				kl.jmbg = klijent["jmbg"] != null ? klijent["jmbg"].ToString() : string.Empty;
				kl.ime = klijent["ime"] != null ? klijent["ime"].ToString() : string.Empty;
				kl.prezime = klijent["prezime"] != null ? klijent["prezime"].ToString() : string.Empty;

				klijenti.Add(kl);
			}

			return klijenti;
		}

		public static void AddKlijent(string jmbg, string ime, string prezime)
		{
			ISession session = SessionManager.GetSession();

			if (session == null)
			{
				return;
			}

			RowSet klijentData = session.Execute("insert into \"klijent\" (jmbg, ime, prezime) values('" + jmbg + "','" + ime + "','" + prezime + "')");
		}

		public static void deleteKlijent(string jmbg)
		{
			ISession session = SessionManager.GetSession();

			if (session == null)
			{
				return;
			}

			RowSet klijentData = session.Execute("delete from \"klijent\" where \"jmbg\" = '" + jmbg + "'");
		}

		#endregion

		#region Klijent

		public static Radnik getRadnik(string jmbg)
		{
			ISession session = SessionManager.GetSession();
			Radnik radnik = new Radnik();

			if (session == null)
			{
				return null;
			}

			Row radnikData = session.Execute("select * from \"radnik\" where \"jmbg\"=" + jmbg).FirstOrDefault();

			if (radnikData != null)
			{
				radnik.jmbg = radnikData["jmbg"] != null ? radnikData["jmbg"].ToString() : string.Empty;
				radnik.ime = radnikData["ime"] != null ? radnikData["ime"].ToString() : string.Empty;
				radnik.prezime = radnikData["prezime"] != null ? radnikData["prezime"].ToString() : string.Empty;
			}

			return radnik;
		}

		public static List<Radnik> getRadnik()
		{
			ISession session = SessionManager.GetSession();

			if (session == null)
			{
				return null;
			}

			List<Radnik> radnici = new List<Radnik>();

			var radniciData = session.Execute("select * from \"radnik\"");

			foreach (var radnik in radniciData)
			{
				Radnik rd = new Radnik();

				rd.jmbg = radnik["jmbg"] != null ? radnik["jmbg"].ToString() : string.Empty;
				rd.ime = radnik["ime"] != null ? radnik["ime"].ToString() : string.Empty;
				rd.prezime = radnik["prezime"] != null ? radnik["prezime"].ToString() : string.Empty;

				radnici.Add(rd);
			}

			return radnici;
		}

		public static void AddRadnik(string jmbg, string ime, string prezime)
		{
			ISession session = SessionManager.GetSession();

			if (session == null)
			{
				return;
			}

			RowSet radnikData = session.Execute("insert into \"radnik\" (jmbg, ime, prezime) values('" + jmbg + "','" + ime + "','" + prezime + "')");
		}

		public static void deleteRadnik(string jmbg)
		{
			ISession session = SessionManager.GetSession();

			if (session == null)
			{
				return;
			}

			RowSet radnikData = session.Execute("delete from \"radnik\" where \"jmbg\" = '" + jmbg + "'");
		}

		#endregion
	}
}
