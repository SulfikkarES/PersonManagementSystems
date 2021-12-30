#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 74
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : City.cs
// Purpose         : To define City entity 
// Creation Date   : 12-10-2021
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion Copyright EazyLearn

#region Included namespaces
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion Included namespaces

namespace EazyLern.PersonManagementSystemSulfikkar.Components
{
    class City
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the City Id
        /// </summary>
        public int CityId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CityName
        /// </summary>
        public string CityName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the City Description
        /// </summary>
        public string CityDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the City Added on Date
        /// </summary>
        public DateTime CityAddedOn
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Country Name
        /// </summary>
        public int CountryId
        {
            get;
            set;
        }

        public string CountryName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the deleted status
        /// </summary>
        public bool CityIsDeleted
        {
            get;
            set;
        }
        #endregion Public Properties

        #region Public Methods

        #region Get All Cities
        /// <summary>
        /// Retrieves all Cities from the Cities table
        /// </summary>
        /// <returns>Datset of city</returns>
        public DataSet GetAllCities(int value)
        {
            SqlDataAdapter daCity;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string SelectCityQuery = "SELECT distinct cit_cityname ,cit_citydescription,cit_cityid,cit_cityaddedon,cit_isdeleted from pms_city  WHERE cit_countryid = value ,cit_isdeleted=0";
            SqlConnection perdbCon = null;
            DataSet dsCity = new DataSet();

            try
            {
                perdbCon = PersonDBConnection.GetConnetction();//new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                daCity = new SqlDataAdapter(SelectCityQuery, perdbCon);
                daCity.Fill(dsCity, "pms_city");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                perdbCon.Close();
            }
            return dsCity;
        }
        #endregion Get All Cities

        #region Insert A City
        /// <summary>
        /// inserts a city to city table
        /// </summary>
        /// <returns></returns>
        public int InsertACity()
        {
            int numberOfRowsAffected;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string insertCityQuery = "insert into pms_city(cit_countryid,cit_cityname,cit_citydescription) values(@id,@name,@description)";
            SqlConnection perdbCon = null;
            SqlCommand cmdinsertcity;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction(); //new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmdinsertcity = new SqlCommand(insertCityQuery, perdbCon);
                cmdinsertcity.Parameters.AddWithValue("@name", this.CityName);
                cmdinsertcity.Parameters.AddWithValue("@description", this.CityDescription);
                cmdinsertcity.Parameters.AddWithValue("@id", this.CountryId);
                numberOfRowsAffected = cmdinsertcity.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
               throw ex;
            }
            finally
            {
                perdbCon.Close();
            }
            return numberOfRowsAffected;
        }
        #endregion Insert A City

        #region Edit A City
        /// <summary>
        /// edit a city in the city table
        /// </summary>
        /// <returns></returns>
        public int EditACity()
        {

            int numberOfRowsAffected;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string editCityQuery = "update pms_city set cit_cityname=@name, cit_citydescription=@description where cit_countryid=@id";
            SqlConnection perdbCon = null;
            SqlCommand cmdeditcity;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction(); //new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmdeditcity = new SqlCommand(editCityQuery, perdbCon);
                cmdeditcity.Parameters.AddWithValue("@description", this.CityDescription);
                cmdeditcity.Parameters.AddWithValue("@name", this.CityName);
                cmdeditcity.Parameters.AddWithValue("@id", this.CountryId);
                numberOfRowsAffected = cmdeditcity.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                perdbCon.Close();
            }
            return numberOfRowsAffected;
        }
        #endregion Edit A City

        #region Delete A City
        /// <summary>
        /// delete a city from the city table
        /// </summary>
        /// <returns></returns>
        public int DeleteACity()
        {
            int numberOfRowsAffected;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string deleteCityQuery = "update pms_city set cit_isdeleted =1 where cit_countryid=@id";
            SqlConnection perdbCon = null;
            SqlCommand cmddeletecity;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction(); //new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmddeletecity = new SqlCommand(deleteCityQuery, perdbCon);
                cmddeletecity.Parameters.AddWithValue("@id", this.CountryId);
                numberOfRowsAffected = cmddeletecity.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                perdbCon.Close();
            }
            return numberOfRowsAffected;
        }

        internal DataSet GetAllCities(int v, object value)
        {
            throw new NotImplementedException();
        }
        #endregion Delete A City

        #endregion Public Methods
    }
}
