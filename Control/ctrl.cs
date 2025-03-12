 class Ctrl
 {
     public bool ctrlExist = false;
     public string ctrlMessage = "";

     
     public string accessingCredentials(string lgname, string passd)
     {   // method to access credentials in the DB asking the data level

         LoginCommands logg = new LoginCommands();
         string userRole = logg.verifyCredentials(lgname, passd);
         //setting control variables
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;
         return userRole;

     }

     public bool accessingLoginName(string lgname)
     {
         LoginCommands logg = new LoginCommands();
         bool operSuccess = logg.verifyLoginName(lgname);
         
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;

         return operSuccess;
     }

     public bool accessingStaffID(string StaffID)
     {
         LoginCommands loggid = new LoginCommands();
         bool operSuccess = loggid.verifyStaffID(StaffID);

         ctrlExist = loggid.exist;
         ctrlMessage = loggid.message;

         return operSuccess;
     }

     public bool registCredentials(string logg, string passwd, string retypePasswd, string userType)
     {
         bool operSuccess = false;

         // testing if empties
         if (logg != ""  && passwd != "" && retypePasswd != "")
         {
             if(passwd == retypePasswd)
             {
                 // object for data access
                 LoginCommands loggObj = new LoginCommands();
                 operSuccess = loggObj.insertCredentials(logg, passwd, userType);//adding the user type if it's customer or manager
                 ctrlMessage = loggObj.message;
             }
             else
                 ctrlMessage = "Passwords don't match";
         }
         else
             ctrlMessage = "Empty fields";
         
         return operSuccess;
     }

     public bool registStaff(string name, string age, string id, string cargo)
     {
         bool operSuccess = false;
         int val1, val2;

         // testing if empties
         if (name != "" && age != "" && id != "" && cargo != "")
         {
             if (int.TryParse(age, out val2) != true || int.TryParse(id,out val1) != true)
                 ctrlMessage = "Insert numbers on Age and ID fields";
             else
             {
                 // object for data access
                 LoginCommands loggObj = new LoginCommands();
                 operSuccess = loggObj.insertStaff(name, age, id, cargo); //inserting the staff in the DB
                 ctrlMessage = loggObj.message;
             }
         }
         else
             ctrlMessage = "Empty fields";

         return operSuccess;
     }

     public bool deleteStaff(string StaffID)
     {
         bool operSuccess = false;
         LoginCommands logg = new LoginCommands();

         // Assuming the staff ID is passed as a parameter
         operSuccess = logg.staffDelete(StaffID);
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;

         return operSuccess;

     }

     public bool updateStaff(string name, string age, string id, string cargo)
     {
         bool operSuccess = false;
         int val1, val2;

         // Testing if fields are empty
         if (name != "" && age != "" && cargo != "")
         {
             if (int.TryParse(age, out val2) != true)
                 ctrlMessage = "Insert numbers on Age";
             else
             {
                 // Object for data access
                 LoginCommands loggObj = new LoginCommands();
                 operSuccess = loggObj.staffUpdate(name, age, id, cargo);
                 ctrlMessage = loggObj.message;
             }
         }
         else
             ctrlMessage = "Empty fields";

         return operSuccess;
     }

     public bool insertproduct(string name, string id, string status, string price, string quantity)
     {
         bool operSuccess = false;

         // Testing if fields are empty
         if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(status) && !string.IsNullOrWhiteSpace(price) && !string.IsNullOrWhiteSpace(quantity))
         {
             // Object for data access
             LoginCommands loggObj = new LoginCommands();
             operSuccess = loggObj.insertProduct(name, id, status, price, quantity);
             ctrlMessage = loggObj.message;
         }
         else
         {
             ctrlMessage = "Empty fields";
         }

         return operSuccess;
     }

     public bool updateproductcart(string name)
     {
         bool operSuccess = false;
         LoginCommands logg = new LoginCommands();

         // Assuming the product ID is passed as a parameter
         operSuccess = logg.productUpdateCart(name);
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;

         return operSuccess;

     }

     public bool insertStaff(string name, string age, string id, string cargo)
     {
         bool operSuccess = false;

         // Testing if fields are empty
         if (!(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(cargo)))
         {
             // Object for data access
             LoginCommands loggObj = new LoginCommands();
             operSuccess = loggObj.insertStaff(name, age, id, cargo);
             ctrlMessage = loggObj.message;
         }
         else
         {
             ctrlMessage = "Empty fields";
         }

         return operSuccess;
     }

     /*public bool getCredentialList(ref Credentials[] credentials)
     {
         bool operSuccess;
         LoginCommands logg = new LoginCommands();

         operSuccess = logg.CredentialsList(ref credentials);
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;
         return operSuccess;
     }*/

     public bool getProductList(ref Products[] products)
     {
         bool operSuccess;
         LoginCommands logg = new LoginCommands();

         // Call the method to fetch the product list
         operSuccess = logg.ProductList(ref products);

         // Update control variables with the status and message from LoginCommands
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;

         return operSuccess;
     }


     public bool getStaffList(ref Staff[] staff)
     {
         bool operSuccess;
         LoginCommands logg = new LoginCommands();

         // Call the method to fetch the staff list
         operSuccess = logg.StaffList(ref staff);

         // Update control variables with the status and message from LoginCommands
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;

         return operSuccess;
     }

     public bool credentialsDelete(string username,string pw)
     {
         bool operSuccess = false;
         LoginCommands logg = new LoginCommands();
         operSuccess = logg.CredentialsDelete(username,pw);
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;

         return operSuccess;
     }

     public bool productdelete(string productId)
     {
         bool operSuccess = false;
         LoginCommands logg = new LoginCommands();

         // Assuming the product ID is passed as a parameter
         operSuccess = logg.productDelete(productId);
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;

         return operSuccess;

     }

    /* public bool updatecredentials(string log, string pwd, string repw) ((was not used after modif))
     {
         bool operSuccess = false;
         LoginCommands logg = new LoginCommands();
         operSuccess = logg.UpdateCredentials(log, pwd);
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;

         return operSuccess;
     }*/

     public bool updateproduct(string name, string status, string price, string quantity, string productID)
     {
         bool operSuccess = false;
         LoginCommands logg = new LoginCommands();

         // Call the method to update the product information
         operSuccess = logg.updateProduct(name, status, price, quantity, productID);
         ctrlExist = logg.exist;
         ctrlMessage = logg.message;

         return operSuccess;

     }

     internal bool credentialsDelete(string username)
     {
         throw new NotImplementedException();
     }

     internal bool updateVerification(string log, string pwd, string rpwd)
     {
         throw new NotImplementedException();
     }

     internal bool itemDelete(string itemName)
     {
         throw new NotImplementedException();
     }
 }
