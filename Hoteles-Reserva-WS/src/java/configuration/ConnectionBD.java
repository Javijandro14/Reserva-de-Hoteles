package configuration;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ConnectionBD {

    private PreparedStatement ps = null;
    private Connection con = null;
    private ResultSet rs = null;
    String database = "ReservaHoteles", urlDB = "jdbc:sqlserver://JAVIER\\\\\\\\SQLEXPRESS\\\\\\\\:1433;databaseName="+database, userDB = "sa", passDB = "12345", driver = "com.microsoft.sqlserver.jdbc.SQLServerDriver";

    public Connection open() throws ClassNotFoundException {
        Class.forName(driver);
        try {
            con = DriverManager.getConnection(urlDB, userDB, passDB);
            return con;
        } catch (SQLException ex) {
            Logger.getLogger(ConnectionBD.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }

    public void close() throws Exception {
        try {
            if (con != null) {
                con.clearWarnings();
                con.close();
            }
        } catch (SQLException ex) {
            con = null;
            Logger.getLogger(ConnectionBD.class.getName()).log(Level.SEVERE, null, ex);
            throw new Exception(ex.getMessage());
        }
    }
    
    public boolean executeSQL(String cmd) throws Exception{
        if (cmd == null) return false;
        try{
            this.ps = this.con.prepareStatement(cmd);
            this.ps.executeUpdate();
            return true;
        }catch(SQLException e){
            throw new Exception(e.getMessage());
        }
    }
    public ResultSet exexuteQuery(String query){
        try {
            ps = con.prepareStatement(query);
            rs = ps.executeQuery();
        } catch (SQLException ex) {
            System.out.println("Error Message has been created:" + ex.toString());
            Logger.getLogger(ConnectionBD.class.getName()).log(Level.SEVERE, null, ex);
        }
        return rs;
    }
    
}
