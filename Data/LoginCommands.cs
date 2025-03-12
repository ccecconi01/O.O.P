using _0006.ProjetoLogin.Presentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static _0006.ProjetoLogin.Presentation.FormStaff;

namespace _0006.ProjetoLogin.Data
{
    class LoginCommands
    {
        // conexão com a bd
        Conexao conn = new Conexao();
        // SqlCmd supports the sql statement
        SqlCommand SqlCmd = new SqlCommand();
        // pointer to read table records
        SqlDataReader dr;

        // control attributes
        public bool exist = false;
        public string message = "";

        public string verifyCredentials(string ln, string pw)
        {
            string userRole = null;//a variable to store the role whe chosen
            // access to DB to verify if credentials exist
            SqlCmd.Parameters.AddWithValue("@log", ln);
            SqlCmd.Parameters.AddWithValue("@pwd", pw);
            SqlCmd.CommandText = "select * from Users where login_name = @log and password = @pwd";

            try
            {
                // open connection
                SqlCmd.Connection = conn.conectar();
                // execute sql statement
                dr = SqlCmd.ExecuteReader();
                if (dr.HasRows &&dr.Read())
                {
                    exist = true;
                    userRole = dr["user_role"].ToString(); // Get the user role
                    message = "Valid credentials!";
                }
                else
                {
                    exist = false;
                    message = "Invalid credentials!";
                }

                conn.desconectar();
                dr.Close();
            }
            catch(SqlException error) // exceptions existence
            {
                exist = false;
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }
            return userRole;
        }
        public bool verifyLoginName(string ln)
        {// access to DB to verify if login exist
            bool operSuccess = false;

            SqlCmd.Parameters.AddWithValue("@log", ln);
            SqlCmd.CommandText = "select * from Users where login_name = @log";

            try
            {
                // open connection
                SqlCmd.Connection = conn.conectar();
                // execute sql statement
                dr = SqlCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    exist = true;
                    message = "Login Name Invalid!";
                }
                else
                {
                    exist = false;
                    message = "Login Name Valid!";
                }

                conn.desconectar();
                dr.Close();
                operSuccess = true;
            }
            catch(SqlException error)
            {
                exist = false;
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
                operSuccess = false;
            }
            return operSuccess;
        }

        public bool verifyStaffID(string staffid)
        {// access to DB to verify if login exist
            bool operSuccess = false;

            SqlCmd.Parameters.AddWithValue("@id", staffid);
            SqlCmd.CommandText = "select * from Staff where ID_Staff = @id";

            try
            {
                // open connection
                SqlCmd.Connection = conn.conectar();
                // execute sql statement
                dr = SqlCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    exist = true;
                    message = "Staff ID Invalid!";
                }
                else
                {
                    exist = false;
                    message = "Staff ID Valid!";
                }

                conn.desconectar();
                dr.Close();
                operSuccess = true;
            }
            catch (SqlException error)
            {
                exist = false;
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
                operSuccess = false;
            }
            return operSuccess;
        }

        public bool insertCredentials(string ln, string pw, string userType)
        {
            bool operSuccess = false;

            SqlCmd.Parameters.AddWithValue("@log", ln); 
            SqlCmd.Parameters.AddWithValue("@pwd", pw);
            SqlCmd.Parameters.AddWithValue("@userrole", userType);
            SqlCmd.CommandText = "INSERT INTO Users (login_name, password, user_role) VALUES (@log, @pwd, @userrole)";

            try
            {
                // open connection
                SqlCmd.Connection = conn.conectar();
                SqlCmd.ExecuteNonQuery();
                conn.desconectar();
                operSuccess = true;
                message = "Record inserted!";
            }
            catch (SqlException error)
            {
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }
            return operSuccess;
        }

       
        public bool insertProduct(string name, string id, string status, string price, string quantity)
        {
            bool operSuccess = false;

            // Add parameters for the SQL command
            SqlCmd.Parameters.AddWithValue("@name", name);
            SqlCmd.Parameters.AddWithValue("@id", id);
            SqlCmd.Parameters.AddWithValue("@status", status);
            SqlCmd.Parameters.AddWithValue("@price", price);
            SqlCmd.Parameters.AddWithValue("@quantity", quantity);

            // SQL command to insert a product
            SqlCmd.CommandText = "INSERT INTO product (product_name, product_id, product_status, product_price, product_quantity) VALUES (@name, @id, @status, @price, @quantity)";

            try
            {
                // Open connection
                SqlCmd.Connection = conn.conectar();
                SqlCmd.ExecuteNonQuery();
                conn.desconectar();
                operSuccess = true;
                message = "Product inserted!";
            }
            catch (SqlException error)
            {
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }

            return operSuccess;
        }

        public bool insertStaff(string nome, string age, string id, string cargo)
        {
            bool operSuccess = false;

            // Clear any existing parameters
            SqlCmd.Parameters.Clear();

            // Add parameters
            SqlCmd.Parameters.AddWithValue("@nome", nome);
            SqlCmd.Parameters.AddWithValue("@idade", age);
            SqlCmd.Parameters.AddWithValue("@id", id);
            SqlCmd.Parameters.AddWithValue("@cargo", cargo);

            // SQL insert statement with parameters
            SqlCmd.CommandText = "INSERT INTO  Staff(Nome_Staff, Idade_Staff, ID_Staff, Cargo_Staff) " +
                                "VALUES (@nome, @idade, @id, @cargo)";
            try
            {
                // open connection
                SqlCmd.Connection = conn.conectar();
                SqlCmd.ExecuteNonQuery();
                conn.desconectar();
                operSuccess = true;
                message = "Staff record inserted successfully!";
            }
            catch (SqlException error)
            {
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }
            return operSuccess;
        }

        /* public bool CredentialsList(ref Credentials[] credentials)
         {
             // statement sql to receive / list the credentials records
             SqlCmd.CommandText = "select * from users order by login_name";
             bool operSuccess = false;

             try
             {
                 // open connection
                 SqlCmd.Connection = conn.conectar();
                 // execute sql statement
                 dr = SqlCmd.ExecuteReader();
                 if (dr.HasRows)
                 {
                     exist = true;

                     string user = "";
                     string pwd = "";

                     int i = 0; // record counter

                     while (dr.Read()) // read while TRUE (existing records to read)
                     {
                         user = dr.GetString(0);
                         pwd = dr.GetString(1);

                         // array redimention
                         Array.Resize(ref credentials, credentials.Length + 1);
                         // create memory
                         credentials[credentials.Length - 1] = new Credentials();
                         // fill the array
                         credentials[credentials.Length - 1].username = user;
                         credentials[credentials.Length - 1].passwd = pwd;
                         i++;
                     }
                     message = "Retriving: " + i + " records!";
                 }
                 else
                 {
                     message = "No records!";
                     exist = false;
                 }

                 conn.desconectar();
                 operSuccess = true;
             }
             catch (SqlException error)
             {
                 message = "Database Error: " + error.ErrorCode + " " + error.Message;
             }
             return operSuccess;
         }*/

        public bool ProductList(ref Products[] products)
        {
            // SQL statement to retrieve products
            SqlCmd.CommandText = "SELECT product_name, product_id, product_status, product_price, product_quantity FROM product ORDER BY product_id;";
            bool operSuccess = false;

            try
            {
                // Open the database connection
                SqlCmd.Connection = conn.conectar();
                // Execute the SQL statement
                dr = SqlCmd.ExecuteReader();

                if (dr.HasRows)
                {
                    exist = true;

                    
                    string name = "";
                    string productID = "";
                    string status = "";
                    string price = "";
                    string quantity = "";

                    int i = 0; // Record counter

                    while (dr.Read()) // Read while there are records
                    {

                        name = dr.GetString(0);
                        productID = dr.GetString(1);
                        status = dr.GetString(2);
                        price = dr.GetString(3);
                        quantity = dr.GetString(4);

                        // Resize the array to add a new product
                        Array.Resize(ref products, products.Length + 1);
                        // Create memory for the new product
                        products[products.Length - 1] = new Products();
                        // Fill the product details
                        
                        products[products.Length - 1].Name = name;
                        products[products.Length - 1].ProductID = productID;
                        products[products.Length - 1].Status = status;
                        products[products.Length - 1].Price = price;
                        products[products.Length - 1].Quantity = quantity;

                        i++;
                    }

                    message = "Retrieved: " + i + " records!";
                }
                else
                {
                    message = "No records!";
                    exist = false;
                }

                // Close the database connection
                conn.desconectar();
                operSuccess = true;
            }
            catch (SqlException error)
            {
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }

            return operSuccess;
        }

        public bool StaffList(ref Staff[] staff)
        {
            // SQL statement to retrieve staff records
            SqlCmd.CommandText = "SELECT Nome_Staff, Idade_Staff, ID_Staff, Cargo_Staff FROM Staff ORDER BY ID_Staff;";
            bool operSuccess = false;

            try
            {
                // Open the database connection
                SqlCmd.Connection = conn.conectar();
                // Execute the SQL statement
                dr = SqlCmd.ExecuteReader();

                if (dr.HasRows)
                {
                    exist = true;

                    string nome = "";
                    string idade = "";
                    string id = "";
                    string cargo = "";

                    int i = 0; // Record counter

                    while (dr.Read()) // Read while there are records
                    {
                        nome = dr.GetString(0);
                        idade = dr.GetString(1);
                        id = dr.GetString(2);
                        cargo = dr.GetString(3);

                        // Resize the array to add a new staff record
                        Array.Resize(ref staff, staff.Length + 1);
                        // Create memory for the new staff record
                        staff[staff.Length - 1] = new Staff();
                        // Fill the staff record details
                        staff[staff.Length - 1].Nome_Staff = nome;
                        staff[staff.Length - 1].Idade_Staff = idade;
                        staff[staff.Length - 1].ID_Staff = id;
                        staff[staff.Length - 1].Cargo_Staff = cargo;

                        i++;
                    }

                    message = "Retrieved: " + i + " records!";
                }
                else
                {
                    message = "No records!";
                    exist = false;
                }

                // Close the database connection
                conn.desconectar();
                operSuccess = true;
            }
            catch (SqlException error)
            {
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }

            return operSuccess;
        }


        public bool CredentialsDelete(string username, string passwd)
        {
            bool operSuccess = false;

            SqlCmd.Parameters.AddWithValue("@lgn", username);
            SqlCmd.Parameters.AddWithValue("@pw", passwd);

            SqlCmd.CommandText = "DELETE FROM Users WHERE login_name = @lgn and password =@passwd ";

            try
            {
                // open connection
                SqlCmd.Connection = conn.conectar();
                // execute sql statement
                SqlCmd.ExecuteNonQuery();
                conn.desconectar();
                operSuccess = true;
                exist = true;
                message = "Record deleted!";
            }
            catch (SqlException error)
            {
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }
            return operSuccess;
        }

        public bool productDelete(string productId)
        {
            bool operSuccess = false;

            SqlCmd.Parameters.Clear(); // Clear any previously added parameters
            SqlCmd.Parameters.AddWithValue("@productId", productId);
            SqlCmd.CommandText = "DELETE FROM product WHERE product_id = @productId";
            try
            {
                SqlCmd.Connection = conn.conectar(); // Open connection
                int rowsAffected = SqlCmd.ExecuteNonQuery();
                operSuccess = rowsAffected > 0; // True if a row was deleted

                if (operSuccess)
                {
                    message = "Product deleted!";
                }
                else
                {
                    message = "Product not found.";
                }

                conn.desconectar();
            }
            catch (SqlException error)
            {
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }
            return operSuccess;

        }

        public bool staffDelete(string staffID)
        {
            bool operSuccess = false;

            SqlCmd.Parameters.Clear(); // Clear any previously added parameters
            SqlCmd.CommandText = "DELETE FROM Staff WHERE ID_Staff = @staffID";
            SqlCmd.Parameters.AddWithValue("@staffID", staffID);
            
            try
            {
                SqlCmd.Connection = conn.conectar(); // Open connection
                int rowsAffected = SqlCmd.ExecuteNonQuery();
                operSuccess = rowsAffected > 0; // True if a row was deleted

                if (operSuccess)
                {
                    message = "Staff record deleted!";
                }
                else
                {
                    message = "Staff record not found.";
                }

                conn.desconectar();
            }
            catch (SqlException error)
            {
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }
            return operSuccess;

        }   

        public bool staffUpdate(string name, string age, string staffID, string position)
        {
            bool operSuccess = false;

    

            SqlCmd.CommandText = "UPDATE Staff SET Nome_Staff = @nome, Idade_Staff = @idade, Cargo_Staff = @cargo WHERE ID_Staff = @staffID";

            SqlCmd.Parameters.Clear();
            SqlCmd.Parameters.AddWithValue("@nome", name);
            SqlCmd.Parameters.AddWithValue("@idade", age);
            SqlCmd.Parameters.AddWithValue("@staffID", staffID);
            SqlCmd.Parameters.AddWithValue("@cargo", position);


            try
            {


                SqlCmd.Connection = conn.conectar();

                int rowsAffected = SqlCmd.ExecuteNonQuery();
                conn.desconectar();

                if (rowsAffected > 0)
                {
                    operSuccess = true;
                    message = "Staff information updated successfully!";
                }
                else
                {
                    message = "No staff record found with the given ID.";
                }
            }
            catch (SqlException error)
            {
                message = $"Database Error: {error.Number} - {error.Message}";
            }
            catch (Exception ex)
            {
                message = $"Unexpected error: {ex.Message}";
            }
            finally
            {
                if (SqlCmd.Connection != null && SqlCmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    conn.desconectar();
                }
            }

            return operSuccess;
        }

        public bool productUpdateCart(string name)
        {
            bool operSuccess = false;



            SqlCmd.CommandText = "UPDATE product SET product_quantity = CAST(product_quantity AS INT) - 1 WHERE product_name = @nome";
            SqlCmd.Parameters.Clear();
            SqlCmd.Parameters.AddWithValue("@nome", name);

            try
            {


                SqlCmd.Connection = conn.conectar();

                int rowsAffected = SqlCmd.ExecuteNonQuery();
                conn.desconectar();

                if (rowsAffected > 0)
                {
                    operSuccess = true;
                    message = "Product added to cart successfully!";
                }
                else
                {
                    message = "No products found.";
                }
            }
            catch (SqlException error)
            {
                message = $"Database Error: {error.Number} - {error.Message}";
            }
            catch (Exception ex)
            {
                message = $"Unexpected error: {ex.Message}";
            }
            finally
            {
                if (SqlCmd.Connection != null && SqlCmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    conn.desconectar();
                }
            }

            return operSuccess;


        }

        /*public bool UpdateCredentials(string logg, string passwd) 
        {
            bool operSuccess = false;

            SqlCmd.Parameters.AddWithValue("@lgn", logg);
            SqlCmd.Parameters.AddWithValue("@pwd", passwd);

            SqlCmd.CommandText = "update users set password = @pwd where login_name = @lgn";

            try
            {
                // open connection
                SqlCmd.Connection = conn.conectar();
                // execute sql statement
                SqlCmd.ExecuteNonQuery();
                conn.desconectar();
                operSuccess = true;
                exist = true;
                message = "Record updated!";
            }
            catch (SqlException error)
            {
                message = "Database Error: " + error.ErrorCode + " " + error.Message;
            }

            return operSuccess;
        }*/

        public bool updateProduct(string name, string status, string price, string quantity, string productID)
        {
            bool operSuccess = false;

           
                if (string.IsNullOrEmpty(productID))
                {
                    message = "Product ID is required.";
                    return false;
                }

                if (!decimal.TryParse(price, out decimal parsedPrice))
                {
                    message = "Invalid price format. Please enter a valid numeric value.";
                    return false;
                }

                if (!int.TryParse(quantity, out int parsedQuantity))
                {
                    message = "Invalid quantity format. Please enter a valid numeric value.";
                    return false;
                }


                SqlCmd.CommandText = "UPDATE Product SET product_name = @name, product_status = @status, product_price = @price, product_quantity = @quantity WHERE product_id = @productID";
               

                SqlCmd.Parameters.Clear();
                SqlCmd.Parameters.AddWithValue("@name", name);
                SqlCmd.Parameters.AddWithValue("@status", status);
                SqlCmd.Parameters.AddWithValue("@price", parsedPrice);
                SqlCmd.Parameters.AddWithValue("@quantity", parsedQuantity);
                SqlCmd.Parameters.AddWithValue("@productID", productID);

            try
            {


                SqlCmd.Connection = conn.conectar();

                int rowsAffectedn = SqlCmd.ExecuteNonQuery();
                conn.desconectar();

                if (rowsAffectedn > 0)
                {
                    operSuccess = true;
                    message = "Staff information updated successfully!";
                }
                else
                {
                    message = "No staff record found with the given ID.";
                }
            }
            catch (SqlException error)
            {
                message = $"Database Error: {error.Number} - {error.Message}";
            }
            catch (Exception ex)
            {
                message = $"Unexpected error: {ex.Message}";
            }
            finally
            {
                if (SqlCmd.Connection != null && SqlCmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    conn.desconectar();
                }
            }

            return operSuccess;
        }

    }





    
}
