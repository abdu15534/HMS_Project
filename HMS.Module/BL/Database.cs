using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Module.BL
{
     public class DataBase
        {

            static SqlConnection con { get; set; }
            static SqlCommand cmd { get; set; }
            static SqlDataReader dr { get; set; }
            static string connectionString { get; set; }
            static string sql { get; set; }

            public DataBase()
            {

            }

            public static async Task BackUp(string connectionString, string DataBase)
            {

                con = new SqlConnection(connectionString);
                string dir = Path.GetPathRoot(Environment.SystemDirectory) + "Backup";
                //string dir = "C:\\Backup";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                string path = Path.Combine(dir, $"backup-{DateTime.Now.Ticks}.bak");

                try
                {
                    sql = $"BACKUP DATABASE {DataBase} TO DISK = '{path}'";

                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();

                    cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم عمل نسخة احتياطية بنجاح!", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"حدثت مشكلة اثناء محاولة عمل نسخة احتياطية!. نص الخطا :- /n {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                }
            }

            public static async Task Restore(string connectionString, string DataBase)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
                ofd.FilterIndex = 0;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        con = new SqlConnection(connectionString);

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        sql = $"Alter Database {DataBase} Set offline WITH ROLLBACK IMMEDIATE;";
                        sql += $"Restore Database {DataBase} FROM Disk = '{ofd.FileName}' WITH REPLACE,RECOVERY;";


                        cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("تم استعادة نسخة احتياطية بنجاح!", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"حدثت مشكلة اثناء محاولة استعادة نسخة احتياطية!. نص الخطا :- /n {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql = $"Alter Database {DataBase} set online;";
                        cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();

                        if (con.State == System.Data.ConnectionState.Open)
                            con.Close();
                    }
                }
            }

        }
    
}
