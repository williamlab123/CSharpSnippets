 string connectionString = "Server=localhost;Database=yourDataBaseName;Uid=root;Pwd=YourdataBasePassword;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
             connection.Open();
             //Insert the code here to manipulate sql
             
             connection.Close();
            }
            
            //Use this code to create an instace of MySQL in your c# program
            
            //##Remember Downloading the MySql.Data library for c#, wich command is: dotnet add package MySql.Data
