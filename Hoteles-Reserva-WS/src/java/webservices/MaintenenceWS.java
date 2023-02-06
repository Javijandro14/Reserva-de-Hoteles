package webservices;

import dao.Maintenence;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import models.*;

@WebService(serviceName = "MaintenenceWS")
public class MaintenenceWS {
    
    Maintenence maintenence = new Maintenence();
    
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
}
