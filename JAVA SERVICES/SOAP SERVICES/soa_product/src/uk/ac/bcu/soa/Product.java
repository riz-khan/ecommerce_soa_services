package uk.ac.bcu.soa;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 *
 * @author CMP7174User
 */
public class Product {
    private String id;
    private String name;
    private double price;
    private Integer quantity;
    private String barCode;
    private boolean active;

    public Product(String id,String name,Double price,int quantity,String barCode,boolean active){
        this.id = id;
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.barCode = barCode;
        this.active = active;
    }
    
    public String getCSV(){
        return this.id+","+
                    this.name+","+
                    this.price+","+
                    this.quantity+","+
                    this.barCode+","+
                    this.active;
        
    }
    
    public Product(){
    }
    
    public void printProduct(){
        System.out.println("----------------------");
        System.out.println("id = "+id);
        System.out.println("name = "+name);
        System.out.println("price = "+price);
        System.out.println("quantity = "+quantity);
        System.out.println("barCode = "+barCode);
        System.out.println("active = "+active);
        System.out.println("----------------------");
    }
    
    //GETTER SETTER
    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public Integer getQuantity() {
        return quantity;
    }

    public void setQuantity(Integer quantity) {
        this.quantity = quantity;
    }

    public String getBarCode() {
        return barCode;
    }

    public void setBarCode(String barCode) {
        this.barCode = barCode;
    }

    public boolean isActive() {
        return active;
    }

    public void setActive(boolean active) {
        this.active = active;
    }
}
