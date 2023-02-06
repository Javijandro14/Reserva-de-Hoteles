package dao;

import configuration.ConnectionBD;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import models.*;

public class Maintenence {

    Area area;
    Client client;
    Employee employee;
    Events events;
    Food food;
    Packages packages;
    PackageInfo packageInfo;
    Person person;
    Purchase purchase;
    PurchaseInfo purchaseInfo;
    Reservation reservation;
    Restaurant restaurant;
    Room room;

    String query = "";
    ConnectionBD con = new ConnectionBD();
    ResultSet rs = null;
    boolean res = false;

    Security security;

    public List<Area> getLstArea() {
        List<Area> lstArea = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                area = new Area();
                area.setIdArea(rs.getInt(""));
                area.setName(rs.getString(""));
                area.setDescription(rs.getString(""));
                area.setLevel(rs.getString(""));
                area.setDateCrea(rs.getString(""));
                area.setDateMod(rs.getString(""));
                area.setActive(rs.getInt("") == 1);
                lstArea.add(area);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstArea;
    }

    public List<Client> getLstClient() {
        List<Client> lstClient = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                client = new Client();
                client.setIdClient(rs.getInt(""));
                client.setDateCrea(rs.getString(""));
                client.setDateMod(rs.getString(""));
                client.setActive(rs.getInt("") == 1);
                client.setUser(security.getUser(rs.getInt("")));
                lstClient.add(client);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstClient;
    }

    public List<Employee> getLstEmployee() {
        List<Employee> lstEmployee = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                employee = new Employee();
                employee.setIdEmployee(rs.getInt(""));
                employee.setRole(rs.getString(""));
                employee.setDateCrea(rs.getString(""));
                employee.setDateMod(rs.getString(""));
                employee.setActive(rs.getInt("") == 1);
                employee.setUser(security.getUser(rs.getInt("")));
                lstEmployee.add(employee);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstEmployee;
    }

    public List<Events> getLstEvents() {
        List<Events> lstEvents = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                events = new Events();

                lstEvents.add(events);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstEvents;
    }

    public List<Food> getLstFood() {
        List<Food> lstFood = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                food = new Food();

                lstFood.add(food);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstFood;
    }

    public List<Packages> getLstPackages() {
        List<Packages> lstPackages = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                packages = new Packages();

                lstPackages.add(packages);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstPackages;
    }

    public List<Person> getLstPerson() {
        List<Person> lstPerson = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                person = new Person();
                person.setIdPerson(rs.getInt(""));
                person.setfName(rs.getString(""));
                person.setsName(rs.getString(""));
                person.setoName(rs.getString(""));
                person.setfSurname(rs.getString(""));
                person.setsSurname(rs.getString(""));
                person.setmSurname(rs.getString(""));
                person.setDob(rs.getString(""));
                person.setGender(rs.getString(""));
                person.setIdNo(rs.getString(""));
                person.setPhone(rs.getString(""));
                person.setEmail(rs.getString(""));
                person.setEthnicity(rs.getString(""));
                person.setDateCrea(rs.getString(""));
                person.setDateMod(rs.getString(""));
                person.setActive(rs.getInt("") == 1);
                lstPerson.add(person);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstPerson;
    }

    public List<Purchase> getLstPurchase() {
        List<Purchase> lstPurchase = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                purchase = new Purchase();

                lstPurchase.add(purchase);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstPurchase;
    }

    public List<PurchaseInfo> getLstPurchaseInfo(int idPurchase) {
        List<PurchaseInfo> lstPurchaseInfo = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                purchaseInfo = new PurchaseInfo();

                lstPurchaseInfo.add(purchaseInfo);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstPurchaseInfo;
    }

    public List<Reservation> getLstReservation() {
        List<Reservation> lstReservation = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                reservation = new Reservation();

                lstReservation.add(reservation);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstReservation;
    }

    public List<Restaurant> getLstRestaurant() {
        List<Restaurant> lstRestaurant = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                restaurant = new Restaurant();

                lstRestaurant.add(restaurant);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstRestaurant;
    }

    public List<Room> getLstRoom() {
        List<Room> lstRoom = new ArrayList<>();
        query = "";
        try {
            con.open();
            rs = con.exexuteQuery(query);
            while (rs.next()) {
                room = new Room();

                lstRoom.add(room);
            }
            rs.close();
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return lstRoom;
    }

    public boolean createArea(Area area) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createClient(Client client) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createEmployee(Employee employee) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createEvents(Events events) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createFood(Food food) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createPackages(Packages packages) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createPerson(Person person) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createPurchase(Purchase purchase) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createReservation(Reservation reservation) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createRestaurant(Restaurant restaurant) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean createRoom(Room room) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public Area getArea(int idArea) {
        return area;
    }

    public Client getClient(int idClient) {
        return client;
    }

    public Employee getEmployee(int idEmployee) {
        return employee;
    }

    public Events getEvents(int idEvents) {
        return events;
    }

    public Food getFood(int idFood) {
        return food;
    }

    public Packages getPackages(int idPackages) {
        return packages;
    }

    public Person getPerson(int idPerson) {
        return person;
    }

    public Purchase getPurchase(int idPurchase) {
        return purchase;
    }

    public Reservation getReservation(int idReservation) {
        return reservation;
    }

    public Restaurant getRestaurant(int idRestaurant) {
        return restaurant;
    }

    public Room getRoom(int idRoom) {
        return room;
    }

    public boolean updateArea(Area area) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updateClient(Client client) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updateEmployee(Employee employee) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updateEvents(Events events) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updateFood(Food food) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updatePackages(Packages packages) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updatePerson(Person person) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updatePurchase(Purchase purchase) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updatePurchaseInfo(PurchaseInfo purchaseInfo) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updateReservation(Reservation reservation) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updateRestaurant(Restaurant restaurant) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }

    public boolean updateRoom(Room room) {
        try {
            query = "";
            con.open();
            res = con.executeSQL(query);
            con.close();
        } catch (Exception ex) {
            Logger.getLogger(Maintenence.class.getName()).log(Level.SEVERE, null, ex);
        }
        return res;
    }
    
    public boolean deleteArea(Area area) {
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
    public boolean deleteClient(Client client) {
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
    public boolean deleteEmployee(Employee employee) {
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
    public boolean deleteEvents(Events events) {
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
    public boolean deleteFood(Food food) {
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
    public boolean deletePackages(Packages packages) {
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
    public boolean deletePerson(Person person) {
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
    public boolean deletePurchase(Purchase purchase) {
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
    public boolean deletePurchaseInfo(PurchaseInfo purchaseInfo) {
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
    public boolean deleteReservation(Reservation reservation) {
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
    public boolean deleteRestaurant(Restaurant restaurant) {
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
    public boolean deleteRoom(Room room) {
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
