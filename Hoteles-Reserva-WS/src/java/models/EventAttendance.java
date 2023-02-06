package models;

import java.util.List;

public class EventAttendance {
    private Events event;
    private List<Client> lstClient;

    public Events getEvent() {
        return event;
    }

    public void setEvent(Events event) {
        this.event = event;
    }

    public List<Client> getLstClient() {
        return lstClient;
    }

    public void setLstClient(List<Client> lstClient) {
        this.lstClient = lstClient;
    }
    
    
}
