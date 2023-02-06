package models;

import java.util.List;

public class Meal {
    private int idMeal;
    private String name, description;
    private double cost;
    private Boolean active;
    private List<Food> lstFood;

    public int getIdMeal() {
        return idMeal;
    }

    public void setIdMeal(int idMeal) {
        this.idMeal = idMeal;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public double getCost() {
        return cost;
    }

    public void setCost(double cost) {
        this.cost = cost;
    }

    public Boolean getActive() {
        return active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    public List<Food> getLstFood() {
        return lstFood;
    }

    public void setLstFood(List<Food> lstFood) {
        this.lstFood = lstFood;
    }
    
}
