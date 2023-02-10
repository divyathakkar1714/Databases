using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class LicenceData
{
    public string conn = @"Data Source=DIVU\SQLEXPRESS;Initial Catalog=LicenceDatabase;Integrated Security=True";
    public DataTable GetLicenceList()
    {
        string query = "select * from LicenceData";
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Connection = con;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        con.Close();
        return ds.Tables[0];
    }
    public DataTable GetLicenceById(int L_ID)
    {
        string query = "select * from LicenceData where id = " + L_ID;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Connection = con;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        con.Close();
        return ds.Tables[0];
    }
    public void InsertLicenceData(string name, string address, string dob, string idate, string edate, string state, string zip, string mobile, string photo)
    {
        string query = "Insert into LicenceData(name,address,dob,idate,edate,state,zip,mobile,photo) values('" + name + "','" + address + "','" + dob + "','" + idate + "','" + edate + "','" + state + "','" + zip + "','" + mobile + "','" + photo + "')";
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
    }
}