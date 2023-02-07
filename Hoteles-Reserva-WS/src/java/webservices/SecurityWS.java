package webservices;

import dao.Security;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import models.*;

@WebService(serviceName = "SecurityWS")
public class SecurityWS {
    
    Security security = new Security();
    @WebMethod(operationName = "getLstUser")    
    public List<User> getLstUser() {
        return security.getLstUser();
    }
    @WebMethod(operationName = "getLstModule")
    public List<Module> getLstModule() {
        return security.getLstModule();
    }
    @WebMethod(operationName = "getLstPermissions")
    public List<Permissions> getLstPermissions() {
        return security.getLstPermissions();
    }
    @WebMethod(operationName = "getLstRole")
    public List<Role> getLstRole() {
        return security.getLstRole();
    }
    
    @WebMethod(operationName = "createUser")
    public boolean createUser() {
        User user = new User();
        
        return security.createUser(user);
    }
    @WebMethod(operationName = "createModule")
    public boolean createModule(Module module) {
        return security.createModule(module);
    }
    @WebMethod(operationName = "createPermissions")
    public boolean createPermissions(Permissions permisions) {
        return security.createPermissions(permisions);
    }
    @WebMethod(operationName = "createRole")
    public boolean createRole(Role role) {
        return security.createRole(role);
    }
    @WebMethod(operationName = "getUser")
    public User getUser(int idUser) {
        return security.getUser(idUser);
    }
    @WebMethod(operationName = "getModule")
    public Module getModule(int idModule) {
        return security.getModule(idModule);
    }
    @WebMethod(operationName = "getPermissions")
    public Permissions getPermissions(int idPermision) {
        return security.getPermissions(idPermision);
    }
    @WebMethod(operationName = "getRole")
    public Role getRole(int idRole) {
        return security.getRole(idRole);
    }
    @WebMethod(operationName = "updateUser")
    public boolean updateUser(User user) {
        return security.updateUser(user);
    }
    @WebMethod(operationName = "updateModule")
    public boolean updateModule(Module module) {
        return security.updateModule(module);
    }
    @WebMethod(operationName = "updatePermissions")
    public boolean updatePermissions(Permissions permisions) {
        return security.updatePermissions(permisions);
    }
    @WebMethod(operationName = "updateRole")
    public boolean updateRole(Role role) {
        return security.updateRole(role);
    }
    @WebMethod(operationName = "deleteUser")
    public boolean deleteUser(User user) {
        return security.deleteUser(user);
    }
    @WebMethod(operationName = "deleteModule")
    public boolean deleteModule(Module module) {
        return security.deleteModule(module);
    }
    @WebMethod(operationName = "deletePermissions")
    public boolean deletePermissions(Permissions permisions) {
        return security.deletePermissions(permisions);
    }
    @WebMethod(operationName = "deleteRole")
    public boolean deleteRole(Role role) {
        return security.deleteRole(role);
    }
    
    
}
