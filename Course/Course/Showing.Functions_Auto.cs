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
        double TrainCost(int number, string startstation, string endstation)
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
            power *= 735;
            double time = Time(number, startstation, endstation);
            double energy = time * power;
            if (type=="Электровоз" || type == "Интерсити")
            {
                double price = 1.68;
                double cost1 = energy * price / 3600000;
                cost1 /= (56 * 9);
                cost1 += cost["Интерсити 2 класса"];
                return cost1;
            }
            else
            {
                energy /= 1000000;
                double amount = energy / (43.5 * 0.769);
                amount *= 25;
                amount /= (54 * 13);
                amount += cost["Плацкартный"];
                return amount;
            }
        }
        double Time(int number, string startstation, string endstation)
        {
            TimeSpan start=new TimeSpan(), end=new TimeSpan();
            int counter = 0;
            double time=0;
            int stay = 0, tmp = 0;
            string currentstation = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT ArrivalTime, StayTime, StationId FROM TrainStations WHERE TrainId="+number+" ORDER BY TravelDate, ArrivalTime";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                bool flag = false;
                while (reader.Read())
                {
                    if (reader.GetString(2) == startstation) flag = true;
                    if (!flag) continue;
                    if (counter == 0)
                    {
                        start = reader.GetTimeSpan(0);
                        stay = reader.GetInt32(1);
                        currentstation = reader.GetString(2);
                    }
                    else
                    {
                        end = reader.GetTimeSpan(0);
                        tmp = reader.GetInt32(1);
                        currentstation = reader.GetString(2);
                    }

                    if (currentstation == endstation) break;
                    counter++;
                }
            }
            time = end.TotalSeconds - start.TotalSeconds - stay*60;
            if (time < 0)
            {
                time += 86400;
            }
            return time;
        }
    }
}
