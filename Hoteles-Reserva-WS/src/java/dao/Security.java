package dao;

import configuration.ConnectionBD;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import models.*;

public class Security {

    Users user;
    Module module;
    Permissions permissions;
    Role role;

    Maintenence maintenence;

    String query = "";
    ConnectionBD con = new ConnectionBD();
    ResultSet rs = null;
    boolean res = false;

    public List<Users> getLstUser() {
        List<Users> lstUser = new ArrayList<>();
        query = "SELECT * FROM USER";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                user = new Users();
                /*user.setIdUser(rs.getInt("IDUSER"));
                user.setUsername(rs.getString("USERNAME"));
                user.setPass(rs.getString("PASSWD"));
                user.setType(rs.getString("TYPE"));
                user.setDateCrea(rs.getString("CREATION_DATE"));
                user.setDateMod(rs.getString("MODIFICATION_DATE"));
                user.setActive(rs.getInt("ACTIVE") == 1);
                user.setPerson(maintenence.getPerson(rs.getInt("IDPERSON")));*/
                lstUser.add(user);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            //System.out.println("Error getting userlist");
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstUser;
    }

    public List<Module> getLstModule() {
        List<Module> lstModule = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                module = new Module();
                
                lstModule.add(module);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstModule;
    }

    public List<Permissions> getLstPermissions() {
        List<Permissions> lstPermissions = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                permissions = new Permissions();
                
                lstPermissions.add(permissions);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstPermissions;
    }

    public List<Role> getLstRole() {
        List<Role> lstRole = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                role = new Role();
                user.setIdUser(rs.getInt(""));
                user.setUsername(rs.getString(""));
                lstRole.add(role);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstRole;
    }

    public boolean createUser(Users user) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createModule(Module module) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createPermissions(Permissions permisions) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createRole(Role role) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public Users getUser(int idUser) {
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            user = new Users();
            user.setIdUser(rs.getInt(""));
            user.setUsername(rs.getString(""));
            user.setPass(rs.getString(""));
            user.setType(rs.getString(""));
            user.setDateCrea(rs.getString(""));
            user.setDateMod(rs.getString(""));
            user.setActive(rs.getInt("") == 1);
            user.setPerson(maintenence.getPerson(rs.getInt("")));
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return user;
    }

    public Module getModule(int idModule) {
         query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            module = new Module();
            
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return module;
    }

    public Permissions getPermissions(int idPermision) {
         query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            permissions = new Permissions();
            
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return permissions;
    }

    public Role getRole(int idRole) {
         query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            role = new Role();
            
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return role;
    }

    public boolean updateUser(Users user) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updateModule(Module module) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updatePermissions(Permissions permisions) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updateRole(Role role) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean deleteUser(Users user) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean deleteModule(Module module) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean deletePermissions(Permissions permisions) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean deleteRole(Role role) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Security.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

}
