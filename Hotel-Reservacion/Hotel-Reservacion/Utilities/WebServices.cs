using Hotel_Reservacion.Models;
using System.Collections.Generic;
using System.Data;

namespace Hotel_Reservacion.Utilities
{
    public class WebServices
    {
        WebSecurity.SecurityWSClient security = new WebSecurity.SecurityWSClient();
        WebMaintenence.MaintenenceWSClient maintenence = new WebMaintenence.MaintenenceWSClient();
        WebOrders.OrdersWSClient orders = new WebOrders.OrdersWSClient();
        WebProcess.ProcessWSClient process = new WebProcess.ProcessWSClient();
        WebReports.ReportsWSClient reports = new WebReports.ReportsWSClient();
        
        public DataTable getLstUser()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));

            
            foreach(var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[1] = u.username;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstModule()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstPermissions()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstRole()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstArea()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstClient()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstEmployee()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstEvents()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstFood()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstPackages()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstPerson()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstPurchase()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstReservation()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstRestaurant()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        public DataTable getLstRoom()
        {
            DataTable dt = new DataTable();
            DataColumn id = null;
            var rsUser = security.getLstUser();

            id = dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));
            dt.Columns.Add("", typeof(int));


            foreach (var u in rsUser)
            {
                DataRow column = dt.NewRow();
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                column[0] = u.idUser;
                dt.Rows.Add(column);
            }
            return dt;
        }
        
        public bool createUser(User user)
        {
            return security.createUser(user);
        }
        public bool createModule(Module module)
        {
            return security.createModule(module);
        }
        public bool createPermissions(Permissions permisions)
        {
            return security.createPermissions(permisions);
        }
        public bool createRole(Role role)
        {
            return security.createRole(role);
        }
        public bool createArea(Area area)
        {
            return maintenence.createArea(area);
        }
        public bool createClient(Client client)
        {
            return maintenence.createClient(client);
        }
        public bool createEmployee(Employee employee)
        {
            return maintenence.createEmployee(employee);
        }
        public bool createEvents(Events events)
        {
            return maintenence.createEvents(events);
        }
        public bool createFood(Food food)
        {
            return maintenence.createFood(food);
        }
        public bool createPackages(Packages packages)
        {
            return maintenence.createPackages(packages);
        }
        public bool createPerson(Person person)
        {
            return maintenence.createPerson(person);
        }
        public bool createPurchase(Purchase purchase)
        {
            return maintenence.createPurchase(purchase);
        }
        public bool createReservation(Reservation reservation)
        {
            return maintenence.createReservation(reservation);
        }
        public bool createRestaurant(Restaurant restaurant)
        {
            return maintenence.createRestaurant(restaurant);
        }
        public bool createRoom(Room room)
        {
            return maintenence.createRoom(room);
        }

        public User getUser(int idUser)
        {
            return security.getUser(idUser);
        }
        public Module getModule(int idModule)
        {
            return security.getModule(idModule);
        }
        public Permissions getPermissions(int idPermision)
        {
            return security.getPermissions(idPermision);
        }
        public Role getRole(int idRole)
        {
            return security.getRole(idRole);
        }
        public Area getArea(int idArea)
        {
            return maintenence.getArea(idArea);
        }
        public Client getClient(int idClient)
        {
            return maintenence.getClient(idClient);
        }
        public Employee getEmployee(int idEmployee)
        {
            return maintenence.getEmployee(idEmployee);
        }
        public Events getEvents(int idEvents)
        {
            return maintenence.getEvents(idEvents);
        }
        public Food getFood(int idFood)
        {
            return maintenence.getFood(idFood);
        }
        public Packages getPackages(int idPackages)
        {
            return maintenence.getPackages(idPackages);
        }
        public Person getPerson(int idPerson)
        {
            return maintenence.getPerson(idPerson);
        }
        public Purchase getPurchase(int idPurchase)
        {
            return maintenence.getPurchase(idPurchase);
        }
        public Reservation getReservation(int idReservation)
        {
            return maintenence.getReservation(idReservation);
        }
        public Restaurant getRestaurant(int idRestaurant)
        {
            return maintenence.getRestaurant(idRestaurant);
        }
        public Room getRoom(int idRoom)
        {
            var get = maintenence.getRoom(idRoom);
            return new Room()
            {
                IdRoom = get.idRoom
            };
        }
        

        public bool updateUser(User user)
        {
            return security.updateUser(user);
        }
        public bool updateModule(Module module)
        {
            return security.updateModule(module);
        }
        public bool updatePermissions(Permissions permisions)
        {
            return security.updatePermissions(permisions);
        }
        public bool updateRole(Role role)
        {
            return security.updateRole(role);
        }
        public bool updateArea(Area area)
        {
            return maintenence.updateArea(area);
        }
        public bool updateClient(Client client)
        {
            return maintenence.updateClient(client);
        }
        public bool updateEmployee(Employee employee)
        {
            return maintenence.updateEmployee(employee);
        }
        public bool updateEvents(Events events)
        {
            return maintenence.updateEvents(events);
        }
        public bool updateFood(Food food)
        {
            return maintenence.updateFood(food);
        }
        public bool updatePackages(Packages packages)
        {
            return maintenence.updatePackages(packages);
        }
        public bool updatePerson(Person person)
        {
            return maintenence.updatePerson(person);
        }
        public bool updatePurchase(Purchase purchase)
        {
            return maintenence.updatePurchase(purchase);
        }
        public bool updatePurchaseInfo(PurchaseInfo purchaseInfo)
        {
            return maintenence.updatePurchaseInfo(purchaseInfo);
        }
        public bool updateReservation(Reservation reservation)
        {
            return maintenence.updateReservation(reservation);
        }
        public bool updateRestaurant(Restaurant restaurant)
        {
            return maintenence.updateRestaurant(restaurant);
        }
        public bool updateRoom(Room room)
        {
            return maintenence.updateRoom(room);
        }

        public bool deleteUser(User user)
        {
            return security.deleteUser(user);
        }
        public bool deleteModule(Module module)
        {
            return security.deleteModule(module);
        }
        public bool deletePermissions(Permissions permisions)
        {
            return security.deletePermissions(permisions);
        }
        public bool deleteRole(Role role)
        {
            return security.deleteRole(role);
        }
        public bool deleteArea(Area area)
        {
            return maintenence.deleteArea(area);
        }
        public bool deleteClient(Client client)
        {
            return maintenence.deleteClient(client);
        }
        public bool deleteEmployee(Employee employee)
        {
            return maintenence.deleteEmployee(employee);
        }
        public bool deleteEvents(Events events)
        {
            return maintenence.deleteEvents(events);
        }
        public bool deleteFood(Food food)
        {
            return maintenence.deleteFood(food);
        }
        public bool deletePackages(Packages packages)
        {
            return maintenence.deletePackages(packages);
        }
        public bool deletePerson(Person person)
        {
            return maintenence.deletePerson(person);
        }
        public bool deletePurchase(Purchase purchase)
        {
            return maintenence.deletePurchase(purchase);
        }
        public bool deletePurchaseInfo(PurchaseInfo purchaseInfo)
        {
            return maintenence.deletePurchaseInfo(purchaseInfo);
        }
        public bool deleteReservation(Reservation reservation)
        {
            return maintenence.deleteReservation(reservation);
        } 
        public bool deleteRestaurant(Restaurant restaurant)
        {
            return maintenence.deleteRestaurant(restaurant);
        }
        public bool DeleteRoom(Room room)
        {
            int id = room.IdRoom;
            return maintenence.deleteRoom(getRoom(id));
        }
    }
}