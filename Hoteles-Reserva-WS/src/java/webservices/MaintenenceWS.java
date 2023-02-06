package webservices;

import dao.Maintenence;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import models.*;

@WebService(serviceName = "MaintenenceWS")
public class MaintenenceWS {
    
    Maintenence maintenence = new Maintenence();

    public List<Area> getLstArea() {
        return maintenence.getLstArea();
    }

    public List<Client> getLstClient() {
        return maintenence.getLstClient();
    }

    public List<Employee> getLstEmployee() {
        return maintenence.getLstEmployee();
    }

    public List<Events> getLstEvents() {
        return maintenence.getLstEvents();
    }

    public List<Food> getLstFood() {
        return maintenence.getLstFood();
    }

    public List<Packages> getLstPackages() {
        return maintenence.getLstPackages();
    }

    public List<Person> getLstPerson() {
        return maintenence.getLstPerson();
    }

    public List<Purchase> getLstPurchase() {
        return maintenence.getLstPurchase();
    }

    public List<PurchaseInfo> getLstPurchaseInfo(int idPurchase) {
        return maintenence.getLstPurchaseInfo(idPurchase);
    }

    public List<Reservation> getLstReservation() {
        return maintenence.getLstReservation();
    }

    public List<Restaurant> getLstRestaurant() {
        return maintenence.getLstRestaurant();
    }

    public List<Room> getLstRoom() {
        return maintenence.getLstRoom();
    }

    public boolean createArea(Area area) {
        return maintenence.createArea(area);
    }

    public boolean createClient(Client client) {
        return maintenence.createClient(client);
    }

    public boolean createEmployee(Employee employee) {
        return maintenence.createEmployee(employee);
    }

    public boolean createEvents(Events events) {
        return maintenence.createEvents(events);
    }

    public boolean createFood(Food food) {
        return maintenence.createFood(food);
    }

    public boolean createPackages(Packages packages) {
        return maintenence.createPackages(packages);
    }

    public boolean createPerson(Person person) {
        return maintenence.createPerson(person);
    }

    public boolean createPurchase(Purchase purchase) {
        return maintenence.createPurchase(purchase);
    }

    public boolean createReservation(Reservation reservation) {
        return maintenence.createReservation(reservation);
    }

    public boolean createRestaurant(Restaurant restaurant) {
        return maintenence.createRestaurant(restaurant);
    }

    public boolean createRoom(Room room) {
        return maintenence.createRoom(room);
    }

    public Area getArea(int idArea) {
        return maintenence.getArea(idArea);
    }

    public Client getClient(int idClient) {
        return maintenence.getClient(idClient);
    }

    public Employee getEmployee(int idEmployee) {
        return maintenence.getEmployee(idEmployee);
    }

    public Events getEvents(int idEvents) {
        return maintenence.getEvents(idEvents);
    }

    public Food getFood(int idFood) {
        return maintenence.getFood(idFood);
    }

    public Packages getPackages(int idPackages) {
        return maintenence.getPackages(idPackages);
    }

    public Person getPerson(int idPerson) {
        return maintenence.getPerson(idPerson);
    }

    public Purchase getPurchase(int idPurchase) {
        return maintenence.getPurchase(idPurchase);
    }

    public Reservation getReservation(int idReservation) {
        return maintenence.getReservation(idReservation);
    }

    public Restaurant getRestaurant(int idRestaurant) {
        return maintenence.getRestaurant(idRestaurant);
    }

    public Room getRoom(int idRoom) {
        return maintenence.getRoom(idRoom);
    }

    public boolean updateArea(Area area) {
        return maintenence.updateArea(area);
    }

    public boolean updateClient(Client client) {
        return maintenence.updateClient(client);
    }

    public boolean updateEmployee(Employee employee) {
        return maintenence.updateEmployee(employee);
    }

    public boolean updateEvents(Events events) {
        return maintenence.updateEvents(events);
    }

    public boolean updateFood(Food food) {
        return maintenence.updateFood(food);
    }

    public boolean updatePackages(Packages packages) {
        return maintenence.updatePackages(packages);
    }

    public boolean updatePerson(Person person) {
        return maintenence.updatePerson(person);
    }

    public boolean updatePurchase(Purchase purchase) {
        return maintenence.updatePurchase(purchase);
    }

    public boolean updatePurchaseInfo(PurchaseInfo purchaseInfo) {
        return maintenence.updatePurchaseInfo(purchaseInfo);
    }

    public boolean updateReservation(Reservation reservation) {
        return maintenence.updateReservation(reservation);
    }

    public boolean updateRestaurant(Restaurant restaurant) {
        return maintenence.updateRestaurant(restaurant);
    }

    public boolean updateRoom(Room room) {
        return maintenence.updateRoom(room);
    }

    public boolean deleteArea(Area area) {
        return maintenence.deleteArea(area);
    }

    public boolean deleteClient(Client client) {
        return maintenence.deleteClient(client);
    }

    public boolean deleteEmployee(Employee employee) {
        return maintenence.deleteEmployee(employee);
    }

    public boolean deleteEvents(Events events) {
        return maintenence.deleteEvents(events);
    }

    public boolean deleteFood(Food food) {
        return maintenence.deleteFood(food);
    }

    public boolean deletePackages(Packages packages) {
        return maintenence.deletePackages(packages);
    }

    public boolean deletePerson(Person person) {
        return maintenence.deletePerson(person);
    }

    public boolean deletePurchase(Purchase purchase) {
        return maintenence.deletePurchase(purchase);
    }

    public boolean deletePurchaseInfo(PurchaseInfo purchaseInfo) {
        return maintenence.deletePurchaseInfo(purchaseInfo);
    }

    public boolean deleteReservation(Reservation reservation) {
        return maintenence.deleteReservation(reservation);
    }

    public boolean deleteRestaurant(Restaurant restaurant) {
        return maintenence.deleteRestaurant(restaurant);
    }

    public boolean deleteRoom(Room room) {
        return maintenence.deleteRoom(room);
    }
    
}
