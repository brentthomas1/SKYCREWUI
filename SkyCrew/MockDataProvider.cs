using System;
using System.Data;

namespace SkyCrew
{
    /// <summary>
    /// Mock data provider for testing without database connection.
    /// This entire file can be deleted when switching back to real database.
    /// </summary>
    public static class MockDataProvider
    {
        private static readonly Random random = new Random();

        // Mock login credentials for testing
        public static readonly (string Username, string Password, string Role)[] MockCredentials = new[]
        {
            ("admin", "admin123", "Admin"),
            ("pilot1", "pilot123", "Pilot"),
            ("ground1", "ground123", "Ground Crew"),
            ("cs1", "cs123", "Customer Service"),
            ("manager1", "manager123", "Management")
        };

        public static bool ValidateLogin(string username, string password, out string role)
        {
            role = string.Empty;
            var credential = Array.Find(MockCredentials, c => c.Username == username && c.Password == password);
            if (credential != default)
            {
                role = credential.Role;
                return true;
            }
            return false;
        }

        public static DataTable GetMockFlightData(int count = 4)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FlightNumber", typeof(string));
            dt.Columns.Add("DepartureTime", typeof(DateTime));
            dt.Columns.Add("ArrivalTime", typeof(DateTime));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Gate", typeof(string));
            dt.Columns.Add("Aircraft", typeof(string));

            DateTime baseTime = DateTime.Now;
            string[] gates = { "A1", "B2", "C3", "D4", "E5", "F6" };
            string[] aircraft = { "Boeing 737", "Airbus A320", "Boeing 787", "Airbus A350", "Boeing 777", "Airbus A330" };
            string[] statuses = { "Scheduled", "Boarding", "Departed", "Arrived", "Delayed", "Cancelled" };

            for (int i = 0; i < count; i++)
            {
                DateTime departureTime = baseTime.AddHours(random.Next(1, 72));
                DateTime arrivalTime = departureTime.AddHours(random.Next(1, 8));
                dt.Rows.Add(
                    $"FL{1000 + i}",
                    departureTime,
                    arrivalTime,
                    statuses[random.Next(statuses.Length)],
                    gates[random.Next(gates.Length)],
                    aircraft[random.Next(aircraft.Length)]
                );
            }

            return dt;
        }

        public static DataTable GetMockBookingData(int count = 10)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BookingID", typeof(int));
            dt.Columns.Add("PassengerName", typeof(string));
            dt.Columns.Add("FlightNumber", typeof(string));
            dt.Columns.Add("BookingDate", typeof(DateTime));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("TicketPrice", typeof(decimal));

            string[] firstNames = { "John", "Jane", "Bob", "Alice", "David", "Sarah", "Michael", "Emma" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis" };
            string[] statuses = { "Confirmed", "Pending", "Cancelled", "Completed" };

            for (int i = 0; i < count; i++)
            {
                dt.Rows.Add(
                    1000 + i,
                    $"{firstNames[random.Next(firstNames.Length)]} {lastNames[random.Next(lastNames.Length)]}",
                    $"FL{1000 + random.Next(5)}",
                    DateTime.Now.AddDays(-random.Next(30)),
                    statuses[random.Next(statuses.Length)],
                    random.Next(200, 1000)
                );
            }

            return dt;
        }

        public static DataTable GetMockStaffData(int count = 10)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StaffID", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Role", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("HireDate", typeof(DateTime));
            dt.Columns.Add("Status", typeof(string));

            string[] firstNames = { "John", "Jane", "Bob", "Alice", "David", "Sarah", "Michael", "Emma" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis" };
            string[] roles = { "Pilot", "Ground Crew", "Customer Service", "Management", "Admin" };
            string[] statuses = { "Active", "On Leave", "Training", "Inactive" };

            for (int i = 0; i < count; i++)
            {
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                string role = roles[random.Next(roles.Length)];
                
                dt.Rows.Add(
                    100 + i,
                    firstName,
                    lastName,
                    role,
                    $"{firstName.ToLower()}.{lastName.ToLower()}@skycrew.com",
                    DateTime.Now.AddDays(-random.Next(365, 1825)), // 1-5 years ago
                    statuses[random.Next(statuses.Length)]
                );
            }

            return dt;
        }

        public static string[] GetMockNotifications(string userRole, int count = 5)
        {
            string[] pilotNotifications = {
                "New flight assignment available",
                "Schedule change notification",
                "Required training update",
                "Weather advisory for upcoming flight",
                "Maintenance check required",
                "Flight briefing reminder",
                "Route change notification"
            };

            string[] groundCrewNotifications = {
                "New shift available",
                "Equipment maintenance required",
                "Safety briefing scheduled",
                "Gate assignment update",
                "Staff meeting reminder",
                "Training session scheduled",
                "Inventory check required"
            };

            string[] notifications = userRole.ToLower() switch
            {
                "pilot" => pilotNotifications,
                "ground crew" => groundCrewNotifications,
                _ => pilotNotifications
            };

            string[] result = new string[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = notifications[random.Next(notifications.Length)];
            }

            return result;
        }

        public static DataTable GetMockShiftStats()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TotalShifts", typeof(int));
            dt.Columns.Add("AvailableShifts", typeof(int));
            dt.Columns.Add("CompletedShifts", typeof(int));
            dt.Columns.Add("CancelledShifts", typeof(int));

            int totalShifts = random.Next(50, 100);
            int availableShifts = random.Next(5, 15);
            int completedShifts = random.Next(30, 40);
            int cancelledShifts = random.Next(1, 5);

            dt.Rows.Add(totalShifts, availableShifts, completedShifts, cancelledShifts);
            return dt;
        }
    }
} 