using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DistrictQueryLocalDb.Domain
{
    public static class Data
    {
        //这里是连接数据库的连接字段
        private static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\BbiHH\CShapeProject\三级地名\DistricvtQuery\DistrictQueryLocalDb.Domain\Database1.mdf;Integrated Security=True";

        /// <summary>
        /// ADO.NET模型访问数据库
        /// </summary>
        public static IEnumerable<Province> Provinces
        {
            get
            {
                var datas = new List<Province>();

                //连接对象
                SqlConnection con = new SqlConnection();
                con.ConnectionString = constr;
                con.Open();

                //命令对象
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Province";

                //数据读取对象
                SqlDataReader dataReader = cmd.ExecuteReader();

                //遍历查询的数据集
                while (dataReader.Read())// Read()一次读取一行数据
                {
                    var data = new Province()
                    {
                        ProvinceID = dataReader.GetInt32(0),  //0表示读取改行的第0个字段  从0开始
                        ProName = dataReader.GetString(1),
                        ProSort = dataReader.GetInt32(2),
                        ProRemark = dataReader.GetString(3)
                    };
                    datas.Add(data);
                }

                return datas;
            }
        }

        public static IEnumerable<City> Cities
        {
            get
            {
                var datas = new List<City>();

                //连接对象
                SqlConnection con = new SqlConnection();
                con.ConnectionString = constr;
                con.Open();

                //命令对象
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM City";

                //数据读取对象
                SqlDataReader dataReader = cmd.ExecuteReader();

                //遍历查询的数据集
                while (dataReader.Read())// Read()一次读取一行数据
                {
                    var data = new City()
                    {
                        CityID = dataReader.GetInt32(0),  //0表示读取改行的第0个字段  从0开始
                        CityName = dataReader.GetString(1),
                        ProvinceID = dataReader.GetInt32(2),
                        CitySort = dataReader.GetInt32(3),
                    };
                    datas.Add(data);
                }

                return datas;
            }
        }

        public static IEnumerable<District> Districts
        {
            get
            {
                var datas = new List<District>();

                //连接对象
                SqlConnection con = new SqlConnection();
                con.ConnectionString = constr;
                con.Open();

                //命令对象
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM District";

                //数据读取对象
                SqlDataReader dataReader = cmd.ExecuteReader();

                //遍历查询的数据集
                while (dataReader.Read())// Read()一次读取一行数据
                {
                    var data = new District()
                    {
                        DistrictID = dataReader.GetInt32(0),  //0表示读取改行的第0个字段  从0开始
                        DistrictName = dataReader.GetString(1),
                        CityID = dataReader.GetInt32(2),
                        DistrictSort = dataReader.GetInt32(3),
                    };
                    datas.Add(data);
                }

                return datas;
            }
        }
    }
}