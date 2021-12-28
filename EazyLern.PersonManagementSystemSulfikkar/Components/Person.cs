#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : Person.cs
// Purpose         : To define Person entity
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
    class Person
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the Person Id
        /// </summary>
        public int PersonId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Person Full Name
        /// </summary>
        public string FullName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Person Email Address
        /// </summary>
        public string EmailAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Person City by city id
        /// </summary>
        public int CityId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Person Country by country id
        /// </summary>
        public int CountryId
        {
            get;
            set;
        }

       

        /// <summary>
        /// Gets or sets the Person added date
        /// </summary>
        public DateTime AddedOn
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the deleted status
        /// </summary>
        public bool IsDeleted
        {
            get;
            set;
        }
        #endregion Public Properties

        #region Public Methods

        #region Get All Person With CityName And CountryName
        /// <summary>
        /// Retrieves all person from the person table
        /// </summary>
        /// <returns>DataSet of person</returns>
        public DataTable GetAllPersonWithCityNameAndCountryName()
        {
            SqlDataAdapter daPerson;

            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string SelectQuery = "SELECT per_personid,per_personfullname,per_emailid,cit_cityname,cou_countryname,per_isdeleted FROM pms_person A join pms_city B ON A.per_cityid = B.cit_cityid join pms_country C ON B.cit_countryid = c.cou_countryid where per_isdeleted=0";

            SqlConnection perdbCon = null;
            DataSet dsPerson = new DataSet();

            try
            {
                perdbCon = PersonDBConnection.GetConnetction(); //new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                daPerson = new SqlDataAdapter(SelectQuery, perdbCon);
                daPerson.Fill(dsPerson, "pms_person");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                perdbCon.Close();
            }
            return dsPerson.Tables[0];
        }
        #endregion Get All Person With CityName And CountryName

        #region Insert A Person
        /// <summary>
        /// Insert a person to the parson table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int InsertAPerson()
        {
            int numberOfRowsAffected;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string insertQuery = "insert into pms_person(per_personfullname,per_emailid,per_cityid) values(@fullname,@emailaddress,@cityid)";
            SqlConnection perdbCon = null;

            SqlCommand cmdInsertPerson = null;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction();//new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmdInsertPerson =new SqlCommand(insertQuery, perdbCon);
               
                cmdInsertPerson.Parameters.AddWithValue("@fullname", this.FullName );
                cmdInsertPerson.Parameters.AddWithValue("@emailaddress", this.EmailAddress);
                cmdInsertPerson.Parameters.AddWithValue("@cityid", this.CityId );
          //      cmdInsertPerson.Parameters.AddWithValue("@countryid", this.CountryId);
                numberOfRowsAffected = cmdInsertPerson.ExecuteNonQuery();
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
        #endregion Insert A Person

        #region Edit A Person
        /// <summary>
        /// Edit a person in the parson table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int EditAPerson()
        {
            int numberOfRowsAffected;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string editQuery = "UPDATE pms_person SET per_emailid=@emailaddress,per_cityid=@city,per_personfullname=@name where per_personid=@id";
            SqlConnection perdbCon = null;

            SqlCommand cmdEditPerson = null;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction();//new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmdEditPerson = new SqlCommand(editQuery, perdbCon);

                cmdEditPerson.Parameters.AddWithValue("@id", this.PersonId);
                cmdEditPerson.Parameters.AddWithValue("@emailaddress", this.EmailAddress);
                cmdEditPerson.Parameters.AddWithValue("@city", this.CityId);
                //cmdEditPerson.Parameters.AddWithValue("@country", this.CountryId);
                cmdEditPerson.Parameters.AddWithValue("@name", this.FullName);
                numberOfRowsAffected = cmdEditPerson.ExecuteNonQuery();
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
        #endregion Edit A Person

        #region Delete A Person
        /// <summary>
        /// Delete a person from the parson table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int DeleteAPerson()
        {
            int numberOfRowsAffected;
            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string deleteQuery = "UPDATE pms_person SET  per_isdeleted = 1 where per_personid=@id";
            SqlConnection perdbCon = null;

            SqlCommand cmddeletePerson = null;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction();//new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmddeletePerson = new SqlCommand(deleteQuery, perdbCon);

                cmddeletePerson.Parameters.AddWithValue("@id", this.PersonId );
                numberOfRowsAffected = cmddeletePerson.ExecuteNonQuery();
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
        #endregion Delete A Person

        #endregion Public Methods

        public DataTable GetAll1Countries()
        {
            SqlDataAdapter daPerson;

            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string SelectQuery = " select cou_countryname from pms_country ";

            SqlConnection perdbCon = null;
            DataTable dtPerson = new DataTable();

            try
            {
                perdbCon = PersonDBConnection.GetConnetction(); //new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                daPerson = new SqlDataAdapter(SelectQuery, perdbCon);
                daPerson.Fill(dtPerson);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                perdbCon.Close();
            }
            return dtPerson;

        }

        public DataTable GetAll1Cities(string countryname)
        {
            SqlDataAdapter daPerson;

            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string SelectQuery = "select distinct (cit_cityname) from pms_city join pms_country on cit_countryid = cou_countryid where cou_countryname = @name";
               

            SqlConnection perdbCon = null;
            DataTable dtPerson = new DataTable();
            SqlCommand cmdselectPerson = null;

            try
            {
                perdbCon = PersonDBConnection.GetConnetction();//new SqlConnection(perdbconnectionstring);
                perdbCon.Open();

                cmdselectPerson = new SqlCommand(SelectQuery, perdbCon);

                cmdselectPerson.Parameters.AddWithValue("@name",countryname);
                

                daPerson = new SqlDataAdapter(cmdselectPerson);
               
                daPerson.Fill(dtPerson);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                perdbCon.Close();
            }
            return dtPerson;

        }
    }
}
