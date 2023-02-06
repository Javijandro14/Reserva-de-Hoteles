package models;

public class PackageInfo {
    private int idPackages;
    private String name;
    private Boolean active;

    public int getIdPackages() {
        return idPackages;
    }

    public void setIdPackages(int idPackages) {
        this.idPackages = idPackages;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Boolean getActive() {
        return active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }
    
    
}
