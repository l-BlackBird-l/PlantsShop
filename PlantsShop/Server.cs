using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsShop
{
    public class Server
    {
        static string StringConnection = @"server=localhost;port=3306;username=root;password=root;database=flowers;";
        static MySqlConnection cn = new MySqlConnection(StringConnection);

       public Server()
       {
           if (cn.State == System.Data.ConnectionState.Closed) cn.Open();
       }

        public List<Tabs.Flower> LoadFlower()
        {
            List<Tabs.Flower> flowers = new List<Tabs.Flower>();

            string query = "SELECT * FROM catalog";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Tabs.Flower flower = new Tabs.Flower();
                flower.ID = reader.GetInt32(0);
                flower.FlowerName.Text = reader.GetString(1);
                flower.Desc.Text = reader.GetString(2);
                int count = reader.GetInt32(3);
                if (count > 0)
                {
                    flower.count.Text = "В наявності";
                    flower.count.ForeColor = Color.FromArgb(0 , 59, 145, 22);
                    flower.Pcount = count;
                }
                else
                {
                    flower.count.Text = "Нема в наявності";
                    flower.count.ForeColor = Color.Red;
                }

                string Price = reader.GetString(4);
                flower.price.Text = Price + " грн.";
                flower.PPrice = Convert.ToInt32(Price);

                flower.Picture.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\Flowers\\" + reader.GetString(5));
                DateTime date = reader.GetDateTime(6);
                DateTime dateNOW = DateTime.Now;

                var days = (dateNOW - date).TotalDays;

  
                if (days <= 7) flower.New.Visible = true;
                flowers.Add(flower);

            }
            reader.Close();

            return flowers;
        }

        public List<Tabs.Flower> SearchFlower(string Name)
        {
            List<Tabs.Flower> flowers = new List<Tabs.Flower>();

            string query = "SELECT * FROM `catalog` WHERE `Name` LIKE '%" + Name + "%'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Tabs.Flower flower = new Tabs.Flower();
                flower.ID = reader.GetInt32(0);
                flower.FlowerName.Text = reader.GetString(1);
                flower.Desc.Text = reader.GetString(2);
                int count = reader.GetInt32(3);
                if (count > 0)
                {
                    flower.count.Text = "В наявності";
                    flower.Pcount = count;
                    flower.count.ForeColor = Color.FromArgb(0, 59, 145, 22);
                }
                else
                {
                    flower.count.Text = "Нема в наявності";
                    flower.count.ForeColor = Color.Red;
                }

                string Price = reader.GetString(4);
                flower.price.Text =  Price + " грн.";
                flower.PPrice = Convert.ToInt32(Price);

                flower.Picture.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + reader.GetString(5));

                DateTime date = reader.GetDateTime(6);
                DateTime dateNOW = DateTime.Now;

                var days = (dateNOW - date).TotalDays;


                if (days <= 7) flower.New.Visible = true;
 
                flowers.Add(flower);
            }
            reader.Close();
            return flowers;
        }

        public void BuyFlower(string UserID, int FlowerID, int Count, int Price)
        {
            string query = "INSERT INTO backet(UserID, FlowerID, Count, Price) VALUES ('" + UserID + "', '" + FlowerID + "', '" + Count + "', '" + Price + "')";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            var Result = Convert.ToString(cmd.ExecuteScalar());

            query = "SELECT Count FROM catalog WHERE ID = '" + FlowerID + "'";
            cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int Coun = 0;
            while (reader.Read())
            {
                Coun = reader.GetInt32(0);
            }
            reader.Close();
            Coun -= Count;
            query = "Update catalog set Count = '" + Coun + "' where ID = '" + FlowerID + "'";
            cmd = new MySqlCommand(query, cn);
            cmd.ExecuteScalar();
        }

        public List<Tabs.UserFlower> GetUserBusket(string UserID)
        {
            List<Tabs.UserFlower> flowers = new List<Tabs.UserFlower>();

            string query = "SELECT ID, FlowerID, Count, Price FROM backet WHERE UserID = '" + UserID + "'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Tabs.UserFlower user = new Tabs.UserFlower();
                user.ID = reader.GetInt32(0);
                user.FlowerID = reader.GetInt32(1);
                int Count = reader.GetInt32(2);
                int Price = reader.GetInt32(3);
                user.Pcount = Count;
                user.PPrice = Price;
                user.Count.Text = "Кількість: " + Count +" Ціна: " + Price + "грн.";
                flowers.Add(user);
            }
            reader.Close();
 
            return flowers;
        }

        public List<Tabs.UserFlower> UserBusket(string UserID)
        {
            List<Tabs.UserFlower> flowers = GetUserBusket(UserID);
            
            foreach (var obj in flowers)
            {
                int ID = obj.FlowerID;

                string query = "SELECT Name, Picture FROM catalog WHERE ID = '" + ID + "'";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    obj.FlowerName.Text = reader1.GetString(0);
                    obj.Picture.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + reader1.GetString(1));
                }
                reader1.Close();
            }

            return flowers;
        }

        public int GetStatus(int ID)
        {
            int Count = 0;
            string query = "SELECT Count FROM catalog WHERE ID = '" + ID + "'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Count = reader.GetInt32(0);

            }
            reader.Close();
            return Count;
        }


        public List<Tabs.Flower> Hits()
        {
            List<Tabs.Flower> flowers = new List<Tabs.Flower>();
            List<int> TopCount = Top();

            foreach(int i in TopCount)
            {
                string query = "SELECT * FROM catalog WHERE ID = '" + i + "'";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tabs.Flower flower = new Tabs.Flower();
                    flower.ID = reader.GetInt32(0);
                    flower.FlowerName.Text = reader.GetString(1);
                    flower.Desc.Text = reader.GetString(2);
                    int count = reader.GetInt32(3);
                    if (count > 0)
                    {
                        flower.count.Text = "В наявності";
                        flower.count.ForeColor = Color.FromArgb(0, 59, 145, 22);
                        flower.Pcount = count;
                    }
                    else
                    {
                        flower.count.Text = "Нема в наявності";
                        flower.count.ForeColor = Color.Red;
                    }

                    string Price = reader.GetString(4);
                    flower.price.Text = Price + " грн.";
                    flower.PPrice = Convert.ToInt32(Price);

                    flower.Picture.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + reader.GetString(5));
                    DateTime date = reader.GetDateTime(6);
                    DateTime dateNOW = DateTime.Now;

                    var days = (dateNOW - date).TotalDays;

                    if (days <= 7) flower.New.Visible = true;
                    flowers.Add(flower);

                }
                reader.Close();
            }
         
            return flowers;
        }

        List<int> Top()
        {
            List<int> ID = new List<int>();
            
            string query = "SELECT FlowerID FROM `ticket` ORDER BY Count DESC LIMIT 2";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID.Add(reader.GetInt32(0));

            }
            reader.Close();

            return ID;
        }

        public bool DeleteFromBacket(int ID, int Count, int FlowerID, bool IsUserDelete)
        {

            try
            {
                string query = "DELETE FROM `backet` WHERE `ID` = '" + ID + "'";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.ExecuteScalar();
                if (IsUserDelete)
                {
                    query = "SELECT Count FROM catalog WHERE ID = '" + FlowerID + "'";
                    cmd = new MySqlCommand(query, cn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int coun = 0;
                    while (reader.Read())
                    {
                        coun = reader.GetInt32(0);
                    }
                    reader.Close();

                    coun += Count;

                    query = "Update catalog set Count = '" + coun + "' where ID = '" + FlowerID + "'";
                    cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteScalar();
                }
                return true;
            }
            catch (Exception)
            {

            }
            return false;
        }

        public void OrderFlower(int ID, int Count, int FlowerID, string UserID, string UserAdress, string UserName, string UserPhone, int Price)
        {
            string query = "INSERT INTO ticket(UserID, UserName, UserAddress, UserNumber, FlowerID, Count, Price) VALUES  ('" + UserID + "', '" + UserName + "', '" + UserAdress + "', '" +  UserPhone + "', '"  +  FlowerID + "', '" + Count + "', '" + Price + "')";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteScalar();

            query = "INSERT INTO UsersData(UserID, UserName, UserAdress, UserPhone) VALUES  ('" + UserID + "', '" + UserName + "', '" + UserAdress + "', '" + UserPhone + "')";
            cmd = new MySqlCommand(query, cn);
            cmd.ExecuteScalar();
        }
      
          public UsersData Data(string ID)
        {
            UsersData data = new UsersData();

            string query = "SELECT UserName, UserAdress, UserPhone FROM UsersData WHERE UserID = '" + ID + "'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data.UserName = reader.GetString(0);
                data.UserAdress = reader.GetString(1);
                data.UserPhone = reader.GetString(2);

            }
            reader.Close();

            return data;
        }
    }
}
