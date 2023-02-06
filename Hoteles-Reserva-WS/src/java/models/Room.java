package models;

public class Room {
    private int idRoom, numShowers, numRooms;
    private String description, dateCrea, dateMod;
    private RoomItems roomItems;
    private Area area;

    public int getIdRoom() {
        return idRoom;
    }

    public void setIdRoom(int idRoom) {
        this.idRoom = idRoom;
    }

    public int getNumShowers() {
        return numShowers;
    }

    public void setNumShowers(int numShowers) {
        this.numShowers = numShowers;
    }

    public int getNumRooms() {
        return numRooms;
    }

    public void setNumRooms(int numRooms) {
        this.numRooms = numRooms;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getDateCrea() {
        return dateCrea;
    }

    public void setDateCrea(String dateCrea) {
        this.dateCrea = dateCrea;
    }

    public String getDateMod() {
        return dateMod;
    }

    public void setDateMod(String dateMod) {
        this.dateMod = dateMod;
    }

    public RoomItems getRoomItems() {
        return roomItems;
    }

    public void setRoomItems(RoomItems roomItems) {
        this.roomItems = roomItems;
    }

    public Area getArea() {
        return area;
    }

    public void setArea(Area area) {
        this.area = area;
    }
    
}
