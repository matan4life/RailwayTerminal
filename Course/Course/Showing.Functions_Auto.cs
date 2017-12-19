using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Course
{
    public partial class Showing
    {
        double TrainCost(double distance, int number)
        {
            double power = 0;
            string type = "";
            using (SqlConnection connection=new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT Propulsion, Type FROM EngineModels WHERE Name IN (SELECT Type FROM Engine WHERE EngineId=(SELECT EngineId FROM Train WHERE TrainId="+number+"))";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    power = Convert.ToDouble(reader.GetInt32(0));
                    type = reader.GetString(1);
                }
            }
            power *= 0.735;
            double time = Time(number);
            double energy = time * power;
            if (type=="Электровоз" || type == "Интерсити")
            {

            }
            return 0;
        }
        double Time(int number)
        {
            DateTime start=new DateTime(), end=new DateTime();
            int counter = 0;
            double time=0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT ArrivalTime FROM TrainStations WHERE TrainId="+number;
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (counter == 0)
                    {
                        start = Convert.ToDateTime(reader.GetValue(0));
                    }
                    else
                    {
                        end = Convert.ToDateTime(reader.GetValue(0));
                    }
                    counter++;
                }
            }
            time = end.Hour * 3600 + end.Minute * 60 + end.Second - start.Hour * 3600 - start.Minute * 60 - start.Second;
            if (time < 0)
            {
                time += 86400;
            }
            return time;
        }
    }
}
