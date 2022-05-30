using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PlantsShopAdmin
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

                flower.Picture.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + flower.FlowerName.Text + ".png");
                DateTime date = reader.GetDateTime(5);
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
                flower.price.Text = Price + " грн.";
                flower.PPrice = Convert.ToInt32(Price);

                flower.Picture.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + flower.FlowerName.Text + ".png");

                DateTime date = reader.GetDateTime(5);
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

            foreach (int i in TopCount)
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

                    flower.Picture.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + flower.FlowerName.Text + ".png");
                    DateTime date = reader.GetDateTime(5);
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
            string query = "INSERT INTO ticket(UserID, UserName, UserAddress, UserNumber, FlowerID, Count, Price) VALUES  ('" + UserID + "', '" + UserName + "', '" + UserAdress + "', '" + UserPhone + "', '" + FlowerID + "', '" + Count + "', '" + Price + "')";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteScalar();

            query = "INSERT INTO UsersData(UserID, UserName, UserAdress, UserPhone) VALUES  ('" + UserID + "', '" + UserName + "', '" + UserAdress + "', '" + UserPhone + "')";
            cmd = new MySqlCommand(query, cn);
            cmd.ExecuteScalar();
        }

        List<Orders> OrderData()
        {
            List<Orders> orders = new List<Orders>();
            string query = "SELECT ID, UserID,  UserName, UserAddress, UserNumber, FlowerID, Count, Price FROM `ticket`";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Orders orders1 = new Orders();
                orders1.ID = reader.GetInt32(0);
                orders1.UserID = reader.GetString(1);
                orders1.Name = reader.GetString(2);
                orders1.Adress = reader.GetString(3);
                orders1.Phone = reader.GetString(4);
                orders1.FlowerID = reader.GetInt32(5);
                orders1.Count = reader.GetInt32(6);
                orders1.Price = reader.GetInt32(7);

                orders.Add(orders1);

            }
            reader.Close();

            return orders;
        }

        string GetFlowerName(int ID)
        {
            string result = "";
            string query = "SELECT Name FROM `catalog` WHERE ID = '" + ID + "'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetString(0);

            }
            reader.Close();

            return result;
        }

        public List<Tabs.User> usersOrders()
        {
            List<Tabs.User> orders = new List<Tabs.User>();
            List<Orders> orderInfo = OrderData();
            foreach (var Info in orderInfo)
            {
                Tabs.User ord = new Tabs.User();
                string UserInfo = "Ім'я: " + Info.Name + "  Адреса: " + Info.Adress + "  Номер: " + Info.Phone;
                string FlowerInfo = "Квітка: " + GetFlowerName(Info.FlowerID) + "  Кількість: " + Info.Count + "  Ціна: " + Info.Price;

                ord.UserInfo.Text = UserInfo;
                ord.FlowerInfo.Text = FlowerInfo;

                ord.Pcount = Info.Count;
                ord.FlowerID = Info.FlowerID;
                ord.ID = Info.ID;
                ord.UserID = Info.UserID;
                ord.UserName = Info.Name;
                ord.Phone = Info.Phone;
                ord.Adress = Info.Adress;
                ord.PPrice = Info.Price;

                orders.Add(ord);
            }

            return orders;
        }


        public bool DeleteFromTickets(int ID, int Count, int FlowerID, bool IsUserDelete)
        {

            try
            {
                string query = "DELETE FROM `ticket` WHERE `ID` = '" + ID + "'";
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


        public void BackupFLower(string UserName, string UserID, string Phone, string Adress, int FlowerID, int Count, int Price, int ID)
        {
            bool isDelete = DeleteFromTickets(ID, Count, FlowerID, false);

            string query = "INSERT INTO BackUptickets(UserID, UserName, UserAddress, UserNumber, FlowerID, Count, Price) VALUES  ('" + UserID + "', '" + UserName + "', '" + Adress + "', '" + Phone + "', '" + FlowerID + "', '" + Count + "', '" + Price + "')";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteScalar();
        }

        public void AddFlower(string Name, string Desc, int Count, int Price)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");

            string query = "INSERT INTO catalog(Name, Description, Count, Price, Date) VALUES  ('" + Name + "', '" + Desc + "', '" + Count + "', '" + Price + "', '" + sqlFormattedDate + "')";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteScalar();
        }


        public List<string> GetFlowersName()
        {
            List<string> Name = new List<string>();

            string query = "SELECT Name FROM catalog";

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Name.Add(reader.GetString(0));
            }
            reader.Close();

            return Name;
        }

        public FlowerDate GetFlowerDate(string Name)
        {
            FlowerDate flower = new FlowerDate();

            string query = "SELECT ID, Name, Description, Count, Price FROM catalog  WHERE Name = '" + Name + "'";

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                flower.ID = reader.GetInt32(0);
                flower.Name = reader.GetString(1);
                flower.Desc = reader.GetString(2);
                flower.Count = reader.GetInt32(3);
                flower.Price = reader.GetInt32(4);
                flower.Picture = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + flower.Name + ".png");
            }
            reader.Close();


            return flower;
        }

        public void DeleteFromCatalog(int ID)
        {
            string query = "DELETE FROM `catalog` WHERE `ID` = '" + ID + "'";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteScalar();
        }
    }
}
