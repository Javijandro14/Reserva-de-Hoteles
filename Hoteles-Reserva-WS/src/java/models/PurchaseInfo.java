package models;

public class PurchaseInfo {
    private int idPurchaseInfo;
    private double cost, discounts, total;
    private String description, dateTransaction;
    private Purchase purchase;

    public int getIdPurchaseInfo() {
        return idPurchaseInfo;
    }

    public void setIdPurchaseInfo(int idPurchaseInfo) {
        this.idPurchaseInfo = idPurchaseInfo;
    }

    public double getCost() {
        return cost;
    }

    public void setCost(double cost) {
        this.cost = cost;
    }

    public double getDiscounts() {
        return discounts;
    }

    public void setDiscounts(double discounts) {
        this.discounts = discounts;
    }

    public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getDateTransaction() {
        return dateTransaction;
    }

    public void setDateTransaction(String dateTransaction) {
        this.dateTransaction = dateTransaction;
    }

    public Purchase getPurchase() {
        return purchase;
    }

    public void setPurchase(Purchase purchase) {
        this.purchase = purchase;
    }
    
    
}
