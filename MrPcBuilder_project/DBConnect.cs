using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace MrPcBuilder_project
{
    internal class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string port;
        private string username;
        private string password;
        private string database;

        public DBConnect()
        {
            Initialize();
        }

        // CONNECTION TO DATABASE
        private void Initialize()
        {
            server = "127.0.0.1";
            port = "3306";
            username = "root";
            password = "";
            database = "mrpcbuilder_database";

            string connectionString = "Server = " + server + "; Port = " + port + "; Database = " +
                database + "; Uid = " + username + "; Pwd = " + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // SIMPLE QUERIES
        public bool SimpleExecuteNonQuery(string query)
        {
            bool flag = false;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    flag = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public object SimpleExecuteScalar(string query)
        {
            object result = null;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    result = cmd.ExecuteScalar();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        // LOGIN VALIDATION
        public bool ValidateLogin(string username, string password, ref string nameOfUser, ref string role, ref int fail_message)
        {
            bool flag = false;
            fail_message = 0;
            try
            { 
                // check user status (login fails)
                string queryStatus = "select fails from employee_login where username = '" + username + "';";
                object result = SimpleExecuteScalar(queryStatus);

                if (result == null)
                {
                    fail_message = 1;
                    return false;
                }
                else
                {
                    int fails = int.Parse(result.ToString());

                    if (fails >= 5)
                    {
                        string queryUpdateStatus = "update employee_login set user_status = 'Inactive' where username = '" + username + "';";
                        SimpleExecuteNonQuery(queryUpdateStatus);

                        fail_message = 3;
                        return false;
                    }

                    // check credentials if user is not blocked
                    string queryLogin = "select id_employee_login from employee_login where username = '" + username + "' and user_password = '" + password + "' and user_status = 'Active';";
                    object result2 = SimpleExecuteScalar(queryLogin);

                    if (result2 != null)
                    {
                        string queryID = "select id_employee from employee where id_employee_login = '" + result2 + "';";
                        int idEmployee = int.Parse(SimpleExecuteScalar(queryID).ToString());

                        string queryName = "select name_employee from employee_view where id_employee = '" + idEmployee + "';";
                        nameOfUser = SimpleExecuteScalar(queryName).ToString();

                        string queryRole = "select role_name from employee_view where id_employee = '" + idEmployee + "';";
                        role = SimpleExecuteScalar(queryRole).ToString();

                        fails = 0;
                        flag = true;
                    }
                    else
                    {
                        fails++;
                        fail_message = 2;
                    }
                    string queryUpdateFails = "update employee_login set fails = '" + fails + "' where username = '" + username + "';";
                    SimpleExecuteNonQuery(queryUpdateFails);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return flag;
        }

        // HOME SCREEN
        public void BuildsStatusCounter(out string builds_pending, out string builds_in_progress, out string builds_completed)
        {
            string query = "select count(*) from build_order where build_status = 'Pending';";
            builds_pending = SimpleExecuteScalar(query).ToString();

            string query2 = "select count(*) from build_order where build_status = 'In Progress';";
            builds_in_progress = SimpleExecuteScalar(query2).ToString();

            string query3 = "select count(*) from build_order where build_status = 'Completed';";
            builds_completed = SimpleExecuteScalar(query3).ToString();            
        }

        // GLOBAL METHODS * Methods than can be used in multiple places
        // FILL COMBOBOXES
        public void FillComboBoxManufacturerName(ref ComboBox name_manufacturer)
        {
            HashSet<string> tempHash = new HashSet<string>();
            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct name_manufacturer from manufacturer order by name_manufacturer;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string tempString = dr[0].ToString();
                        if (!string.IsNullOrWhiteSpace(tempString) && !tempHash.Contains(tempString)){
                            tempHash.Add(tempString);
                            name_manufacturer.Items.Add(tempString);
                        }
                    }
                    dr.Close();                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillComboBoxComponentType(ref ComboBox component_type)
        {
            HashSet<string> tempHash = new HashSet<string>();
            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct component_type from component_type;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string tempString = dr[0].ToString();
                        if (!string.IsNullOrWhiteSpace(tempString) && !tempHash.Contains(tempString))
                        {
                            tempHash.Add(tempString);
                            component_type.Items.Add(tempString);
                        }                        
                    }
                    dr.Close();                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillComboBoxCustomerName(ref ComboBox customer_name)
        {
            HashSet<string> tempHash = new HashSet<string>();
            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct name_customer from customer;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();                    
                    while (dr.Read())
                    {
                        string tempString = dr[0].ToString();
                        if (!string.IsNullOrWhiteSpace(tempString) && !tempHash.Contains(tempString))
                        {
                            tempHash.Add(tempString);
                            customer_name.Items.Add(tempString);
                        }
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillComboBoxEmployeeName(ref ComboBox name_employee)
        {
            HashSet<string> tempHash = new HashSet<string>();
            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct name_employee from employee;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string tempString = dr[0].ToString();
                        if (!string.IsNullOrWhiteSpace(tempString) && !tempHash.Contains(tempString))
                        {
                            tempHash.Add(tempString);
                            name_employee.Items.Add(tempString);
                        }
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillComboBoxEmployeeRole(ref ComboBox role_name)
        {
            HashSet<string> tempHash = new HashSet<string>();
            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct role_name from employee_role;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string tempString = dr[0].ToString();
                        if (!string.IsNullOrWhiteSpace(tempString) && !tempHash.Contains(tempString))
                        {
                            tempHash.Add(tempString);
                            role_name.Items.Add(tempString);
                        }
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillComboBoxPaymentMethod(ref ComboBox payment_method)
        {
            HashSet<string> tempHash = new HashSet<string>();
            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct payment_method from payment_method;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string tempString = dr[0].ToString();
                        if (!string.IsNullOrWhiteSpace(tempString) && !tempHash.Contains(tempString))
                        {
                            tempHash.Add(tempString);
                            payment_method.Items.Add(tempString);
                        }
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillComboBoxOrderDate(ref ComboBox order_date)
        {
            HashSet<string> tempHash = new HashSet<string>();
            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct order_date from build_order;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string tempString = dr[0].ToString();
                        if (!string.IsNullOrWhiteSpace(tempString) && !tempHash.Contains(tempString))
                        {
                            tempHash.Add(tempString);
                            order_date.Items.Add(tempString);
                        }
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillComboBoxDeliveryDate(ref ComboBox delivery_date)
        {
            HashSet<string> tempHash = new HashSet<string>();
            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct delivery_date from build_order;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string tempString = dr[0].ToString();
                        if (!string.IsNullOrWhiteSpace(tempString) && !tempHash.Contains(tempString))
                        {
                            tempHash.Add(tempString);
                            delivery_date.Items.Add(tempString);
                        }
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillComboBoxBuildStatus(ref ComboBox build_status)
        {
            HashSet<string> tempHash = new HashSet<string>();
            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct build_status from build_order;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string tempString = dr[0].ToString();
                        if (!string.IsNullOrWhiteSpace(tempString) && !tempHash.Contains(tempString))
                        {
                            tempHash.Add(tempString);
                            build_status.Items.Add(tempString);
                        }
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // MORE SPECIFIC COMBOBOX FILL
        public void FillComboBoxComponentName(ref ComboBox component_name, string component_type)
        {
            try
            {
                if (OpenConnection())
                {
                    string query = "select name_component from component_view where component_type = '" + component_type + "';";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        component_name.Items.Add(dr[0].ToString());
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillComboBoxComponentDetails(string component_name, ref TextBox name_manufacturer, ref TextBox component_model, ref TextBox component_price)
        {
            try
            {
                if (OpenConnection())
                {
                    string query = "select name_manufacturer, model, price from component_view where name_component = '" + component_name + "';";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        name_manufacturer.Text = dr[0].ToString();
                        component_model.Text = dr[1].ToString();
                        component_price.Text = dr[2].ToString();
                    }
                    dr.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // NEW BUILD * Save Build
        public bool InsertNewBuildOrder(string employeeName, string customerName, int totalQuantity, decimal totalPrice, string orderDate, string deliveryDate, string paymentMethod, ListView listView)
        {
            bool flag = false;
            int orderID = 0;

            try
            {
                string queryNewBuild = "insert into build_order (id_employee, id_customer, total_quantity, total_price, order_date, delivery_date) " +
                                       "values ((select id_employee from employee where name_employee = '" + employeeName + "'), " +
                                       "(select id_customer from customer where name_customer = '" + customerName + "'), " +
                                       "'" + totalQuantity + "','" + totalPrice + "','" + orderDate + "','" + deliveryDate + "');";
                flag = SimpleExecuteNonQuery(queryNewBuild);

                if (flag)
                {
                    string queryGetID = "select last_insert_id() from build_order";
                    orderID = Convert.ToInt32(SimpleExecuteScalar(queryGetID));

                    string queryInsertPaymentMethod = "insert into receipt (id_build_order, id_payment_method) " +
                                                      "VALUES ('" + orderID + "', " +
                                                      "(select id_payment_method from payment_method where payment_method = '" + paymentMethod + "'));";

                    flag = SimpleExecuteNonQuery(queryInsertPaymentMethod);

                    if (flag)
                    {
                        foreach (ListViewItem item in listView.Items)
                        {
                            string componentName = item.SubItems[1].Text;
                            int quantity = Convert.ToInt32(item.SubItems[5].Text);

                            string queryInsertComponentsList = "insert into build_components (id_pc_component, id_build_order, quantity) " +
                                                               "values ((select id_pc_component from pc_component where name_component = '" + componentName + "'), " +
                                                               "'" + orderID + "','" + quantity + "');";

                            flag = SimpleExecuteNonQuery(queryInsertComponentsList);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        // LIST BUILDS
        public void FillDataGridViewListBuilds(ref DataGridView dgv, string employee, string customer, string order_date, string delivery_date, string status)
        {
            string query = "select id_build_order, name_employee, name_customer, order_date, delivery_date, total_price, total_quantity, build_status from build_view where 1=1";

            if (!string.IsNullOrEmpty(employee))
            {
                query += " and name_employee = '" + employee + "'";
            }
            if (!string.IsNullOrEmpty(customer))
            {
                query += " and name_customer = '" + customer + "'";
            }
            if (!string.IsNullOrEmpty(order_date))
            {
                query += " and order_date = '" + order_date + "'";
            }
            if (!string.IsNullOrEmpty(delivery_date))
            {
                query += " and delivery_date = '" + delivery_date + "'";
            }
            if (!string.IsNullOrEmpty(status))
            {
                query += " and build_status = '" + status + "'";
            }

            query += " order by name_employee;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int idxLine = 0;

                    while (dr.Read())
                    {
                        dgv.Rows.Add(dr);
                        dgv.Rows[idxLine].Cells[0].Value = dr[0].ToString();
                        dgv.Rows[idxLine].Cells[1].Value = dr[1].ToString();
                        dgv.Rows[idxLine].Cells[2].Value = dr[2].ToString();

                        string formattedOrderDate = ((DateTime)dr[3]).ToString("yyyy-MM-dd");
                        string formattedDeliveryDate = ((DateTime)dr[4]).ToString("yyyy-MM-dd");

                        dgv.Rows[idxLine].Cells[3].Value = formattedOrderDate;
                        dgv.Rows[idxLine].Cells[4].Value = formattedDeliveryDate;
                        dgv.Rows[idxLine].Cells[5].Value = dr[5].ToString();
                        dgv.Rows[idxLine].Cells[6].Value = dr[6].ToString();
                        dgv.Rows[idxLine].Cells[7].Value = dr[7].ToString();
                        idxLine++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // EDIT BUILD
        public bool SearchBuild(string id_search, ref string employee, ref string customer, ref string order_date, ref string delivery_date, ref string total_quantity, ref string total_price, ref string payment_method, ref string status)
        {
            bool flag = false;
            string query = "select name_employee, name_customer, order_date, delivery_date, total_quantity, total_price, payment_method, build_status from build_view where id_build_order = '" + id_search + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        employee = dataReader[0].ToString();
                        customer = dataReader[1].ToString();
                        order_date = dataReader[2].ToString();
                        delivery_date = dataReader[3].ToString();
                        total_quantity = dataReader[4].ToString();
                        total_price = dataReader[5].ToString();
                        payment_method = dataReader[6].ToString();
                        status = dataReader[7].ToString();
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public bool FillEditBuildListView(ref ListView listView, int id_build)
        {
            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    string query = "select component_type, name_component, name_manufacturer, model, price, quantity from build_components_view where id_build_order = '" + id_build + "';";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    listView.Items.Clear();

                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr[0].ToString());
                        item.SubItems.Add(dr[1].ToString());
                        item.SubItems.Add(dr[2].ToString());
                        item.SubItems.Add(dr[3].ToString());
                        item.SubItems.Add(dr[4].ToString());
                        item.SubItems.Add(dr[5].ToString());

                        listView.Items.Add(item);
                    }
                    dr.Close();
                    flag = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public bool UpdateBuildOrder(int orderID, string employee, string customer, int totalQuantity, decimal totalPrice, string orderDate, string deliveryDate, string status, string paymentMethod, ListView listView)
        {
            bool flag = false;
            string queryUpdateBuild = "update build_order set " +
                                    "id_employee = (select id_employee from employee where name_employee = '" + employee + "'), " +
                                    "id_customer = (select id_customer from customer where name_customer = '" + customer + "'), " +
                                    "total_quantity = '" + totalQuantity + "', total_price = '" + totalPrice + "', order_date = '" + orderDate + "', delivery_date = '" + deliveryDate + "', build_status = '" + status + "' " +
                                    "where id_build_order = '" + orderID + "';";

            flag = SimpleExecuteNonQuery(queryUpdateBuild);

            if (flag)
            {
                string queryUpdateReceipt = "update receipt set " +
                               "id_payment_method = (select id_payment_method from payment_method where payment_method = '" + paymentMethod + "') " +
                               "where id_build_order = '" + orderID + "';";

                flag = SimpleExecuteNonQuery(queryUpdateReceipt);
            }
            if (flag)
            {
                try
                {
                    if (OpenConnection())
                    {
                        string queryDeleteBuildComponents = "DELETE FROM build_components WHERE id_build_order = '" + orderID + "';";

                        MySqlCommand cmd = new MySqlCommand(queryDeleteBuildComponents, connection);
                        cmd.ExecuteNonQuery();

                        foreach (ListViewItem item in listView.Items)
                        {
                            string componentName = item.SubItems[1].Text;
                            int quantity = Convert.ToInt32(item.SubItems[5].Text);

                            string queryInsertBuildComponents = "insert into build_components (id_pc_component, id_build_order, quantity) " +
                                            "values ((select id_pc_component from pc_component where name_component = '" + componentName + "'), " +
                                            "'" + orderID + "','" + quantity + "');";

                            cmd = new MySqlCommand(queryInsertBuildComponents, connection);
                            cmd.ExecuteNonQuery();
                        }
                        flag = true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    flag = false;
                }
                finally
                {
                    CloseConnection();
                }
            }
            return flag;
        }

        // COMPONENTS * Search
        public bool SearchComponent(string id_search, ref string type, ref string name, ref string model, ref string manufacturer, ref string price, ref string description)
        {
            bool flag = false;
            string query = "select component_type, name_component, model, name_manufacturer, price, description_component from component_view where id_pc_component = '" + id_search + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        type = dataReader[0].ToString();
                        name = dataReader[1].ToString();
                        model = dataReader[2].ToString();
                        manufacturer = dataReader[3].ToString();
                        price = dataReader[4].ToString();
                        description = dataReader[5].ToString();
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public bool SearchManufacturer(string name, ref string contact, ref string email)
        {
            bool flag = true;
            string query = "select phone_contact, email from manufacturer where name_manufacturer = '" + name + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        contact = dataReader[0].ToString();
                        email = dataReader[1].ToString();
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        // COMPONENTS * Insert
        public bool InsertManufacturer(string name, string contact, string email)
        {
            bool flag = false;
            string query = "insert into manufacturer (name_manufacturer, phone_contact, email) values ('" + name + "','" + contact + "','" + email + "');";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }
        public bool InsertNewTypeComponent(string new_type)
        {
            bool flag = false;
            string query = "insert into component_type (component_type) values ('" + new_type + "');";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }
        public bool InsertNewComponent(string type, string manufacturer, string name, string model, string price, string description)
        {
            bool flag = false;
            string query = "insert into pc_component (id_component_type,id_manufacturer,name_component,model,price,description_component)" +
                           "values ((select id_component_type from component_type where component_type = '" + type + "')," +
                                  "(select id_manufacturer from manufacturer where name_manufacturer = '" + manufacturer + "')," +
                                  "'" + name + "','" + model + "','" + price + "','" + description + "');";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }

        // COMPONENTS * Update
        public bool UpdateComponent(string id, string type, string manufacturer, string name, string model, string price, string description)
        {
            bool flag = false;
            string query = "update pc_component set " +
                           "id_component_type = (select id_component_type from component_type where component_type = '" + type + "'), " +
                           "id_manufacturer = (select id_manufacturer from manufacturer where name_manufacturer = '" + manufacturer + "'), " +
                           "name_component = '" + name + "', model = '" + model + "', price = '" + price + "', description_component = '" + description + "' " +
                           "where id_pc_component = '" + id + "';";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }

        public bool UpdateComponentType(string old_type_name, string new_type_name)
        {
            bool flag = false;
            string query = "update component_type set " +
                           "component_type = '" + new_type_name + "' where component_type = '" + old_type_name + "';";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }


        public bool UpdateManufacturer(string old_name, string new_name, string contact, string email)
        {
            bool flag = false;
            string query = "update manufacturer set " +
                           "name_manufacturer = '" + new_name + "', phone_contact = '" + contact + "', email = '" + email + "' where name_manufacturer = '" + old_name + "';";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }

        // COMPONENTS * Fill DataGridView
        public void FillDataGridViewListComponents(ref DataGridView dgv, string type, string manufacturer)
        {
            string query = "select id_pc_component, component_type, name_component, model, name_manufacturer, price, description_component from component_view where 1=1";

            if (!string.IsNullOrEmpty(type))
            {
                query += " and component_type = '" + type + "'";
            }
            if (!string.IsNullOrEmpty(manufacturer))
            {
                query += " and name_manufacturer = '" + manufacturer + "'";
            }

            query += " order by component_type;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int idxLine = 0;

                    while (dr.Read())
                    {
                        dgv.Rows.Add(dr);
                        dgv.Rows[idxLine].Cells[0].Value = dr[0].ToString();
                        dgv.Rows[idxLine].Cells[1].Value = dr[1].ToString();
                        dgv.Rows[idxLine].Cells[2].Value = dr[2].ToString();
                        dgv.Rows[idxLine].Cells[3].Value = dr[3].ToString();
                        dgv.Rows[idxLine].Cells[4].Value = dr[4].ToString();
                        dgv.Rows[idxLine].Cells[5].Value = dr[5].ToString();
                        dgv.Rows[idxLine].Cells[6].Value = dr[6].ToString();
                        idxLine++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // CLIENTS * Insert
        public bool InsertNewClient(string name, string last_name, string street, string zip, string country, string contact, string email, string tax_id, string username, string password)
        {
            bool flag = false;
            string queryLogin = "insert into customer_login (username, user_password) values ('" + username + "','" + password + "');";

            flag = SimpleExecuteNonQuery(queryLogin);

            if (flag)
            {
                string queryClientInfo = "insert into customer (id_customer_login, name_customer, last_name_customer, street_customer, zipcode_customer, country_customer, phone_number, email, tax_id) " +
                                "values ((select id_customer_login from customer_login where username = '" + username + "')," +
                                "'" + name + "','" + last_name + "','" + street + "','" + zip + "','" + country + "','" + contact + "','" + email + "','" + tax_id + "');";

                flag = SimpleExecuteNonQuery(queryClientInfo);
            }
            return flag;
        }

        // CLIENTS * Fill DataGridView / ComboBox
        public void FillComboBoxFilterClient(ref ComboBox name, ref ComboBox lastname, ref ComboBox email, ref ComboBox zip, ref ComboBox country)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            HashSet<string> uniqueLastnames = new HashSet<string>();
            HashSet<string> uniqueEmails = new HashSet<string>();
            HashSet<string> uniqueZips = new HashSet<string>();
            HashSet<string> uniqueCountries = new HashSet<string>();

            try
            {
                if (OpenConnection())
                {
                    string query = "select distinct name_customer, last_name_customer, email, zipcode_customer, country_customer from customer;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string nameCustomer = dr["name_customer"].ToString();
                        string lastNameCustomer = dr["last_name_customer"].ToString();
                        string emailCustomer = dr["email"].ToString();
                        string zipCustomer = dr["zipcode_customer"].ToString();
                        string countryCustomer = dr["country_customer"].ToString();

                        if (!string.IsNullOrWhiteSpace(nameCustomer))
                            uniqueNames.Add(nameCustomer);
                        if (!string.IsNullOrWhiteSpace(lastNameCustomer))
                            uniqueLastnames.Add(lastNameCustomer);
                        if (!string.IsNullOrWhiteSpace(emailCustomer))
                            uniqueEmails.Add(emailCustomer);
                        if (!string.IsNullOrWhiteSpace(zipCustomer))
                            uniqueZips.Add(zipCustomer);
                        if (!string.IsNullOrWhiteSpace(countryCustomer))
                            uniqueCountries.Add(countryCustomer);
                    }
                    dr.Close();

                    name.Items.AddRange(uniqueNames.ToArray());
                    lastname.Items.AddRange(uniqueLastnames.ToArray());
                    email.Items.AddRange(uniqueEmails.ToArray());
                    zip.Items.AddRange(uniqueZips.ToArray());
                    country.Items.AddRange(uniqueCountries.ToArray());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void FillDataGridViewListClients(ref DataGridView dgv, string name, string lastname, string email, string zip, string country)
        {
            string query = "select id_customer, name_customer, last_name_customer, email, phone_number, tax_id, street_customer, zipcode_customer, country_customer from customer where 1=1";

            if (!string.IsNullOrEmpty(name))
            {
                query += " and name_customer = '" + name + "'";
            }
            if (!string.IsNullOrEmpty(lastname))
            {
                query += " and last_name_customer = '" + lastname + "'";
            }
            if (!string.IsNullOrEmpty(email))
            {
                query += " and email = '" + email + "'";
            }
            if (!string.IsNullOrEmpty(zip))
            {
                query += " and zipcode_customer = '" + zip + "'";
            }
            if (!string.IsNullOrEmpty(country))
            {
                query += " and country_customer = '" + country + "'";
            }

            query += " order by id_customer;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int idxLine = 0;

                    while (dr.Read())
                    {
                        dgv.Rows.Add(dr);
                        dgv.Rows[idxLine].Cells[0].Value = dr[0].ToString();
                        dgv.Rows[idxLine].Cells[1].Value = dr[1].ToString();
                        dgv.Rows[idxLine].Cells[2].Value = dr[2].ToString();
                        dgv.Rows[idxLine].Cells[3].Value = dr[3].ToString();
                        dgv.Rows[idxLine].Cells[4].Value = dr[4].ToString();
                        dgv.Rows[idxLine].Cells[5].Value = dr[5].ToString();
                        dgv.Rows[idxLine].Cells[6].Value = dr[6].ToString() + " - " + dr[7].ToString() + " - " + dr[8].ToString();
                        idxLine++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // CLIENTS * Select
        public bool SearchClient(string id_search, ref string name, ref string lastname, ref string email, ref string contact, ref string tax_id, ref string street, ref string zip, ref string country, ref string user_status)
        {
            bool flag = false;
            string query = "select name_customer, last_name_customer, email, phone_number, tax_id, street_customer, zipcode_customer, country_customer, user_status from customer_view where id_customer = '" + id_search + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        name = dataReader[0].ToString();
                        lastname = dataReader[1].ToString();
                        email = dataReader[2].ToString();
                        contact = dataReader[3].ToString();
                        tax_id = dataReader[4].ToString();
                        street = dataReader[5].ToString();
                        zip = dataReader[6].ToString();
                        country = dataReader[7].ToString();
                        user_status = dataReader[8].ToString();
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        // CLIENTS * Update
        public bool UpdateClient(string id, string name, string lastname, string email, string contact, string tax_id, string street, string zip, string country)
        {
            bool flag = false;
            string query = "update customer set " +
                           "name_customer = '" + name + "', last_name_customer = '" + lastname + "', email = '" + email + "', phone_number = '" + contact + "', " +
                           "tax_id = '" + tax_id + "', street_customer = '" + street + "', zipcode_customer = '" + zip + "', country_customer = '" + country + "' " +
                           "where id_customer = '" + id + "';";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }
        public bool RegenerateClientLogin(string id_search, string username, string password)
        {
            bool flag = false;
            string query = "select id_customer_login from customer where id_customer = '" + id_search + "';";
            string id_login = SimpleExecuteScalar(query).ToString();

            string queryLoginUpdate = "update customer_login set username = '" + username + "', user_password = '" + password + "', fails = '0', user_status = 'Active' where id_customer_login = '" + id_login + "';";
            flag = SimpleExecuteNonQuery(queryLoginUpdate);
            return flag;
        }

        // ADMIN
        // ADMIN * Insert
        public bool InsertNewEmployee(string name, string role, string email, string tax_id, string username, string password)
        {
            bool flag = false;
            string queryLogin = "insert into employee_login (username, user_password) values ('" + username + "','" + password + "');";

            flag = SimpleExecuteNonQuery(queryLogin);

            if (flag)
            {
                string queryClientInfo = "insert into employee (id_employee_login, name_employee, tax_id, id_role, email) " +
                                "values ((select id_employee_login from employee_login where username = '" + username + "'), " +
                                "'" + name + "','" + tax_id + "', " +
                                "(select id_role from employee_role where role_name = '" + role + "'), '" + email + "');";

                flag = SimpleExecuteNonQuery(queryClientInfo);
            }
            return flag;
        }

        // ADMIN * Fill DataGridView        
        public void FillDataGridViewListEmployees(ref DataGridView dgv, string name, string role)
        {
            string query = "select id_employee, name_employee, role_name, email, tax_id, user_status from employee_view where 1=1";

            if (!string.IsNullOrEmpty(name))
            {
                query += " and name_employee = '" + name + "'";
            }
            if (!string.IsNullOrEmpty(role))
            {
                query += " and role_name = '" + role + "'";
            }

            query += " order by name_employee;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int idxLine = 0;

                    while (dr.Read())
                    {
                        dgv.Rows.Add(dr);
                        dgv.Rows[idxLine].Cells[0].Value = dr[0].ToString();
                        dgv.Rows[idxLine].Cells[1].Value = dr[1].ToString();
                        dgv.Rows[idxLine].Cells[2].Value = dr[2].ToString();
                        dgv.Rows[idxLine].Cells[3].Value = dr[3].ToString();
                        dgv.Rows[idxLine].Cells[4].Value = dr[4].ToString();
                        dgv.Rows[idxLine].Cells[5].Value = dr[5].ToString();
                        idxLine++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // ADMIN * SEARCH EMPLOYEES
        public bool SearchEmployee(string id_search, ref string name, ref string role, ref string email, ref string tax_id, ref string user_status)
        {
            bool flag = false;
            string query = "select name_employee, role_name, email, tax_id, user_status from employee_view where id_employee = '" + id_search + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        name = dataReader[0].ToString();
                        role = dataReader[1].ToString();
                        email = dataReader[2].ToString();
                        tax_id = dataReader[3].ToString();
                        user_status = dataReader[4].ToString();
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        // ADMIN * Update EMPLOYEES
        public bool UpdateEmployee(string id, string name, string role, string email, string tax_id)
        {
            bool flag = false;
            string query = "update employee set " +
                           "name_employee = '" + name + "', " +
                           "id_role = (select id_role from employee_role where role_name = '" + role + "'), " +
                           "email = '" + email + "', tax_id = '" + tax_id + "' " +
                           "where id_employee = '" + id + "';";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }

        public bool RegenerateEmployeeLogin(string id_search, string username, string password)
        {
            bool flag = false;
            string query = "select id_employee_login from employee where id_employee = '" + id_search + "';";
            string id_login = SimpleExecuteScalar(query).ToString();

            string queryLoginUpdate = "update employee_login set username = '" + username + "', user_password = '" + password + "', fails = '0', user_status = 'Active' where id_employee_login = '" + id_login + "';";
            flag = SimpleExecuteNonQuery(queryLoginUpdate);
            return flag;
        }

        // ADMIN * Insert Employee ROLES
        public bool InsertNewCompanyRole(string new_role_name)
        {
            bool flag = false;
            string query = "insert into employee_role (role_name) values ('" + new_role_name + "');";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }
        // ADMIN * Update Employee ROLES
        public bool UpdateCompanyRole(string old_name, string new_name)
        {
            bool flag = false;
            string query = "update employee_role set " +
                           "role_name = '" + new_name + "' where role_name = '" + old_name + "';";

            flag = SimpleExecuteNonQuery(query);
            return flag;
        }
        // ADMIN * Delete Employee ROLES
        public bool DeleteCompanyRole(string role_name)
        {
            bool flag = false;
            string query = "SELECT COUNT(*) FROM employee_view WHERE role_name = '" + role_name + "';";
            int count = Convert.ToInt32(SimpleExecuteScalar(query));

            if (count == 0)
            {
                string queryDelete = "delete from employee_role where role_name = '" + role_name + "';";
                flag = SimpleExecuteNonQuery(queryDelete);
            }
            else
            {
                MessageBox.Show("Role is being used / associated with employees.");
            }
            return flag;
        }

        // ADMIN * Insert PAYMENT METHOD
        public bool InsertNewPaymentMethod(string new_pm)
        {
            bool flag = false;
            string query = "insert into payment_method (payment_method) values ('" + new_pm + "');";
            flag = SimpleExecuteNonQuery(query);
            return flag;
        }
        // ADMIN * Update PAYMENT METHOD
        public bool UpdatePaymentMethod(string old_name, string new_name)
        {
            bool flag = false;
            string query = "update payment_method set " +
                           "payment_method = '" + new_name + "' where payment_method = '" + old_name + "';";
            flag = SimpleExecuteNonQuery(query);
            return flag;
        }
        // ADMIN * Delete PAYMENT METHOD
        public bool DeletePaymentMethod(string payment_method)
        {
            bool flag = false;
            string query = "SELECT COUNT(*) FROM build_view WHERE payment_method = '" + payment_method + "';";            
            int count = Convert.ToInt32(SimpleExecuteScalar(query));

            if (count == 0)
            {
                string queryDelete = "delete from payment_method where payment_method = '" + payment_method + "';";
                flag = SimpleExecuteNonQuery(queryDelete);
            }
            else
            {
                MessageBox.Show("Payment Method is being used / associated with builds.");
            }
            return flag;
        }
    }
}
