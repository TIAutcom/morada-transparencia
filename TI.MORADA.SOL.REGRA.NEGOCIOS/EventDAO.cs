using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.MORADA.SOL.REGRA.NEGOCIOS;
using TI.MORADA.SOLACESSO.DADOS;

namespace TI.MORADA.SOL.REGRA.NEGOCIOS
{
    public class EventDAO
    {
        private static string connectionString = ConfigurationManager.AppSettings["DBConnString"];


        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        //this method retrieves all events within range start-end
        public static List<CalendarEvent> getEvents(DateTime start, DateTime end)
        {
            List<CalendarEvent> events = new List<CalendarEvent>();

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT event_id, description, title, event_start, event_end, all_day, status, local FROM Evento where event_start>=@start AND event_end<=@end", con);
            cmd.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@end", SqlDbType.DateTime).Value = end;

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    events.Add(new CalendarEvent()
                    {
                        id = Convert.ToInt32(reader["event_id"]),
                        title = Convert.ToString(reader["title"]),
                        description = Convert.ToString(reader["description"]),
                        start = Convert.ToDateTime(reader["event_start"]),
                        end = Convert.ToDateTime(reader["event_end"]),
                        allDay = Convert.ToBoolean(reader["all_day"]),
                        status = Convert.ToString(reader["status"]),
                        local = Convert.ToString(reader["local"]),
                    });
                }
            }

            return events;
        }

        public static void updateEvent(int id, String title, String description, string status)
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(connectionString);

            if (title != "")
            {
                cmd = new SqlCommand("UPDATE Evento SET title=@title, description=@description, status=@status WHERE event_id=@event_id", con);

                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@event_id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            }
            else
            {
                cmd = new SqlCommand("UPDATE Evento SET description=@description, status=@status WHERE event_id=@event_id", con);

                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@event_id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            }

            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void updateEventTime(int id, DateTime start, DateTime end, bool allDay, string status)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE Evento SET event_start=@event_start, event_end=@event_end, all_day=@all_day, status=@status WHERE event_id=@event_id", con);
            cmd.Parameters.Add("@event_start", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@event_end", SqlDbType.DateTime).Value = end;
            cmd.Parameters.Add("@event_id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@all_day", SqlDbType.Bit).Value = allDay;
            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;

            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void deleteEvent(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM Evento WHERE (event_id = @event_id)", con);
            cmd.Parameters.Add("@event_id", SqlDbType.Int).Value = id;

            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarTipoEvento()
        {
            string sql = "select * from TipoEvento order by TipoEvento.Descricao desc";

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(dt);

            return dt;
        }

        public DataTable ListarTipoLocal()
        {
            string sql = "select * from TipoImovel ti";

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(dt);

            return dt;
        }

        public static int addEvent(CalendarEvent cevent)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Evento(title, description, event_start, event_end, all_day, status, local) VALUES(@title, @description, @event_start, @event_end, @all_day, @status, @local)", con);
            cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = cevent.title;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = cevent.description;
            cmd.Parameters.Add("@event_start", SqlDbType.DateTime).Value = cevent.start;
            cmd.Parameters.Add("@event_end", SqlDbType.DateTime).Value = cevent.end;
            cmd.Parameters.Add("@all_day", SqlDbType.Bit).Value = cevent.allDay;
            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = cevent.status;
            cmd.Parameters.Add("@local", SqlDbType.VarChar).Value = cevent.local;

            int key = 0;

            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT max(event_id) FROM Evento where title=@title AND description=@description AND event_start=@event_start AND event_end=@event_end AND all_day=@all_day AND status=@status AND local=@local", con);
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = cevent.title;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = cevent.description;
                cmd.Parameters.Add("@event_start", SqlDbType.DateTime).Value = cevent.start;
                cmd.Parameters.Add("@event_end", SqlDbType.DateTime).Value = cevent.end;
                cmd.Parameters.Add("@all_day", SqlDbType.Bit).Value = cevent.allDay;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = cevent.status;
                cmd.Parameters.Add("@local", SqlDbType.VarChar).Value = cevent.local;

                key = (int)cmd.ExecuteScalar();
            }

            return key;
        }
    }
}