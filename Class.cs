using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace People_Class
{
    class Program
    {
        public class Person
        {

            private string firstName;
            private string middleName;
            private string lastName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;
            private string feedback = "";


            // creating a string of FirstName and making sure that no bad words are entered in Firstname
            public string FirstName
            {

                get
                {
                    return firstName;
                }

                set
                {
                   if (!Validationlibrary.BadWords(value))
                   {
                        firstName = value;
                   }
                    else
                    {
                        feedback += "ERROR: Sorry Contains a bad word.";
                    }
                }
            }


            // creating a string of MiddleName and making sure that no bad words are entered in MiddleName
            public string MiddleName
            {

                get
                {
                    return middleName;
                }

                set
                {
                   if (!Validationlibrary.BadWords(value))
                    {
                        middleName = value;
                    }

                    else
                    {
                        feedback += "\nERROR: Sorry Contains a bad word";
                    }
                }
            }


            // creating a string of LastName and making sure that no bad words are entered in LastName
            public string LastName
            {

                get
                {
                    return lastName;
                }

                set
                {
                    if (!Validationlibrary.BadWords(value))
                    {
                        lastName = value;
                    }

                    else
                    {
                        feedback += "\nERROR: Sorry Contains a bad word";
                    }
                }
            }


            // creating a string of Street1 and making sure that no bad words are entered in Street1
            public string Street1
            {

                get
                {
                    return street1;
                }

                set
                {
                    if (!Validationlibrary.BadWords(value))
                    {
                        street1 = value;
                    }

                    else
                    {
                        feedback += "\nERROR: Sorry Contains a bad word";
                    }
                }
            }

            // creating a string of Street2 and making sure that no bad words are entered in Street2
            public string Street2
            {

                get
                {
                    return street2;
                }

                set
                {
                    if (!Validationlibrary.BadWords(value))
                    {
                        street2 = value;
                    }

                    else
                    {
                        feedback += "\nERROR: Sorry Contains a bad word";
                    }
                }

            }

            // creating a string of City and making sure that no bad words are entered in City
            public string City
            {

                get
                {
                    return city;
                }

                set
                {
                    if (!Validationlibrary.BadWords(value))
                    {
                        city = value;
                    }

                    else
                    {
                        feedback += "\nERROR: Sorry Contains a bad word";
                    }
                }
            }

            // creating a string of Street1 and making sure that user doesnt put more than 2 characters for State
            public string State
            {

                get
                {
                    return state;
                }

                set
                {

                    if (Validationlibrary.State1(value))
                    {
                        state = value;
                    }
                    else
                    {
                        feedback += "\nERROR: Invalid, please re-enter with two characters. Ex(NY).";
                    }
                }
            }


            // creating a string of Street1 and making sure that user doesnt go over 5 characters for the zipcode
            public string Zip
            {
                get
                {
                    return zip;
                }

                set
                {

                    if (Validationlibrary.Zip1(value))
                    {
                        zip = value;
                    }
                    else
                    {
                        feedback += "\nERROR: Invalid Zip length. Max(5)";
                    }

                }
            }

            // creating a string of Street1 and making sure that user doesnt go over the 12 characters that go for the phone number
            public string Phone
            {

                get
                {
                    return phone;
                }

                set
                {

                    if (Validationlibrary.Phone1(value))
                    {
                        phone = value;
                    }
                    else
                    {
                        feedback += "\nERROR: Invalid Phone Length. Max (12), EX(234-457-3435)";
                    }
                    
                }
            }


            // creating a string of Street1 and making sure that user doesnt input incorrect email 
            public string Email
            {
                get
                {
                    return email;
                }

                set
                {

                    if (Validationlibrary.Email1(value))
                    {
                        email = value;
                    }
                    else
                    {
                        feedback += "\nERROR: Invalid Email.";
                    }
                }
            }

            public string Feedback
            {

                get { return feedback; }

            }

            public Person()
            {

                firstName = "";
                middleName = "";
                lastName = "";
                street1 = "";
                street2 = "";
                city = "";
                state = "";
                zip = "";
                phone = "";
                email = "";

            }

            public class PersonV2 : Person
            {

                private string cellphone;
                private string instagramURL;


                // creating a string of Street1 and making sure that user doesnt input incorrect cellphone number
                public string CellPhone
                {

                    get
                    {
                        return cellphone;
                    }

                    set
                    {
                        if (Validationlibrary.Phone2(value))
                        {
                            cellphone = value;
                        }
                        else
                        {
                            feedback += "\nERROR: Invalid Phone Length. Max (12), EX(234-457-3435)";
                        }
                    }
                }


                // creating a string of Street1 and making sure that no bad words go into the instagramURL
                public string InstagramURL
                {

                    get
                    {
                        return instagramURL;
                    }

                    set
                    {
                        if (!Validationlibrary.BadWords(value))
                        {
                            instagramURL = value;
                        }

                        else
                        {
                            feedback += "\nERROR: Sorry Contains a bad word";
                        }
                    }
                }

                // adding a function for the data base for personV2
                public string AddARecord()
                {
                    //Init string var
                    string strResult = "";

                    //Make a connection object
                    SqlConnection Conn = new SqlConnection();

                    //Initialize it's properties
                    Conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE245_NDayan;User Id=SE245_NDayan;Password=008012238;";     //Set the Who/What/Where of DB


                    //*******************************************************************************************************
                    // NEW
                    //*******************************************************************************************************
                    string strSQL = "INSERT INTO PersonV2 (FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, Phone, Email, CellPhone, InstagramURL) VALUES (@FirstName, @MiddleName, @LastName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email, @CellPhone, @InstagramURL)";
                    // Bark out our command
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = strSQL;
                    comm.Connection = Conn;

                    //Filling in the paramters 
                    comm.Parameters.AddWithValue("@FirstName", FirstName);
                    comm.Parameters.AddWithValue("@MiddleName", MiddleName);
                    comm.Parameters.AddWithValue("@LastName", LastName);
                    comm.Parameters.AddWithValue("@Street1", Street1);
                    comm.Parameters.AddWithValue("@Street2", Street2);
                    comm.Parameters.AddWithValue("@City", City);
                    comm.Parameters.AddWithValue("@State", State);
                    comm.Parameters.AddWithValue("@Zip", Zip);
                    comm.Parameters.AddWithValue("@Phone", Phone);
                    comm.Parameters.AddWithValue("@Email", Email);
                    comm.Parameters.AddWithValue("@CellPhone", CellPhone);
                    comm.Parameters.AddWithValue("@InstagramURL", InstagramURL);

                    //*******************************************************************************************************





                    //attempt to connect to the server
                    try
                    {
                        Conn.Open();                                        //Open connection to DB
                        int intRecs = comm.ExecuteNonQuery();
                        strResult = $"SUCCESS: Inserted {intRecs} records.";       //Report that we made the connection and added a record
                        Conn.Close();
                    }
                    catch (Exception err)                                   //If we got here, there was a problem connecting to DB
                    {
                        strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
                    }
                    finally
                    {

                    }



                    //Return resulting feedback string
                    return strResult;
                }
            }









        }
    }
}
