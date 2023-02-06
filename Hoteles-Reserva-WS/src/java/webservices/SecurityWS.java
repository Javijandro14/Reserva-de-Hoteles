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
    public List<Users> getLstUser(){
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
/*
    @WebMethod(operationName = "createUser")
    public boolean createUser(@WebParam(name = "user") User user) {
        return security.createUser(user);
    }*/
/*
    @WebMethod(operationName = "createModule")
    public boolean createModule(@WebParam(name = "module") Module module) {
        return security.createModule(module);
    }

    @WebMethod(operationName = "createPermissions")
    public boolean createPermissions(@WebParam(name = "permisions") Permissions permisions) {
        return security.createPermissions(permisions);
    }

    @WebMethod(operationName = "createRole")
    public boolean createRole(@WebParam(name = "role") Role role) {
        return security.createRole(role);
    }

    @WebMethod(operationName = "getUser")
    public User getUser(@WebParam(name = "idUser") int idUser) {
        return security.getUser(idUser);
    }

    @WebMethod(operationName = "getModule")
    public Module getModule(@WebParam(name = "idModule") int idModule) {
        return security.getModule(idModule);
    }

    @WebMethod(operationName = "getPermissions")
    public Permissions getPermissions(@WebParam(name = "idPermision") int idPermision) {
        return security.getPermissions(idPermision);
    }

    @WebMethod(operationName = "getRole")
    public Role getRole(@WebParam(name = "idRole") int idRole) {
        return security.getRole(idRole);
    }

    @WebMethod(operationName = "updateUser")
    public boolean updateUser(@WebParam(name = "user") User user) {
        return security.updateUser(user);
    }

    @WebMethod(operationName = "updateModule")
    public boolean updateModule(@WebParam(name = "module") Module module) {
        return security.updateModule(module);
    }

    @WebMethod(operationName = "updatePermissions")
    public boolean updatePermissions(@WebParam(name = "permisions") Permissions permisions) {
        return security.updatePermissions(permisions);
    }

    @WebMethod(operationName = "updateRole")
    public boolean updateRole(@WebParam(name = "role") Role role) {
        return security.updateRole(role);
    }

    @WebMethod(operationName = "deleteUser")
    public boolean deleteUser(@WebParam(name = "user") User user) {
        return security.deleteUser(user);
    }

    @WebMethod(operationName = "deleteModule")
    public boolean deleteModule(@WebParam(name = "module") Module module) {
        return security.deleteModule(module);
    }

    @WebMethod(operationName = "deletePermissions")
    public boolean deletePermissions(@WebParam(name = "permisions") Permissions permisions) {
        return security.deletePermissions(permisions);
    }

    @WebMethod(operationName = "deleteRole")
    public boolean deleteRole(@WebParam(name = "role") Role role) {
        return security.deleteRole(role);
    }*/
}
