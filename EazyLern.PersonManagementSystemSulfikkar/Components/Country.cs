#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : Country.cs
// Purpose         : To define Country entity
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
using EazyLern.PersonManagementSystemSulfikkar.Components;
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
    class Country
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the Country Id
        /// </summary>
        public int CountryId
        {
            get;
            set;
        }

        /// <summary>
        ///Gets or sets the City Name
        /// </summary>
        public string CountryName
        {
            get;
            set;
        }

        internal bool Read()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the Country Descriptiions
        /// </summary>
        public string CountryDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Country added date
        /// </summary>
        public DateTime CountryAddedOn
        {
            get;
            set;
        }

       

        /// <summary>
        /// Gets or sets the deleted status
        /// </summary>
        public bool CountryIsDeleted
        {
            get;
            set;
        }
        #endregion Public Properties

        #region Public Methods

        #region Get All Countries
        /// <summary>
        /// Retrieves all contries from the country table
        /// </summary>
        /// <returns>Datset of country</returns>
        public DataTable GetAllCountries()
        {
            SqlDataAdapter daCountry;

            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string SelectCountryQuery = "SELECT distinct cou_countryname,cou_countrydescription,cou_countryaddedon, cou_countryId,cou_isdeleted from pms_country where cou_isdeleted=0";
              SqlConnection perdbCon = null;
            DataSet dsCountry = new DataSet();
            try 
            {
                perdbCon = PersonDBConnection.GetConnetction(); //new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                daCountry = new SqlDataAdapter(SelectCountryQuery, perdbCon);
                daCountry.Fill(dsCountry, "pms_country");
            }
            catch (SqlException ex)
            {
                throw ex ;
            }
            finally
            {
                perdbCon.Close();
            }
            return dsCountry.Tables[0];
        }
        #endregion Get All Countries

        #region Insert A Country
        /// <summary>
        /// Insert a country to the country table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int InsertACountry()
        {
            int numberOfRowsAffected;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string insertCountryQuery = "insert into pms_country(cou_countryname,cou_countrydescription) Values(@name,@description)";
            SqlConnection perdbCon = null;
            SqlCommand cmdinsertcountry;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction();//new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmdinsertcountry = new SqlCommand(insertCountryQuery, perdbCon);
                cmdinsertcountry.Parameters.AddWithValue("@name", this.CountryName);
                cmdinsertcountry.Parameters.AddWithValue("@description", this.CountryDescription);
                numberOfRowsAffected = cmdinsertcountry.ExecuteNonQuery();

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
        #endregion Insert A Country

        #region Edit A Country
        /// <summary>
        ///Edit a country in the country table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int EditACountry()
        {

            int numberOfRowsAffected;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string editCountryQuery = "update pms_country set cou_countrydescription = @description,cou_countryname=@name where cou_countryid = @id";
            SqlConnection perdbCon = null;
            SqlCommand cmdeditcountry;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction();//new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmdeditcountry = new SqlCommand(editCountryQuery, perdbCon);
                cmdeditcountry.Parameters.AddWithValue("@description", this.CountryDescription);
                cmdeditcountry.Parameters.AddWithValue("@name", this.CountryName);
                cmdeditcountry.Parameters.AddWithValue("@id", this.CountryId);
                numberOfRowsAffected = cmdeditcountry.ExecuteNonQuery();

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
        #endregion Edit A Country

        #region Delete A Country
        /// <summary>
        /// Delete a country from the country table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int DeleteACountry()
        {
            int numberOfRowsAffected ;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string deleteCountryQuery = "update pms_country set cou_isdeleted=1 where cou_countryid=@id";
            SqlConnection perdbCon = null;
            SqlCommand cmddeletecountry;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction();//new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmddeletecountry = new SqlCommand(deleteCountryQuery, perdbCon);
                cmddeletecountry.Parameters.AddWithValue("@id", this.CountryId);
                numberOfRowsAffected = cmddeletecountry.ExecuteNonQuery();

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
        #endregion Delete A Country

        #endregion Public Methods
    }
}

